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
        Entity[] recipeParams;
        private static readonly ILog log = LogManager.GetLogger("ARMS/S2F41 Controller");

        public S2F41Controller()
        {
            recipeParams = new Entity[2];
            log.Info("Recipe Parameter Array allocate Succ");
        }
        public void req(PrimaryMessageWrapper pMsg, SecsGem driver)
        {
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
            log.Info("SECS/GEM Message reply, S2 F42");

            recipeParams[0] = new JobDAO().parseMsg(pMsg);
            log.Info("SECS/GEM Message parse SUCC");
            recipeParams[1] = new SpecDAO().selectQuery(recipeParams[0].GetClusterRecipe());

            byte FLAG = new EntityCompare(recipeParams[0], recipeParams[1]).compare();
            //byte FLAG = 0;

            if (FLAG == 0)
            {
                try
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
                                                Item.A("PORTID"),
                                                Item.A("LOTID")
                                            ),
                                            Item.L(
                                                Item.A("RECIPEID"),
                                                Item.A(recipeParams[0].GetClusterRecipe())
                                            )
                                        )
                                    )
                                )
                            )
                        )
                    );
                    log.Info("S6 F11 Message Send SUCC - PASS");
                }
                catch(Exception e)
                {
                    log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", e);
                }
            }
            else
            {
                try
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
                                                Item.A("RECIPEID"),
                                                Item.A(recipeParams[0].GetClusterRecipe())
                                            )
                                        )
                                    )
                                )
                            )
                        )
                    );

                    log.Info("S6 F11 Message Send SUCC - NG");
                }
                catch(Exception e)
                {
                    log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", e);
                }
            }
        }
    }
}
