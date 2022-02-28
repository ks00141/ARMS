using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Secs4Net;

namespace ARMS
{
    class SecsService:serviceInterface
    {
        SecsGem driver; //driver factory
        SecsMsgController msgAdmin; // msgController factory

        public SecsService(dynamic form)
        {
            driver = new SecsGem(false, IPAddress.Any, 5717); // driver factory.getDriver
            msgAdmin = new SecsMsgController(driver, form); // msgController facotry.getController
            driver.PrimaryMessageReceived += msgReceived;   // driver.PrimaryMessageReceived += msgContoller factory.getReceive
        }

        public void start()
        {
            driver.Start();
        }

        public void msgReceived(object sender, PrimaryMessageWrapper pMsg)
        {
            msgAdmin.msgReceive(pMsg);
        }
    }
}
