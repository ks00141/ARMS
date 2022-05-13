using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ARMS.Model;
using log4net;
using Secs4Net;
using ARMS.Repository;

namespace ARMS.Service
{
    public class SecsGemService
    {
        readonly SecsGem driver;

        public event EventHandler<RecipeParam[]> RecipeParamUploadEvent;
        public event EventHandler<RunRecipeParam> RecipeParamCheckEvent;
        private static readonly ILog log = LogManager.GetLogger("ARMS/SecsGem Service");

        public SecsGemService()
        {
            try
            {
                driver = new SecsGem(false, IPAddress.Any, 5000);
                log.Info("SECS/GEM Driver is initialized");
                driver.PrimaryMessageReceived += MsgReceived;
            }
            catch(Exception e)
            {
                log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", e);
            }
        }

        public void SecsGemStart()
        {
            try
            {
                driver.Start();
                log.Info("SECS/GEM Driver Start");
            }
            catch (Exception e)
            {
                log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", e);
            }
        }

        public void MsgReceived(object sender, PrimaryMessageWrapper pMsg)
        {
            int F = pMsg.Message.F;
            int S = pMsg.Message.S;
            log.Info($"SECS/GEM Message received, S{S} F{F}");

            switch (S)
            {
                case 1:
                    switch (F)
                    {
                        case 13:
                            pMsg.ReplyAsync(new ECRRepository().S1F14());
                            break;
                    }
                    break;

                case 2:
                    switch (F)
                    {
                        case 41:
                            string RCMD = pMsg.Message.SecsItem.Items[0].GetValue<string>();
                            log.Info($"RMCD : {RCMD}");
                            ParaCheckRepository paraCheckRepository = new ParaCheckRepository(pMsg);
                            if(RCMD == "RECIPE_PARA_CHECK")
                            {
                                RecipeParam r = paraCheckRepository.GetSecsGemParam();
                                RunRecipeParam runInfo = paraCheckRepository.GetRunInfo(r);
                                RecipeParamCheckEvent?.Invoke(this, runInfo);
                                pMsg.ReplyAsync(paraCheckRepository.S2F42());
                                try
                                {
                                    byte FLAG = new EntityCompare(paraCheckRepository.GetParams())
                                    .compare();
                                    if (FLAG == 0)
                                    {
                                        driver.SendAsync(paraCheckRepository.S6F11Succ());
                                    }
                                    else
                                    {
                                        driver.SendAsync(paraCheckRepository.S6F11Fail());
                                    }
                                }
                                catch
                                {
                                    driver.SendAsync(paraCheckRepository.S6F11Fail());
                                }
                                
                            }
                            else if (RCMD == "RECIPE_PARA_UPLOAD")
                            {
                                ParaUploadRepository paraUploadRepository = new ParaUploadRepository(pMsg);
                                pMsg.ReplyAsync(paraUploadRepository.S2F42());
                                RecipeParamUploadEvent?.Invoke(this, paraCheckRepository.GetParams());
                            }
                            break;
                    }
                    break;
            }
        }

        public void ParamUploadRequest(string ppid)
        {
            driver.SendAsync(new SecsMessage(
                            6,
                            11,
                            "S6F11",
                            Item.L(
                                Item.U4(0),
                                Item.U4(3000),
                                Item.L(
                                    Item.L(
                                        Item.U4(1),
                                        Item.L(
                                            Item.L(
                                                Item.A("RECIPEID"),
                                                Item.A(ppid.Replace('/', '\\'))
                                            )
                                        )
                                    )
                                )
                            )
                        )
                    );
        }

        public void DBParamUpload(RecipeParam param)
        {
            new ParaUploadDbRepository().DBParamUpload(param);
        }
    }
}
