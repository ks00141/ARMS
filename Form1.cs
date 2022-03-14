using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ARMS.View;

namespace ARMS
{
    public partial class Form1 : Form
    {
        bool statusFlag;
        SecsService service;
        FunctionView functioView;
        public Form1()
        {
            InitializeComponent();
            Console.WriteLine("Init ARMS V0.0.1");
            statusFlag = false;
            functioView = new FunctionView(this);
            label2.Text = "SECS/GEM Running";
            Console.WriteLine("SECS/GEM Running");
            functioView.start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*if (!statusFlag)
            {
                label2.Text = "SECS/GEM Running";
                Console.WriteLine("SECS/GEM Running");
                statusFlag = true;
                service.start();
            }
            else
            {
                label2.Text = "Already SECS/GEM Running";
                Console.WriteLine("Already SECS/GEM Running");
            }*/
        }
        public void setRecipeTable(DataTable data)
        {
            dataGridView1.DataSource = data;
            Console.WriteLine(data);
        }

        public void setSpecTable(DataTable data)
        {
            dataGridView2.DataSource = data;
            Console.WriteLine(data);
        }

        public void setPValidText(String text)
        {
            lbl_pvalid.Text = text;
            Console.WriteLine("ERR CODE : " + text);
        }

        public void setClusterRecipeText(String text)
        {
            tb_clusterRecipeName.Text = text;
            Console.WriteLine("Cluster Recipe : "+ text);
        }

        public void setFrontsideRecipeText(String text)
        {
            tb_frontsideRecipeName.Text = text;
            Console.WriteLine("Frontside Recipe : " + text);
        }

        public void setInspectionDiesText(String text)
        {
            tb_inspectionDies.Text = text;
            Console.WriteLine("Inspection Dies : " + text);
        }

        public void setRowDiesText(String text)
        {
            tb_rowDies.Text = text;
            Console.WriteLine("Inspection Rows : " + text);
        }

        public void setColumnDiesText(String text)
        {
            tb_columnDies.Text = text;
            Console.WriteLine("Inspectionm Columns : " + text);
        }

        public void setDBConnectionText(String text)
        {
            lb_DBConnection.Text = text;
            Console.WriteLine(text);
        }
    }
}
