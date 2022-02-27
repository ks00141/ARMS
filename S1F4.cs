using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Secs4Net;

namespace ARMS
{
    class S1F4 : S1F4Interface
    {
        public SecsMessage reply()
        {
            return (
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