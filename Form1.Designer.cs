
namespace ARMS
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_paramUpdate = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lv_ppidList = new System.Windows.Forms.ListView();
            this.Device = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PPID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_specClusterRecipe = new System.Windows.Forms.TextBox();
            this.tb_toolClusterRecipe = new System.Windows.Forms.TextBox();
            this.tb_specFrontsideRecipe = new System.Windows.Forms.TextBox();
            this.tb_toolFrontsideRecipe = new System.Windows.Forms.TextBox();
            this.tb_specInspectionDies = new System.Windows.Forms.TextBox();
            this.tb_toolInspectionDies = new System.Windows.Forms.TextBox();
            this.tb_specInspectionColumns = new System.Windows.Forms.TextBox();
            this.tb_toolInspectionColumns = new System.Windows.Forms.TextBox();
            this.tb_specInspectionRows = new System.Windows.Forms.TextBox();
            this.tb_toolInspectionRows = new System.Windows.Forms.TextBox();
            this.btn_dbUpload = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1264, 652);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.listView1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 532);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.59912F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1258, 117);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1252, 111);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Date";
            this.columnHeader1.Width = 136;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Port";
            this.columnHeader2.Width = 52;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Lot ID";
            this.columnHeader3.Width = 107;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cluster Recipe";
            this.columnHeader4.Width = 296;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Frontside Recipe";
            this.columnHeader5.Width = 417;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Dies";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Columns";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Rows";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Result";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 530F));
            this.tableLayoutPanel3.Controls.Add(this.btn_paramUpdate, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel7, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 36);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1258, 490);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // btn_paramUpdate
            // 
            this.btn_paramUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_paramUpdate.Location = new System.Drawing.Point(703, 3);
            this.btn_paramUpdate.Name = "btn_paramUpdate";
            this.btn_paramUpdate.Size = new System.Drawing.Size(22, 484);
            this.btn_paramUpdate.TabIndex = 0;
            this.btn_paramUpdate.Text = ">";
            this.btn_paramUpdate.UseVisualStyleBackColor = true;
            this.btn_paramUpdate.Click += new System.EventHandler(this.btn_paramUpdate_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.lv_ppidList, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.77551F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.22449F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(700, 490);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.43516F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.42651F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.28242F));
            this.tableLayoutPanel2.Controls.Add(this.button2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(694, 36);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(583, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "All";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(470, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(461, 31);
            this.textBox1.TabIndex = 0;
            // 
            // lv_ppidList
            // 
            this.lv_ppidList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Device,
            this.PPID});
            this.lv_ppidList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_ppidList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_ppidList.HideSelection = false;
            this.lv_ppidList.Location = new System.Drawing.Point(3, 45);
            this.lv_ppidList.Name = "lv_ppidList";
            this.lv_ppidList.Size = new System.Drawing.Size(694, 442);
            this.lv_ppidList.TabIndex = 0;
            this.lv_ppidList.UseCompatibleStateImageBehavior = false;
            this.lv_ppidList.View = System.Windows.Forms.View.Details;
            this.lv_ppidList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lv_ppidList_MouseDoubleClick);
            // 
            // Device
            // 
            this.Device.Text = "Device";
            this.Device.Width = 217;
            // 
            // PPID
            // 
            this.PPID.Text = "PPID";
            this.PPID.Width = 472;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.btn_dbUpload, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(731, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.1157F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.884297F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(524, 484);
            this.tableLayoutPanel7.TabIndex = 2;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 4;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 202F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel6.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel6.Controls.Add(this.label9, 0, 5);
            this.tableLayoutPanel6.Controls.Add(this.tb_specClusterRecipe, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.tb_toolClusterRecipe, 2, 1);
            this.tableLayoutPanel6.Controls.Add(this.tb_specFrontsideRecipe, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.tb_toolFrontsideRecipe, 2, 2);
            this.tableLayoutPanel6.Controls.Add(this.tb_specInspectionDies, 1, 3);
            this.tableLayoutPanel6.Controls.Add(this.tb_toolInspectionDies, 2, 3);
            this.tableLayoutPanel6.Controls.Add(this.tb_specInspectionColumns, 1, 4);
            this.tableLayoutPanel6.Controls.Add(this.tb_toolInspectionColumns, 2, 4);
            this.tableLayoutPanel6.Controls.Add(this.tb_specInspectionRows, 1, 5);
            this.tableLayoutPanel6.Controls.Add(this.tb_toolInspectionRows, 2, 5);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 6;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.92105F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.07895F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(518, 434);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 104);
            this.label1.TabIndex = 0;
            this.label1.Text = "Itmes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 104);
            this.label2.TabIndex = 1;
            this.label2.Text = "Spec";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(294, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 104);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tool";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 82);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cluster Recipe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 60);
            this.label6.TabIndex = 5;
            this.label6.Text = "Frontside Recipe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 59);
            this.label7.TabIndex = 6;
            this.label7.Text = "Inspection Dies";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 60);
            this.label8.TabIndex = 7;
            this.label8.Text = "Inspection Columns";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 365);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 69);
            this.label9.TabIndex = 8;
            this.label9.Text = "Inspection Rows";
            // 
            // tb_specClusterRecipe
            // 
            this.tb_specClusterRecipe.BackColor = System.Drawing.SystemColors.Control;
            this.tb_specClusterRecipe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_specClusterRecipe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_specClusterRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_specClusterRecipe.Location = new System.Drawing.Point(92, 107);
            this.tb_specClusterRecipe.Multiline = true;
            this.tb_specClusterRecipe.Name = "tb_specClusterRecipe";
            this.tb_specClusterRecipe.Size = new System.Drawing.Size(196, 76);
            this.tb_specClusterRecipe.TabIndex = 9;
            // 
            // tb_toolClusterRecipe
            // 
            this.tb_toolClusterRecipe.BackColor = System.Drawing.SystemColors.Control;
            this.tb_toolClusterRecipe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_toolClusterRecipe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_toolClusterRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_toolClusterRecipe.Location = new System.Drawing.Point(294, 107);
            this.tb_toolClusterRecipe.Multiline = true;
            this.tb_toolClusterRecipe.Name = "tb_toolClusterRecipe";
            this.tb_toolClusterRecipe.Size = new System.Drawing.Size(169, 76);
            this.tb_toolClusterRecipe.TabIndex = 10;
            // 
            // tb_specFrontsideRecipe
            // 
            this.tb_specFrontsideRecipe.BackColor = System.Drawing.SystemColors.Control;
            this.tb_specFrontsideRecipe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_specFrontsideRecipe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_specFrontsideRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_specFrontsideRecipe.Location = new System.Drawing.Point(92, 189);
            this.tb_specFrontsideRecipe.Multiline = true;
            this.tb_specFrontsideRecipe.Name = "tb_specFrontsideRecipe";
            this.tb_specFrontsideRecipe.Size = new System.Drawing.Size(196, 54);
            this.tb_specFrontsideRecipe.TabIndex = 11;
            // 
            // tb_toolFrontsideRecipe
            // 
            this.tb_toolFrontsideRecipe.BackColor = System.Drawing.SystemColors.Control;
            this.tb_toolFrontsideRecipe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_toolFrontsideRecipe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_toolFrontsideRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_toolFrontsideRecipe.Location = new System.Drawing.Point(294, 189);
            this.tb_toolFrontsideRecipe.Multiline = true;
            this.tb_toolFrontsideRecipe.Name = "tb_toolFrontsideRecipe";
            this.tb_toolFrontsideRecipe.Size = new System.Drawing.Size(169, 54);
            this.tb_toolFrontsideRecipe.TabIndex = 12;
            // 
            // tb_specInspectionDies
            // 
            this.tb_specInspectionDies.BackColor = System.Drawing.SystemColors.Control;
            this.tb_specInspectionDies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_specInspectionDies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_specInspectionDies.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_specInspectionDies.Location = new System.Drawing.Point(92, 249);
            this.tb_specInspectionDies.Multiline = true;
            this.tb_specInspectionDies.Name = "tb_specInspectionDies";
            this.tb_specInspectionDies.Size = new System.Drawing.Size(196, 53);
            this.tb_specInspectionDies.TabIndex = 13;
            // 
            // tb_toolInspectionDies
            // 
            this.tb_toolInspectionDies.BackColor = System.Drawing.SystemColors.Control;
            this.tb_toolInspectionDies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_toolInspectionDies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_toolInspectionDies.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_toolInspectionDies.Location = new System.Drawing.Point(294, 249);
            this.tb_toolInspectionDies.Multiline = true;
            this.tb_toolInspectionDies.Name = "tb_toolInspectionDies";
            this.tb_toolInspectionDies.Size = new System.Drawing.Size(169, 53);
            this.tb_toolInspectionDies.TabIndex = 14;
            // 
            // tb_specInspectionColumns
            // 
            this.tb_specInspectionColumns.BackColor = System.Drawing.SystemColors.Control;
            this.tb_specInspectionColumns.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_specInspectionColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_specInspectionColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_specInspectionColumns.Location = new System.Drawing.Point(92, 308);
            this.tb_specInspectionColumns.Multiline = true;
            this.tb_specInspectionColumns.Name = "tb_specInspectionColumns";
            this.tb_specInspectionColumns.Size = new System.Drawing.Size(196, 54);
            this.tb_specInspectionColumns.TabIndex = 15;
            // 
            // tb_toolInspectionColumns
            // 
            this.tb_toolInspectionColumns.BackColor = System.Drawing.SystemColors.Control;
            this.tb_toolInspectionColumns.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_toolInspectionColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_toolInspectionColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_toolInspectionColumns.Location = new System.Drawing.Point(294, 308);
            this.tb_toolInspectionColumns.Multiline = true;
            this.tb_toolInspectionColumns.Name = "tb_toolInspectionColumns";
            this.tb_toolInspectionColumns.Size = new System.Drawing.Size(169, 54);
            this.tb_toolInspectionColumns.TabIndex = 16;
            // 
            // tb_specInspectionRows
            // 
            this.tb_specInspectionRows.BackColor = System.Drawing.SystemColors.Control;
            this.tb_specInspectionRows.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_specInspectionRows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_specInspectionRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_specInspectionRows.Location = new System.Drawing.Point(92, 368);
            this.tb_specInspectionRows.Multiline = true;
            this.tb_specInspectionRows.Name = "tb_specInspectionRows";
            this.tb_specInspectionRows.Size = new System.Drawing.Size(196, 63);
            this.tb_specInspectionRows.TabIndex = 17;
            // 
            // tb_toolInspectionRows
            // 
            this.tb_toolInspectionRows.BackColor = System.Drawing.SystemColors.Control;
            this.tb_toolInspectionRows.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_toolInspectionRows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_toolInspectionRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_toolInspectionRows.Location = new System.Drawing.Point(294, 368);
            this.tb_toolInspectionRows.Multiline = true;
            this.tb_toolInspectionRows.Name = "tb_toolInspectionRows";
            this.tb_toolInspectionRows.Size = new System.Drawing.Size(169, 63);
            this.tb_toolInspectionRows.TabIndex = 18;
            // 
            // btn_dbUpload
            // 
            this.btn_dbUpload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_dbUpload.Location = new System.Drawing.Point(3, 443);
            this.btn_dbUpload.Name = "btn_dbUpload";
            this.btn_dbUpload.Size = new System.Drawing.Size(518, 38);
            this.btn_dbUpload.TabIndex = 3;
            this.btn_dbUpload.Text = "DB Upload";
            this.btn_dbUpload.UseVisualStyleBackColor = true;
            this.btn_dbUpload.Click += new System.EventHandler(this.btn_dbUpload_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1264, 652);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "ARMS";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView lv_ppidList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColumnHeader Device;
        private System.Windows.Forms.ColumnHeader PPID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btn_paramUpdate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_specClusterRecipe;
        private System.Windows.Forms.TextBox tb_toolClusterRecipe;
        private System.Windows.Forms.TextBox tb_specFrontsideRecipe;
        private System.Windows.Forms.TextBox tb_toolFrontsideRecipe;
        private System.Windows.Forms.TextBox tb_specInspectionDies;
        private System.Windows.Forms.TextBox tb_toolInspectionDies;
        private System.Windows.Forms.TextBox tb_specInspectionColumns;
        private System.Windows.Forms.TextBox tb_toolInspectionColumns;
        private System.Windows.Forms.TextBox tb_specInspectionRows;
        private System.Windows.Forms.TextBox tb_toolInspectionRows;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button btn_dbUpload;
    }
}

