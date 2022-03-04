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
        MsgCtrFactory msgCtrFactory;
        dynamic form;

        public SecsService(dynamic form)
        {
            this.form = form;
            driver = new SecsGem(false, IPAddress.Any, 5717);
            msgCtrFactory = new MsgCtrFactory();
            driver.PrimaryMessageReceived += msgReceived;
        }

        public void start()
        {
            driver.Start();
        }

        public void msgReceived(object sender, PrimaryMessageWrapper pMsg)
        {
            msgCtrFactory.getController(driver, form).msgReceive(pMsg);
        }
    }
}
