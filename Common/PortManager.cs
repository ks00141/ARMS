using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ARMS.View;
using System.Threading.Tasks;

namespace ARMS
{
    static class PortManager
    {
        static IPortManager portManagerView;
        public static void SetPortViewForm(IPortManager view)
        {
            portManagerView = view;
        }

        public static string Port
        {
            get
            {
                return portManagerView.PORT;
            }
        }
    }
}
