using ARMS.Presenter;
using ARMS.View;
using log4net;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace ARMS
{
    public partial class Form1 : Form, IPpidListView, IRecipeParamUPloadView
    {
        SecsGemPresenter secsGemPresenter;
        private static readonly ILog log = LogManager.GetLogger("ARMS/GUI");

        public string[] Ppid
        {
            get
            {
                return new string[] { lv_ppidList.SelectedItems[0].SubItems[1].Text.Replace('/', '\\') };
            }
            set
            {
                lv_ppidList.Items.Add(new ListViewItem(value));
            }
        }

        public string[] RunRecipeParams
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                ListViewItem lvi = new ListViewItem(value);
                listView1.Items.Add(lvi);
            }

        }

        public string SpecClusterRecipe { set => tb_specClusterRecipe.Text = value; }
        public string SpecFrontsideRecipe { set => tb_specFrontsideRecipe.Text = value; }
        public string SpecInspectionDies { set => throw new NotImplementedException(); }
        public string SpecInspectionColumns { set => throw new NotImplementedException(); }
        public string SpecInspectionRows { set => throw new NotImplementedException(); }
        public string ToolClusterRecipe { set => throw new NotImplementedException(); }
        public string ToolFrontsideRecipe { set => throw new NotImplementedException(); }
        public string ToolInspectionDies { set => throw new NotImplementedException(); }
        public string ToolInspectionColumns { set => throw new NotImplementedException(); }
        public string ToolInspectionRows { set => throw new NotImplementedException(); }

        public Form1()
        {
            InitializeComponent();
            this.secsGemPresenter = new SecsGemPresenter(this);
            secsGemPresenter.SecsGemParamUpload += SecsGemParamPrint;
            secsGemPresenter.SpecParamUpload += SpecParamPrint;
            log.Info("");
            log.Info("ARMS Start");
            log.Info("Version - 0.1.0");
            log.Info("");
            log.Info("GUI INIT");
            try
            {
                secsGemPresenter.SecsGemStart();
            }
            catch (Exception e)
            {
                log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lv_ppidList.Items.Clear();
            new PpidPresenter(this).PrintAllPpid();
        }

        private void lv_ppidList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            secsGemPresenter.ParamUploadRequest(Ppid[0]);
        }

        private void SecsGemParamPrint(object sender, string[] param)
        {
            tb_specClusterRecipe.Text = param[0];
            tb_specFrontsideRecipe.Text = param[1];
            tb_specInspectionDies.Text = param[2];
            tb_specInspectionColumns.Text = param[3];
            tb_specInspectionRows.Text = param[4];
        }

        private void SpecParamPrint(object sender, string[] param)
        {
            tb_toolClusterRecipe.Text = param[0];
            tb_toolFrontsideRecipe.Text = param[1];
            tb_toolInspectionDies.Text = param[2];
            tb_toolInspectionColumns.Text = param[3];
            tb_toolInspectionRows.Text = param[4];
        }

        private void btn_paramUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                secsGemPresenter.ParamUpload(this.Ppid[0]);
            }catch(Exception ex)
            {
                log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", ex);
                MessageBox.Show("SecsGem Error!!");
            }
        }

        private void btn_dbUpload_Click(object sender, EventArgs e)
        {
            string[] param = new string[]
            {
                tb_specClusterRecipe.Text,
                tb_specFrontsideRecipe.Text,
                tb_specInspectionDies.Text,
                tb_specInspectionColumns.Text,
                tb_specInspectionRows.Text
            };
            secsGemPresenter.DbParamUpload(param);
        }
    }
}
