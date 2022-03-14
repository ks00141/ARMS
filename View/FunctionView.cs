using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARMS.Controller;
using Secs4Net;
using System.Net;

namespace ARMS.View
{
    class FunctionView
    {
        SecsGem driver;
        dynamic form;

        public FunctionView(dynamic form)
        {
            this.form = form;
            driver = new SecsGem(false, IPAddress.Any, 5717);
            driver.PrimaryMessageReceived += msgReceived;
        }

        public void start()
        {
            driver.Start();
        }

        public void msgReceived(object sender, PrimaryMessageWrapper pMsg)
        {
            int F = pMsg.Message.F;
            int S = pMsg.Message.S;

            switch (S)
            {

                case 1:

                    switch (F)
                    {
                        case 3:
                            new Controller.S1F3Controller().req(pMsg);
                            break;

                        case 13:
                            new Controller.S1F13Controller().req(pMsg);
                            break;
                    }
                    break;

                case 2:

                    switch (F)
                    {
                        case 41:
                            new Controller.S2F41Controller().req(pMsg, driver);
                            break;
                    }
                    break;
            }
        }

    }
    
}