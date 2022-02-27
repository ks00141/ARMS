using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Secs4Net;

namespace ARMS
{
    class SecsMsgController
    {
        SecsGem driver;
        Form1 form;
        int S;
        int F;
        
        public SecsMsgController(SecsGem driver, Form1 form)
        {
            this.driver = driver;
            this.form = form;
        }

        public SecsMessage msgReceive(PrimaryMessageWrapper pMsg)
        {
            SecsMessage reply = null;

            S = pMsg.Message.S;
            F = pMsg.Message.F;

            switch (S)
            {
                case 1:

                    switch (F)
                    {
                        case 3:
                            pMsg.ReplyAsync(new S1F4().reply());
                            break;

                        case 13:
                            pMsg.ReplyAsync(new S1F14().reply());
                            break;
                    }

                    break;

                case 2:

                    switch (F)
                    {
                        case 41:
                            String clusterRecipe = pMsg.Message.SecsItem.Items[1].Items[0].Items[0].GetValue<String>();
                            Item items = pMsg.Message.SecsItem.Items[1].Items[0].Items[3];
                            foreach(Item item in items.Items)
                            {
                                if (item.Items[0].GetValue<String>() == "Frontside/RecipeName")
                                {
                                    form.setFrontsideRecipeText(item.Items[1].Items[0].GetValue<String>());
                                }
                                if (item.Items[0].GetValue<String>() == "Frontside/RowNumber")
                                {
                                    form.setRowDiesText(item.Items[1].Items[0].GetValue<String>());
                                }
                                if (item.Items[0].GetValue<String>() == "Frontside/ColumnNumber")
                                {
                                    form.setColumnDiesText(item.Items[1].Items[0].GetValue<String>());
                                }
                                if (item.Items[0].GetValue<String>() == "Frontside/TestableDies")
                                {
                                    form.setInspectionDiesText(item.Items[1].Items[0].GetValue<String>());
                                }
                            }
                            pMsg.ReplyAsync(new S2F42().reply());
                            driver.SendAsync(new S6F11().sendSuc());
                            form.setClusterRecipeText(clusterRecipe);
                            break;
                    }

                    break;
            }

            return reply;
        }

    }
}