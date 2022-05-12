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
                /*var list = new List<string>();
                list.AddRange(new string[] { "" });
                list.AddRange(value);
                string[] arr = list.ToArray();
                lv_ppidList.Items.Add(new ListViewItem(arr));
                lv_ppidList.CheckBoxes = true;*/
                lv_ppidList.Items.Add(new ListViewItem(value));
            }
        }

        public string ClusterRecipe { get => throw new NotImplementedException(); set => Console.WriteLine(value); }
        public string FrontsideRecipe { get => throw new NotImplementedException(); set => Console.WriteLine(value); }
        public string InspectionDies { get => throw new NotImplementedException(); set => Console.WriteLine(value); }
        public string InspectionColumns { get => throw new NotImplementedException(); set => Console.WriteLine(value); }
        public string InspectionRows { get => throw new NotImplementedException(); set => Console.WriteLine(value); }

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
    }
}
