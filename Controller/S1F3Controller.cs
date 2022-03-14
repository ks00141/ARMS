using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Secs4Net;

namespace ARMS.Controller
{
    class S1F3Controller
    {
        public void req(PrimaryMessageWrapper pMsg)
        {
            pMsg.ReplyAsync(
                new SecsMessage(
                    1,
                    4,
                    "S1F4",
                    Item.L(
                        Item.A(
                            "ARMS"
                        )
                    )
                )
            );
        }
    }
}
