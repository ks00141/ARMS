using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroSet_UI.Forms;
using ARMS.View;
using log4net;
using System.Reflection;

namespace ARMS
{
    public partial class Form1 : MetroSetForm
    {
        bool flag;
        FunctionView functionView;
        private static readonly ILog log = LogManager.GetLogger("ARMS/GUI");
        public Form1()
        {
            log.Info("");
            log.Info("ARMS Start");
            log.Info("Version - 0.1.0");
            log.Info("");
            log.Info("GUI INIT");
            InitializeComponent();
            StatusColor(false);
            try
            {
                functionView = new FunctionView(this);
                STATUS_RB.BackgroundColor = Color.Yellow;
            }catch(Exception e)
            {
                log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", e);
            }



        }

        public void StatusColor(bool flag)
        {
            if (flag)
            {
                STATUS_RB.BackgroundColor = Color.Green;
            }
            else
            {
                STATUS_RB.BackgroundColor = Color.Red;
            }
        }

        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                STATUS_LB.Text = "SECS/GEM Driver init";
                StatusColor(true);
                functionView.start();
                flag = true;
            }
            else
            {
                STATUS_LB.Text = "Already Running SECS/GEM Driver";
            }

        }
    }
}
