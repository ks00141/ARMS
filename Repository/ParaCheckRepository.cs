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

        public SecsMessage S6F11Succ(PrimaryMessageWrapper pMsg)
        {
            S6F11 s6f11 = new S6F11
            {
                DATAID = 0,
                CEID = 1000,
                RPTID = 1,
                PORTID = pMsg.Message.SecsItem.Items[1].Items[0].Items[0].GetValue<string>(),
                LOTID = pMsg.Message.SecsItem.Items[1].Items[0].Items[1].GetValue<string>(),
                CLUSTERRECIPE = pMsg.Message.SecsItem.Items[1].Items[0].Items[2].GetValue<string>()
            };

            return s6f11.Message;
        }

        public SecsMessage S6F11Fail(PrimaryMessageWrapper pMsg)
        {
            S6F11 s6f11 = new S6F11
            {
                DATAID = 0,
                CEID = 2000,
                RPTID = 1,
                PORTID = pMsg.Message.SecsItem.Items[1].Items[0].Items[0].GetValue<string>(),
                LOTID = pMsg.Message.SecsItem.Items[1].Items[0].Items[1].GetValue<string>(),
                CLUSTERRECIPE = pMsg.Message.SecsItem.Items[1].Items[0].Items[2].GetValue<string>()
            };
            Console.WriteLine(s6f11.Message);
            return s6f11.Message;
        }
    }
}
