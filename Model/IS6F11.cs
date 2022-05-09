using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARMS.Model
{
    interface IS6F11:ISecsMessage
    {
        uint DATAID { get; set; }
        uint CEID { get; set; }
        uint RPTID { get; set; }

    }
}
