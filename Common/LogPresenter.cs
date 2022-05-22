using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ARMS.View;

namespace ARMS
{
    public static class LogPresenter
    {
        static IFormLogView view;

        public static void SetViewForm(IFormLogView form)
        {
            view = form;
        }

        public static void SetLogString(string log)
        {
            view.LogStream = new string[] { $"{DateTime.Now.ToString("MM-dd HH:mm:ss")} - {log}" };
        }


    }
}
