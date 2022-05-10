using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARMS.Model
{
    interface IS2F42:ISecsGemMessage
    {
        uint HCACK { get; set; }
    }
}
