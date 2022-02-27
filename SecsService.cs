using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Secs4Net;

namespace ARMS
{
    class SecsService
    {
        SecsGem driver;
        SecsMsgController msgAdmin;

        public SecsService(Form1 form)
        {
            driver = new SecsGem(false, IPAddress.Any, 5717);
            driver.PrimaryMessageReceived += msgReceived;
            msgAdmin = new SecsMsgController(driver, form);
        }

        public void start()
        {
            driver.Start();
        }

        void msgReceived(object sender, PrimaryMessageWrapper pMsg)
        {
            msgAdmin.msgReceive(pMsg);
        }
    }
}
