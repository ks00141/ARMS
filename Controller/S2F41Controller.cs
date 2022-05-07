using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Secs4Net;
using ARMS.DAO;
using ARMS.Model;
using log4net;
using System.Reflection;


namespace ARMS.Controller
{
    class S2F41Controller
    {
        RecipeParam[] recipeParams;
        SecsGem driver;
        String clusterRecipe;
        String portId;
        String lotId;
        private static readonly ILog log = LogManager.GetLogger("ARMS/S2F41 Controller");
        
        public S2F41Controller(SecsGem driver)
        {
            this.driver = driver;
            recipeParams = new RecipeParam[2];
            log.Info("Recipe Parameter Array allocate Succ");
        }
        public void req(PrimaryMessageWrapper pMsg, bool flag)
        {
            try
            {
                replyS2F42(pMsg);
                log.Info("SECS/GEM Message reply, S2 F42");
            }
            catch(Exception e)
            {
                pMsg.ReplyAsync(
                   new SecsMessage(
                       2,
                       42,
                       "S2F42",
                       Item.L(
                           Item.U4(3)
                       )
                   )
               );
                log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", e);
            }
            if (!flag) {
                
                log.Info("Compare mode");

                try
                {
                    recipeParams[0] = new JobDAO().parseMsg(pMsg);
                    log.Info("SECS/GEM Message parse SUCC");

                    recipeParams[1] = new SpecDAO().selectQuery(recipeParams[0].ClusterRecipe);

                    byte FLAG = new EntityCompare(recipeParams[0], recipeParams[1]).compare();

                    if (FLAG == 0)
                    {
                        sendPass();
                        log.Info("S6 F11 Message Send SUCC - PASS");
                    }
                    else
                    {
                        sendNg();
                        log.Info("S6 F11 Message Send SUCC - NG");
                    }
                }
                catch(Exception e)
                {
                    sendNg();
                    log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", e);
                }
            }
            else
            {
                log.Info("All pass mode");
                sendPass();
            }
        }
        public void sendPass()
        {
            driver.SendAsync(
                        new SecsMessage(
                            6,
                            11,
                            "S6F11",
                            Item.L(
                                Item.U4(0),
                                Item.U4(1000),
                                Item.L(
                                    Item.L(
                                        Item.U4(1),
                                        Item.L(
                                            Item.L(
                                                Item.A(portId),
                                                Item.A(lotId)
                                            ),
                                            Item.L(
                                                Item.A("RECIPEID"),
                                                Item.A(clusterRecipe)
                                            )
                                        )
                                    )
                                )
                            )
                        )
                    );
            
        }
        public void sendNg()
        {
            driver.SendAsync(
                        new SecsMessage(
                            6,
                            11,
                            "S6F11",
                            Item.L(
                                Item.U4(0),
                                Item.U4(2000),
                                Item.L(
                                    Item.L(
                                        Item.U4(1),
                                        Item.L(
                                            Item.L(
                                                Item.A(portId),
                                                Item.A(lotId)
                                            ),
                                            Item.L(
                                                Item.A("RECIPEID"),
                                                Item.A(clusterRecipe)
                                            )
                                        )
                                    )
                                )
                            )
                        )
                    );
        }
        public void replyS2F42(PrimaryMessageWrapper pMsg)
        {
            this.portId = pMsg.Message.SecsItem.Items[1].Items[0].Items[0].GetValue<String>();
            log.Info($"SECS/GEM Message Run Port : {portId}");
            this.lotId = pMsg.Message.SecsItem.Items[1].Items[0].Items[1].GetValue<String>();
            log.Info($"SECS/GEM Message Run Lot Id : {lotId}");
            this.clusterRecipe = pMsg.Message.SecsItem.Items[1].Items[0].Items[2].GetValue<String>();
            log.Info($"SECS/GEM Message reply Run PPID : {this.clusterRecipe}");
            this.clusterRecipe = this.clusterRecipe.Replace('\\', '/');
            pMsg.ReplyAsync(
                new SecsMessage(
                    2,
                    42,
                    "S2F42",
                    Item.L(
                        Item.U4(0)
                    )
                )
            );
        }
    }
}
