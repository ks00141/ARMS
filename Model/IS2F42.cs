using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARMS.Model
{
    interface IS2F42:ISecsMessage
    {
        uint HCACK { get; set; }
    }
}
