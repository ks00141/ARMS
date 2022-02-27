using Secs4Net;

namespace ARMS
{
    internal class S2F42 : S2F42Interface

    {
        public S2F42()
        {
        }

        public SecsMessage reply()
        {
            return (
                new SecsMessage(
                    2,
                    42,
                    "S2F42",
                    Item.L(
                        Item.U4(0)
                    )
                )
            );
        }
    }
}