using Secs4Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARMS
{
    class S1F14 : S1F14Interface
    {
        public SecsMessage reply()
        {
            return (
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
