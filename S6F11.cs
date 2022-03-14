using Secs4Net;
using System;

namespace ARMS
{
    class S6F11:S6F11InterFace
    {
        public SecsMessage sendFail(String recipe)
        {
            return (
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
                                        Item.A(recipe)
                                    )
                                )
                            )
                        )
                    )
                )
            );
        }

        public SecsMessage sendSuc(String recipe)
        {
            return (
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
                                        Item.A(recipe)
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