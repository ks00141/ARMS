using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARMS.Model
{
    interface IS1F14:ISecsMessage
    {
        byte COMACK { get; set; }
        string MDLN { get; set; }
        string SOFTREV { get; set; }
    }
}
