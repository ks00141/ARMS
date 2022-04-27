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
                STATUS_LB.Text = "SECS/GEM Driver init";
                functionView.start();

            }
            catch(Exception e)
            {
                log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", e);
            }


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
            CB_PPID.DataSource = null;
            CB_PPID.DataSource = new Controller.PpidSearchController().getPPID(TB_DEVICE.Text);
            CB_PPID.DisplayMember = "ppid";
        }

        public void setToolClusterRecipe(String cluster_recipe)
        {
            TB_CLUSTERRECIPE_SG.Text = cluster_recipe;
        }
        public void setToolFrontsideRecipe(String frontside_recipe)
        {
            TB_FRONTSIDERECIPE_SG.Text = frontside_recipe;
        }

        public void setToolInspectionDies(String inspection_dies)
        {
            TB_INSPECTIONDIES_SG.Text = inspection_dies;
        }

        public void setToolInspectionColumns(String inspection_columns)
        {
            TB_INSPECTIONCOLUMNS_SG.Text = inspection_columns;
        }

        public void setToolInspectionRows(String inspection_rows)
        {
            TB_INSPECTIONROWS_SG.Text = inspection_rows;
        }
        public void setSpecClusterRecipe(String cluster_recipe)
        {
            TB_CLUSTERRECIPE.Text = cluster_recipe;
        }

        public void setSpecFrontsideRecipe(String frontside_recipe)
        {
            TB_FRONTSIDERECIPE.Text = frontside_recipe;
        }

        public void setSpecInspectionDies(String inspection_dies)
        {
            TB_INSPECTIONDIES.Text = inspection_dies;
        }
        public void setSpecInspectionColumns(String inspection_columns)
        {
            TB_INSPECTIONCOLUMNS.Text = inspection_columns;
        }

        public void setSpecInspectionRows(String inspection_rows)
        {
            TB_INSPECTIONROWS.Text = inspection_rows;
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
