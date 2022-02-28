using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Secs4Net;

namespace ARMS
{
    interface serviceInterface
    {
        void start();
        void msgReceived(object sender, PrimaryMessageWrapper pMsg);
    }
}
