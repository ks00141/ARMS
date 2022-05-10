using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using log4net;
using Secs4Net;
using ARMS.Repository;

namespace ARMS.Service
{
    class SecsGemService
    {
        readonly SecsGem driver;

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

                            if(RCMD == "RECIPE_PARA_CHECK")
                            {
                                pMsg.ReplyAsync(new ParaCheckRepository().S2F42());
                                Item items = pMsg.Message.SecsItem.Items[1].Items[0].Items[3];
                                string clusterReicpe = pMsg.Message.SecsItem.Items[1].Items[0].Items[0].GetValue<string>().Replace('\\','/');
                                new SecsGemParamRepository().GetRecipeParam(clusterReicpe, items);
                                new SpecParamRepository().GetRecipeParam(clusterReicpe);


                            }
                            else if (RCMD == "RECIPE_PARA_UPLOAD")
                            {
                                pMsg.ReplyAsync(new ParaCheckRepository().S2F42());
                                Item items = pMsg.Message.SecsItem.Items[1].Items[0].Items[3];
                                string clusterReicpe = pMsg.Message.SecsItem.Items[1].Items[0].Items[0].GetValue<string>().Replace('\\', '/');
                                new SecsGemParamRepository().GetRecipeParam(clusterReicpe, items);
                            }
                            break;
                    }
                    break;
            }
        }
    }
}
