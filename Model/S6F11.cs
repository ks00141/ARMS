using Secs4Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARMS.Model
{
    class S6F11 : IS6F11
    {
        public uint DATAID { get; set; }
        public uint CEID { get; set; }
        public uint RPTID { get; set; }
        public string PORTID { get; set; }
        public string LOTID { get; set; }
        public string CLUSTERRECIPE { get; set; }


        public SecsMessage Message =>
            new SecsMessage(
                6,
                11,
                "S6F11",
                Item.L(
                    Item.U4(DATAID),
                    Item.U4(CEID),
                    Item.L(
                        Item.L(
                            Item.U4(RPTID),
                            Item.L(
                                Item.L(
                                    Item.A(PORTID),
                                    Item.A(LOTID)
                                ),
                                Item.L(
                                    Item.A("RECIPEID"),
                                    Item.A(CLUSTERRECIPE)
                                    )
                                )
                            )
                        )
                    )
                );
    }
}
