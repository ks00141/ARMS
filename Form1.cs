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
        FunctionView functionView;
        SecsGemPresenter secsGemPresenter;
        private static readonly ILog log = LogManager.GetLogger("ARMS/GUI");

        public string[] Ppid
        {
            get
            {
                ListViewItem selectedItem = lv_PpidList.SelectedItems[0];
                return new string[]
                { 
                    selectedItem.SubItems[0].Text,
                    selectedItem.SubItems[1].Text
                };
            }
            set
            {
                lv_PpidList.Items.Add(new ListViewItem(value));
            }
        }

        public string ClusterRecipe { get => TB_CLUSTERRECIPE_SG.Text; set=> TB_CLUSTERRECIPE_SG.Text = value; }
        public string FrontsideRecipe { get => TB_FRONTSIDERECIPE_SG.Text; set => TB_FRONTSIDERECIPE_SG.Text = value; }
        public string InspectionDies { get => TB_INSPECTIONDIES.Text; set => TB_INSPECTIONDIES_SG.Text = value; }
        public string InspectionColumns { get => TB_INSPECTIONCOLUMNS_SG.Text; set => TB_INSPECTIONCOLUMNS_SG.Text = value; }
        public string InspectionRows { get => TB_INSPECTIONROWS_SG.Text; set => TB_INSPECTIONROWS_SG.Text = value; }

        private void Form1_Load(object sender,EventArgs e)
        {
            CHB_AP.Checked = false;
            
        }
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
                /*functionView = new FunctionView(this);
                functionView.ReceivedSpecValue += setSpecValue;
                functionView.ReceivedToolValue += setToolValue;
                functionView.ReceivedToolValue += compareValue;
                STATUS_LB.Text = "SECS/GEM Driver init";
                functionView.start();*/

            }
            catch(Exception e)
            {
                log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", e);
            }


        }

        private void compareValue(object sender, Model.RecipeParam e)
        {
            compare(TB_CLUSTERRECIPE, TB_CLUSTERRECIPE_SG);
            compare(TB_FRONTSIDERECIPE, TB_FRONTSIDERECIPE_SG);
            compare(TB_INSPECTIONCOLUMNS, TB_INSPECTIONCOLUMNS_SG);
            compare(TB_INSPECTIONDIES, TB_INSPECTIONDIES_SG);
            compare(TB_INSPECTIONROWS, TB_INSPECTIONROWS_SG);
        }

        private void setSpecValue(object sender, Model.RecipeParam e)
        {
            this.TB_CLUSTERRECIPE.Text = e.ClusterRecipe;
            this.TB_FRONTSIDERECIPE.Text = e.FrontsideRecipe;
            this.TB_INSPECTIONDIES.Text = e.InspectionDies;
            this.TB_INSPECTIONCOLUMNS.Text = e.InspectionColumns;
            this.TB_INSPECTIONROWS.Text = e.InspectionRows;
        }        

        private void setToolValue(object sender, Model.RecipeParam e)
        {
            this.TB_CLUSTERRECIPE_SG.Text = e.ClusterRecipe;
            this.TB_FRONTSIDERECIPE_SG.Text = e.FrontsideRecipe;
            this.TB_INSPECTIONDIES_SG.Text = e.InspectionDies;
            this.TB_INSPECTIONCOLUMNS_SG.Text = e.InspectionColumns;
            this.TB_INSPECTIONROWS_SG.Text = e.InspectionRows;
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

        private void logPrint(object sender, string log)
        {
            lb_logView.Items.Add(log);
        }

        private void btn_ppidAllCheck_Click(object sender, EventArgs e)
        {
            lv_PpidList.Items.Clear();
            new PpidPresenter(this).PrintAllPpid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lv_PpidList.Items.Clear();
            new PpidPresenter(this).PrintPpidByDevice(TB_DEVICE2.Text);
        }

        private void lv_PpidList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(lv_PpidList.SelectedItems.Count == 1)
            {
                ListView.SelectedListViewItemCollection items = lv_PpidList.SelectedItems;
                ListViewItem item = items[0];
                string ppid = item.SubItems[1].Text;
                if(ppid != "")
                {
                    secsGemPresenter.ParamUploadRequest(ppid);
                }
            }
        }
    }
}
