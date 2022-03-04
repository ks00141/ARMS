using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Secs4Net;

namespace ARMS
{
    interface S2F41ReceiverInterface
    {
        bool checkRCMD();
        String getRCMD();
        void replyS2F42(bool flag);
        List<String> getParams();
    }
}
