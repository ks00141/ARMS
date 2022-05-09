using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Secs4Net;

namespace ARMS.Repository
{
    class SecsGemMessageRepository
    {
        public SecsMessage S1F14
        {
            get
            {
                return new SecsMessage(
                    1,
                    14,
                    "S1F14",
                    Item.L(
                        Item.B(0),
                        Item.L(
                            Item.A("ARMS"),
                            Item.A("0.1.0")
                        )
                    )
                );
            }
        }

        public SecsMessage S2F42
        {
            get
            {
                return new SecsMessage(
                    2,
                    42,
                    "S2F42",
                    Item.L(
                        Item.U4(0)
                    )
                );
            }
        }
    }
}
