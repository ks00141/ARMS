using ARMS.Presenter;
using ARMS.View;
using log4net;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace ARMS
{
    public partial class Form1 : Form, IPpidListView, IRecipeParamUPloadView, IFormLogView, IPortManager
    {
        SecsGemPresenter secsGemPresenter;
        private static readonly ILog log = LogManager.GetLogger("ARMS/GUI");
        delegate void SetString(string _arg);
        delegate ListViewItem SetListView(string[] _argv);
        delegate ListViewItem SetLog(string[] log);

        public string[] Ppid
        {
            get
            {
                return new string[] { lv_ppidList.SelectedItems[0].SubItems[1].Text.Replace('/', '\\') };
            }
            set
            {
                if (lv_ppidList.InvokeRequired)
                {
                    Invoke(new SetListView((string[] _argv) => lv_ppidList.Items.Add(new ListViewItem(value))), new object[] { value });
                }
                else
                {
                    lv_ppidList.Items.Add(new ListViewItem(value));
                }
                foreach(var str in value)
                {
                    log.Info($"PPID Set Info : {str}");
                }
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
                if (listView1.InvokeRequired)
                {
                    Invoke(new SetListView((string[] _argv) => listView1.Items.Add(new ListViewItem(value))), new object[] { value });
                }
                else
                {
                    ListViewItem lvi = new ListViewItem(value);
                    listView1.Items.Add(lvi);
                }
                foreach(var str in value)
                {
                    log.Info($"Run Recipe Info : {str}");
                }
            }

        }
        public string SpecClusterRecipe
        {
            set
            {
                if (tb_specClusterRecipe.InvokeRequired)
                {
                    var d = new SetString((string _str) => tb_specClusterRecipe.Text = _str);
                    Invoke(d, new object[] { value }) ;
                }
                else
                {
                    tb_specClusterRecipe.Text = value;

                }
                log.Info($"Spec Cluster Reicpe : {value}");
            }
        }
        public string SpecFrontsideRecipe
        {
            set
            {
                if (tb_specFrontsideRecipe.InvokeRequired)
                {
                    Invoke(new SetString((string _str) => tb_specFrontsideRecipe.Text = _str), new object[] { value });
                }
                else
                {
                    tb_specFrontsideRecipe.Text = value;
                }
                log.Info($"Spec Frontside Recipe : {value}");
            }
        }
        public string SpecInspectionDies
        {
            set
            {
                if (tb_specInspectionDies.InvokeRequired)
                {
                    Invoke(new SetString((string _str) => tb_specInspectionDies.Text = _str), new object[] { value });
                }
                else
                {
                    tb_specInspectionDies.Text = value;
                }
                log.Info($"Spec Inspection Dies : {value}");
            }
        }
        public string SpecInspectionColumns
        {
            set
            {
                if (tb_specInspectionColumns.InvokeRequired)
                {
                    Invoke(new SetString((string _str) => tb_specInspectionColumns.Text = _str), new object[] { value });
                }
                else
                {
                    tb_specInspectionColumns.Text = value;
                }
                log.Info($"Spec Inspection Columns : {value}");
            }
        }
        public string SpecInspectionRows
        {
            set
            {                
                if (tb_specInspectionRows.InvokeRequired)
                {
                    Invoke(new SetString((string _str) => tb_specInspectionRows.Text = _str), new object[] { value });
                }
                else
                {
                    tb_specInspectionRows.Text = value;
                }
                log.Info($"Spec Inspection Rows : {value}");
            }
        }
        public string ToolClusterRecipe
        {
            set
            {
                if (tb_toolClusterRecipe.InvokeRequired)
                {
                    Invoke(new SetString((string _str) => tb_toolClusterRecipe.Text = _str), new object[] { value });
                }
                else
                {
                    tb_toolClusterRecipe.Text = value;
                }
                log.Info($"Tool Cluster Recipe : {value}");
            }
        }
        public string ToolFrontsideRecipe
        {
            set
            {
                if (tb_toolFrontsideRecipe.InvokeRequired)
                {
                    Invoke(new SetString((string _str) => tb_toolFrontsideRecipe.Text = _str), new object[] { value });
                }
                else
                {
                    tb_toolFrontsideRecipe.Text = value;
                }
                log.Info($"Tool Frontside Recipe : {value}");
            }
        }
        public string ToolInspectionDies
        {
            set
            {
                if (tb_toolInspectionDies.InvokeRequired)
                {
                    Invoke(new SetString((string _str) => tb_toolInspectionDies.Text = _str), new object[] { value });
                }
                else
                {
                    tb_toolInspectionDies.Text = value;
                }
                log.Info($"Tool Inspection Dies : {value}");
            }
        }
        public string ToolInspectionColumns
        {
            set
            {
                if (tb_toolInspectionColumns.InvokeRequired)
                {
                    Invoke(new SetString((string _str) => tb_toolInspectionColumns.Text = _str), new object[] { value });
                }
                else
                {
                    tb_toolInspectionColumns.Text = value;
                }
                log.Info($"Tool Inspection Columns : {value}");
            }
        }
        public string ToolInspectionRows
        {
            set
            {
                if (tb_toolInspectionRows.InvokeRequired)
                {
                    Invoke(new SetString((string _str) => tb_toolInspectionRows.Text = _str), new object[] { value });
                }
                else
                {
                    tb_toolInspectionRows.Text = value;
                }
                log.Info($"Tool Inspection Rows : {value}");
            }
        }

        public string[] LogStream
        {
            set
            {
                if (lv_log.InvokeRequired)
                {
                    Invoke(new SetLog((string[] _str) => lv_log.Items.Add(new ListViewItem(_str))), new object[]{ value });
                }
                else
                {
                    lv_log.Items.Add(new ListViewItem(value));
                }
            }
        }

        public string PORT
        {
            get
            {
                return cb_portList.SelectedItem.ToString();
            }
        }

        public Form1()
        {
            InitializeComponent();
            LogPresenter.SetViewForm(this);
            PortManager.SetPortViewForm(this);
            this.secsGemPresenter = new SecsGemPresenter(this);
            log.Info("");
            log.Info("ARMS Start");
            log.Info("Version - 0.1.0");
            log.Info("");
            log.Info("GUI INIT");
            lv_log.HeaderStyle = ColumnHeaderStyle.None;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            lv_ppidList.Items.Clear();
            log.Info("PPID List Load");
            new PpidPresenter(this).PrintAllPpid();
        }

        private void lv_ppidList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            secsGemPresenter.ParamUploadRequest(Ppid[0]);
        }

        private void btn_paramUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                log.Info($"Recipe Parameter Upload - {Ppid[0]}");
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                secsGemPresenter.SecsGemStart();
            }
            catch (Exception ex)
            {
                log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", ex);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            secsGemPresenter.SecsGemStop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cb_portList.Items.Add("5000");
            cb_portList.Items.Add("5001");
            cb_portList.Items.Add("5002");
            cb_portList.Items.Add("5003");
        }
    }
}
