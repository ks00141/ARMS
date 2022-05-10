using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARMS.Model;
using Secs4Net;

//ECR = Establish Communication Request

namespace ARMS.Repository
{
    class ECRRepository
    {
        
        public SecsMessage S1F14()
        {
            return this.S1F14(0);
        }

        public SecsMessage S1F14(byte comack)
        {
            S1F14 s1f14 = new S1F14
            {
                COMACK = comack,
                MDLN = "ARMS",
                SOFTREV = "0.1.0"
            };

            return s1f14.Message;
        }
    }
}
