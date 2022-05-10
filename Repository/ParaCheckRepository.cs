using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARMS.Model;
using Secs4Net;

namespace ARMS.Repository
{
    class ParaCheckRepository
    {
        public SecsMessage S2F42()
        {
            S2F42 s2f42 = new S2F42
            {
                HCACK = 0
            };

            return s2f42.Message;
        }
    }
}
