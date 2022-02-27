using Secs4Net;

namespace ARMS
{
    class S6F11:S6F11InterFace
    {
        public S6F11()
        {

        }

        public SecsMessage sendFail()
        {
            throw new System.NotImplementedException();
        }

        public SecsMessage sendSuc()
        {
            return (
                new SecsMessage(
                    6,
                    11,
                    "S6F11",
                    Item.L(
                        Item.U4(1),
                        Item.U4(1000),
                        Item.L(
                            Item.L(
                                Item.U4(1),
                                Item.L(
                                    Item.L(
                                        Item.A("RECIPEID"),
                                        Item.A("test")
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