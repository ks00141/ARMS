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
    public partial class Form1 : Form
    {
        FunctionView functionView;
        private static readonly ILog log = LogManager.GetLogger("ARMS/GUI");
        
        private void Form1_Load(object sender,EventArgs e)
        {
            CHB_AP.Checked = false;
        }
        public Form1()
        {
            
            log.Info("");
            log.Info("ARMS Start");
            log.Info("Version - 0.1.0");
            log.Info("");
            log.Info("GUI INIT");
            InitializeComponent();
            
            try
            {
                functionView = new FunctionView(this);
                functionView.SetToolValue += FunctionView_SetToolValue;
                functionView.SetSpecValue += FunctionView_SetSpecValue;
                STATUS_LB.Text = "SECS/GEM Driver init";
                functionView.start();

            }
            catch(Exception e)
            {
                log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", e);
            }


        }

        private void FunctionView_SetSpecValue(object sender, Model.RecipeParam e)
        {
            this.TB_CLUSTERRECIPE.Text = e.getClusterRecipe();
            this.TB_FRONTSIDERECIPE.Text = e.getFrontsideRecipe();
            this.TB_INSPECTIONDIES.Text = e.getInspectionDies();
            this.TB_INSPECTIONCOLUMNS.Text = e.getInspectionColumns();
            this.TB_INSPECTIONROWS.Text = e.getInspectionRows();
        }        

        private void FunctionView_SetToolValue(object sender, Model.RecipeParam e)
        {
            this.TB_CLUSTERRECIPE_SG.Text = e.getClusterRecipe();
            this.TB_FRONTSIDERECIPE_SG.Text = e.getFrontsideRecipe();
            this.TB_INSPECTIONDIES_SG.Text = e.getInspectionDies();
            this.TB_INSPECTIONCOLUMNS_SG.Text = e.getInspectionColumns();
            this.TB_INSPECTIONROWS_SG.Text = e.getInspectionRows();
        }

        public bool checkboxStat()
        {
            return CHB_AP.Checked;
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

        private void BTN_PPIDSERACH_Click(object sender, EventArgs e)
        {
            Controller.PpidSearchController psc = new Controller.PpidSearchController();
            psc.GetPpid += delegate (object s, DataTable dt)
            {
                CB_PPID.DataSource = null;
                CB_PPID.DataSource = dt;
                CB_PPID.DisplayMember = "ppid";
            };
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (CB_PPID.Text != "")
            {
                try
                {
                    functionView.specSearch(CB_PPID.Text);
                }
                catch
                {
                    MessageBox.Show("Spec Recipe Search Fail");
                }

                try
                {
                    functionView.reqRecipe(CB_PPID.Text);
                }
                catch
                {
                    MessageBox.Show("Tool Recipe Search Fail");
                }

                compare(TB_CLUSTERRECIPE, TB_CLUSTERRECIPE_SG);
                compare(TB_FRONTSIDERECIPE, TB_FRONTSIDERECIPE_SG);
                compare(TB_INSPECTIONCOLUMNS, TB_INSPECTIONCOLUMNS_SG);
                compare(TB_INSPECTIONDIES, TB_INSPECTIONDIES_SG);
                compare(TB_INSPECTIONROWS, TB_INSPECTIONROWS_SG);
            }
        }
    }
}
