using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Secs4Net;

namespace ARMS
{
    class MsgCtrFactory:MsgCtrFactoryInterface
    {

        public MsgCtrInterface getController(SecsGem driver, dynamic form)
        {
            return new SecsMsgController(driver, form);
        }
    }
}
