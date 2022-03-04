using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Secs4Net;

namespace ARMS
{
    class ReceiverFactory
    {
        public S2F41Receiver getS2F41Receiver(PrimaryMessageWrapper pMsg)
        {
            return new S2F41Receiver(pMsg);
        }

    }
}
