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
using ARMS.Presenter;

namespace ARMS
{
    public partial class Form1 : Form,IPpidListView,IRecipeParamUPloadView
    {
        UserControl1 uc1 = new UserControl1();
        SecsGemPresenter secsGemPresenter;
        private static readonly ILog log = LogManager.GetLogger("ARMS/GUI");

        public string[] Ppid { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ClusterRecipe { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FrontsideRecipe { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string InspectionDies { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string InspectionColumns { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string InspectionRows { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Form1()
        {
            InitializeComponent();
            this.secsGemPresenter = new SecsGemPresenter(this);
            log.Info("");
            log.Info("ARMS Start");
            log.Info("Version - 0.1.0");
            log.Info("");
            log.Info("GUI INIT");
            try
            {
                secsGemPresenter.SecsGemStart();
            }
            catch(Exception e)
            {
                log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", e);
            }


        }

        public void compare(TextBox a, TextBox b)
        {
            if(a.Text != b.Text)
            {
                a.ForeColor = Color.Red;
                b.ForeColor = Color.Red;
            }
            else
            {
                a.ForeColor = Color.White;
                b.ForeColor = Color.White;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Controls.Add(uc1);
        }
    }
}
