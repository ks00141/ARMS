using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Secs4Net;
using ARMS.DAO;
using ARMS.Model;

namespace ARMS.Controller
{
    class S2F41Controller
    {
        Entity[] recipeParams;

        public S2F41Controller()
        {
            recipeParams = new Entity[2];
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
            recipeParams[0] = new JobDAO().selectQuery(pMsg);
            recipeParams[1] = new SpecDAO().selectQuery(recipeParams[0].GetClusterRecipe());
            byte FLAG = new EntityCompare(recipeParams[0], recipeParams[1]).compare();
            Console.WriteLine(FLAG == 0 ? "PASS" : "NG");
            if (FLAG == 0)
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
                                            Item.A("RECIPEID"),
                                            Item.A(recipeParams[0].GetClusterRecipe())
                                        )
                                    )
                                )
                            )
                        )
                    )
                );
            }
            else
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
            }
        }
    }
}
