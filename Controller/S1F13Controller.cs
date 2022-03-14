using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Secs4Net;

namespace ARMS.Controller
{
    class S1F13Controller
    {
        public void req(PrimaryMessageWrapper pMsg)
        {
            pMsg.ReplyAsync(
                new SecsMessage(
                    1,
                    14,
                    "S1F14",
                    Item.L(
                        Item.A("ARMS"),
                        Item.A("V 0.1.0")
                    )
                )
            );
        }
    }
}
