using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARMS.Controller;
using Secs4Net;
using System.Net;
using log4net;
using System.Reflection;

namespace ARMS.View
{
    class FunctionView
    {
        SecsGem driver;
        dynamic form;
        private static readonly ILog log = LogManager.GetLogger("ARMS/Finction View");

        public FunctionView(dynamic form)
        {
            this.form = form;
            try
            {
                driver = new SecsGem(false, IPAddress.Any, 5000);
                log.Info("SECS/GEM Driver is initialized");
                form.StatusColor(true);
            }
            catch(Exception e)
            {
                log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", e);
            }
            driver.PrimaryMessageReceived += msgReceived;
            
        }

        public void start()
        {
            try
            {
                driver.Start();
                log.Info("SECS/GEM Driver Start");
            }catch(Exception e)
            {
                log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", e);
            }
            
        }

        public void msgReceived(object sender, PrimaryMessageWrapper pMsg)
        {
            int F = pMsg.Message.F;
            int S = pMsg.Message.S;
            log.Info($"SECS/GEM Message received, S{S} F{F}");
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
                            new Controller.S2F41Controller(driver).req(pMsg);
                            break;
                    }
                    break;
            }
        }

    }
    
}