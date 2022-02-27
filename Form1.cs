using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARMS
{
    public partial class Form1 : Form
    {
        bool statusFlag;
        SecsService service;
        public Form1()
        {
            InitializeComponent();
            statusFlag = false;
            service = new SecsService(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!statusFlag)
            {
                label2.Text = "SECS/GEM Running";
                statusFlag = true;
                service.start();
            }
            else
            {
                label2.Text = "Already SECS/GEM Running";
            }
        }

        public void setClusterRecipeText(String text)
        {
            tb_clusterRecipeName.Text = text;
        }

        public void setFrontsideRecipeText(String text)
        {
            tb_frontsideRecipeName.Text = text;
        }

        public void setInspectionDiesText(String text)
        {
            tb_inspectionDies.Text = text;
        }

        public void setRowDiesText(String text)
        {
            tb_rowDies.Text = text;
        }

        public void setColumnDiesText(String text)
        {
            tb_columnDies.Text = text;
        }

        public void setDBConnectionText(String text)
        {
            lb_DBConnection.Text = text;
        }
    }
}
