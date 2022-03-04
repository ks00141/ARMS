using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Secs4Net;

namespace ARMS
{
    interface MsgCtrInterface
    {
        SecsMessage msgReceive(PrimaryMessageWrapper pMsg);
    }
}
