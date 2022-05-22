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
                log.Info("SecsGem Driver is initialized");
                log.Info($"Port : {5000}");
                LogPresenter.SetLogString("SecsGem Service Ready");
                driver.PrimaryMessageReceived += MsgReceived;
            }
            catch(Exception e)
            {
                LogPresenter.SetLogString("SecsGem Service Not Ready");
                LogPresenter.SetLogString(e.Message);
                log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", e);
            }
        }

        public void SecsGemStart()
        {
            try
            {
                driver.Start();
                log.Info("SecsGem Driver Start");
                LogPresenter.SetLogString("SecsGem Driver Ready");
            }
            catch (Exception e)
            {
                log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", e);
                LogPresenter.SetLogString("SecsGem Driver Not Ready");
                LogPresenter.SetLogString(e.Message);
            }
        }

        public void MsgReceived(object sender, PrimaryMessageWrapper pMsg)
        {
            int F = pMsg.Message.F;
            int S = pMsg.Message.S;
            log.Info($"SecsGem message received, S{S} F{F}");
            LogPresenter.SetLogString($"SecsGem message received, S{S} F{F}");

            switch (S)
            {
                case 1:
                    switch (F)
                    {
                        case 13:
                            pMsg.ReplyAsync(new ECRRepository().S1F14());
                            log.Info("SecsGem message reply, S1 F14");
                            LogPresenter.SetLogString("SecsGem message reply, S1 F14");
                            break;
                    }
                    break;

                case 2:
                    switch (F)
                    {
                        case 41:
                            string RCMD = pMsg.Message.SecsItem.Items[0].GetValue<string>();
                            log.Info($"S2 F41 message RMCD : {RCMD}");
                            LogPresenter.SetLogString($"S2 F41 message RMCD : {RCMD}");
                            ParaCheckRepository paraCheckRepository = new ParaCheckRepository(pMsg);
                            if(RCMD == "RECIPE_PARA_CHECK")
                            {
                                RecipeParam r = paraCheckRepository.GetSecsGemParam();
                                RunRecipeParam runInfo = paraCheckRepository.GetRunInfo(r);
                                pMsg.ReplyAsync(paraCheckRepository.S2F42());
                                LogPresenter.SetLogString("SecsGem message reply S2 F42");
                                LogPresenter.SetLogString($"Lot ID : {runInfo.LotId}");
                                LogPresenter.SetLogString($"Port Number : {runInfo.Port}");
                                LogPresenter.SetLogString($"Cluster Recipe : {runInfo.ClusterRecipe}");
                                LogPresenter.SetLogString($"Frontside Recipe : {runInfo.FrontsideRecipe}");
                                LogPresenter.SetLogString($"Inspection Dies : {runInfo.InspectionDies}");
                                LogPresenter.SetLogString($"Inspection Columns : {runInfo.InspectionColumns}");
                                LogPresenter.SetLogString($"Inspection Rows : {runInfo.InspectionRows}");
                                try
                                {
                                    byte FLAG = new EntityCompare(paraCheckRepository.GetParams())
                                    .compare();
                                    log.Info($"Compare Result{FLAG}");
                                    if (FLAG == 0)
                                    {
                                        var t = driver.SendAsync(paraCheckRepository.S6F11Succ());
                                        t.Wait();
                                        runInfo.Result = "PASS";
                                        if (t.IsCompleted)
                                        {
                                            LogPresenter.SetLogString("SecsGem message send S6 F11 - Valid Recipe");
                                            LogPresenter.SetLogString("SecsGem message received S6 F12");
                                        }
                                    }
                                    else
                                    {
                                        var t = driver.SendAsync(paraCheckRepository.S6F11Fail());
                                        t.Wait();
                                        runInfo.Result = "NG";
                                        if (t.IsCompleted)
                                        {
                                            LogPresenter.SetLogString("SecsGem message send S6 F11 - Invalid Recipe");
                                            LogPresenter.SetLogString("SecsGem message received S6 F12");
                                        }
                                    }
                                }
                                catch
                                {
                                    var t = driver.SendAsync(paraCheckRepository.S6F11Fail());
                                    t.Wait();
                                    runInfo.Result = "NG";
                                    if (t.IsCompleted)
                                    {
                                        LogPresenter.SetLogString("SecsGem message send S6 F11 - Compare error");
                                        LogPresenter.SetLogString("SecsGem message received S6 F12");
                                    }
                                }
                                finally
                                {
                                    RecipeParamCheckEvent?.Invoke(this, runInfo);
                                }
                                
                            }
                            else if (RCMD == "RECIPE_PARA_UPLOAD")
                            {
                                ParaUploadRepository paraUploadRepository = new ParaUploadRepository(pMsg);
                                pMsg.ReplyAsync(paraUploadRepository.S2F42());
                                try
                                {
                                    RecipeParamUploadEvent?.Invoke(this, paraUploadRepository.GetParamsForUpload());
                                }catch(Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                            }
                            break;
                    }
                    break;

                case 6:
                    switch (F)
                    {
                        case 12:
                            log.Info("SecsGem message received S6 F12");
                            LogPresenter.SetLogString("SecsGem message received S6 F12");
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
