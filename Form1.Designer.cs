
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
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.STATUS_LB = new MetroSet_UI.Controls.MetroSetLabel();
            this.CB_PPID = new System.Windows.Forms.ComboBox();
            this.TB_DEVICE = new System.Windows.Forms.TextBox();
            this.BTN_PPIDSERACH = new System.Windows.Forms.Button();
            this.TB_CLUSTERRECIPE_SG = new System.Windows.Forms.TextBox();
            this.TB_FRONTSIDERECIPE_SG = new System.Windows.Forms.TextBox();
            this.TB_INSPECTIONDIES_SG = new System.Windows.Forms.TextBox();
            this.TB_INSPECTIONCOLUMNS_SG = new System.Windows.Forms.TextBox();
            this.TB_INSPECTIONROWS_SG = new System.Windows.Forms.TextBox();
            this.TB_INSPECTIONROWS = new System.Windows.Forms.TextBox();
            this.TB_INSPECTIONCOLUMNS = new System.Windows.Forms.TextBox();
            this.TB_INSPECTIONDIES = new System.Windows.Forms.TextBox();
            this.TB_FRONTSIDERECIPE = new System.Windows.Forms.TextBox();
            this.TB_CLUSTERRECIPE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CHB_AP = new System.Windows.Forms.CheckBox();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel4 = new MetroSet_UI.Controls.MetroSetLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(16, 27);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(238, 24);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 0;
            this.metroSetLabel1.Text = "SECS/GEM STATUS";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // STATUS_LB
            // 
            this.STATUS_LB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.STATUS_LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STATUS_LB.IsDerivedStyle = true;
            this.STATUS_LB.Location = new System.Drawing.Point(17, 63);
            this.STATUS_LB.Name = "STATUS_LB";
            this.STATUS_LB.Size = new System.Drawing.Size(335, 98);
            this.STATUS_LB.Style = MetroSet_UI.Enums.Style.Light;
            this.STATUS_LB.StyleManager = null;
            this.STATUS_LB.TabIndex = 18;
            this.STATUS_LB.ThemeAuthor = "Narwin";
            this.STATUS_LB.ThemeName = "MetroLite";
            // 
            // CB_PPID
            // 
            this.CB_PPID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_PPID.FormattingEnabled = true;
            this.CB_PPID.Location = new System.Drawing.Point(567, 128);
            this.CB_PPID.Name = "CB_PPID";
            this.CB_PPID.Size = new System.Drawing.Size(577, 33);
            this.CB_PPID.TabIndex = 20;
            // 
            // TB_DEVICE
            // 
            this.TB_DEVICE.Location = new System.Drawing.Point(567, 91);
            this.TB_DEVICE.Name = "TB_DEVICE";
            this.TB_DEVICE.Size = new System.Drawing.Size(577, 31);
            this.TB_DEVICE.TabIndex = 21;
            // 
            // BTN_PPIDSERACH
            // 
            this.BTN_PPIDSERACH.Location = new System.Drawing.Point(1153, 91);
            this.BTN_PPIDSERACH.Name = "BTN_PPIDSERACH";
            this.BTN_PPIDSERACH.Size = new System.Drawing.Size(121, 70);
            this.BTN_PPIDSERACH.TabIndex = 22;
            this.BTN_PPIDSERACH.Text = "Serach";
            this.BTN_PPIDSERACH.UseVisualStyleBackColor = true;
            this.BTN_PPIDSERACH.Click += new System.EventHandler(this.BTN_PPIDSERACH_Click);
            // 
            // TB_CLUSTERRECIPE_SG
            // 
            this.TB_CLUSTERRECIPE_SG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TB_CLUSTERRECIPE_SG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_CLUSTERRECIPE_SG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_CLUSTERRECIPE_SG.ForeColor = System.Drawing.SystemColors.Window;
            this.TB_CLUSTERRECIPE_SG.Location = new System.Drawing.Point(214, 119);
            this.TB_CLUSTERRECIPE_SG.Name = "TB_CLUSTERRECIPE_SG";
            this.TB_CLUSTERRECIPE_SG.Size = new System.Drawing.Size(406, 19);
            this.TB_CLUSTERRECIPE_SG.TabIndex = 23;
            // 
            // TB_FRONTSIDERECIPE_SG
            // 
            this.TB_FRONTSIDERECIPE_SG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TB_FRONTSIDERECIPE_SG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_FRONTSIDERECIPE_SG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_FRONTSIDERECIPE_SG.ForeColor = System.Drawing.SystemColors.Window;
            this.TB_FRONTSIDERECIPE_SG.Location = new System.Drawing.Point(214, 166);
            this.TB_FRONTSIDERECIPE_SG.Name = "TB_FRONTSIDERECIPE_SG";
            this.TB_FRONTSIDERECIPE_SG.Size = new System.Drawing.Size(404, 19);
            this.TB_FRONTSIDERECIPE_SG.TabIndex = 24;
            // 
            // TB_INSPECTIONDIES_SG
            // 
            this.TB_INSPECTIONDIES_SG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TB_INSPECTIONDIES_SG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_INSPECTIONDIES_SG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_INSPECTIONDIES_SG.ForeColor = System.Drawing.SystemColors.Window;
            this.TB_INSPECTIONDIES_SG.Location = new System.Drawing.Point(61, 255);
            this.TB_INSPECTIONDIES_SG.Name = "TB_INSPECTIONDIES_SG";
            this.TB_INSPECTIONDIES_SG.Size = new System.Drawing.Size(51, 19);
            this.TB_INSPECTIONDIES_SG.TabIndex = 25;
            // 
            // TB_INSPECTIONCOLUMNS_SG
            // 
            this.TB_INSPECTIONCOLUMNS_SG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TB_INSPECTIONCOLUMNS_SG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_INSPECTIONCOLUMNS_SG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_INSPECTIONCOLUMNS_SG.ForeColor = System.Drawing.SystemColors.Window;
            this.TB_INSPECTIONCOLUMNS_SG.Location = new System.Drawing.Point(245, 255);
            this.TB_INSPECTIONCOLUMNS_SG.Name = "TB_INSPECTIONCOLUMNS_SG";
            this.TB_INSPECTIONCOLUMNS_SG.Size = new System.Drawing.Size(51, 19);
            this.TB_INSPECTIONCOLUMNS_SG.TabIndex = 26;
            // 
            // TB_INSPECTIONROWS_SG
            // 
            this.TB_INSPECTIONROWS_SG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TB_INSPECTIONROWS_SG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_INSPECTIONROWS_SG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_INSPECTIONROWS_SG.ForeColor = System.Drawing.SystemColors.Window;
            this.TB_INSPECTIONROWS_SG.Location = new System.Drawing.Point(438, 255);
            this.TB_INSPECTIONROWS_SG.Name = "TB_INSPECTIONROWS_SG";
            this.TB_INSPECTIONROWS_SG.Size = new System.Drawing.Size(51, 19);
            this.TB_INSPECTIONROWS_SG.TabIndex = 27;
            // 
            // TB_INSPECTIONROWS
            // 
            this.TB_INSPECTIONROWS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TB_INSPECTIONROWS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_INSPECTIONROWS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_INSPECTIONROWS.ForeColor = System.Drawing.SystemColors.Window;
            this.TB_INSPECTIONROWS.Location = new System.Drawing.Point(1093, 252);
            this.TB_INSPECTIONROWS.Name = "TB_INSPECTIONROWS";
            this.TB_INSPECTIONROWS.Size = new System.Drawing.Size(51, 19);
            this.TB_INSPECTIONROWS.TabIndex = 32;
            this.TB_INSPECTIONROWS.TabStop = false;
            // 
            // TB_INSPECTIONCOLUMNS
            // 
            this.TB_INSPECTIONCOLUMNS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TB_INSPECTIONCOLUMNS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_INSPECTIONCOLUMNS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_INSPECTIONCOLUMNS.ForeColor = System.Drawing.SystemColors.Window;
            this.TB_INSPECTIONCOLUMNS.Location = new System.Drawing.Point(900, 252);
            this.TB_INSPECTIONCOLUMNS.Name = "TB_INSPECTIONCOLUMNS";
            this.TB_INSPECTIONCOLUMNS.Size = new System.Drawing.Size(51, 19);
            this.TB_INSPECTIONCOLUMNS.TabIndex = 31;
            this.TB_INSPECTIONCOLUMNS.TabStop = false;
            // 
            // TB_INSPECTIONDIES
            // 
            this.TB_INSPECTIONDIES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TB_INSPECTIONDIES.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_INSPECTIONDIES.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_INSPECTIONDIES.ForeColor = System.Drawing.SystemColors.Window;
            this.TB_INSPECTIONDIES.Location = new System.Drawing.Point(716, 252);
            this.TB_INSPECTIONDIES.Name = "TB_INSPECTIONDIES";
            this.TB_INSPECTIONDIES.Size = new System.Drawing.Size(51, 19);
            this.TB_INSPECTIONDIES.TabIndex = 30;
            this.TB_INSPECTIONDIES.TabStop = false;
            // 
            // TB_FRONTSIDERECIPE
            // 
            this.TB_FRONTSIDERECIPE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TB_FRONTSIDERECIPE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_FRONTSIDERECIPE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_FRONTSIDERECIPE.ForeColor = System.Drawing.SystemColors.Window;
            this.TB_FRONTSIDERECIPE.Location = new System.Drawing.Point(880, 166);
            this.TB_FRONTSIDERECIPE.Name = "TB_FRONTSIDERECIPE";
            this.TB_FRONTSIDERECIPE.Size = new System.Drawing.Size(406, 19);
            this.TB_FRONTSIDERECIPE.TabIndex = 29;
            this.TB_FRONTSIDERECIPE.TabStop = false;
            // 
            // TB_CLUSTERRECIPE
            // 
            this.TB_CLUSTERRECIPE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TB_CLUSTERRECIPE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_CLUSTERRECIPE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_CLUSTERRECIPE.ForeColor = System.Drawing.SystemColors.Window;
            this.TB_CLUSTERRECIPE.Location = new System.Drawing.Point(880, 119);
            this.TB_CLUSTERRECIPE.Name = "TB_CLUSTERRECIPE";
            this.TB_CLUSTERRECIPE.Size = new System.Drawing.Size(404, 19);
            this.TB_CLUSTERRECIPE.TabIndex = 28;
            this.TB_CLUSTERRECIPE.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 31);
            this.label1.TabIndex = 34;
            this.label1.Text = "Recipe Info";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(27, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 35;
            this.label2.Text = "Tool Recipe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(679, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 36;
            this.label3.Text = "Spec Recipe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(57, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Cluster Recipe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(57, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Frontside Recipe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(57, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 20);
            this.label6.TabIndex = 39;
            this.label6.Text = "Inspection Count";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(241, 443);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 20);
            this.label7.TabIndex = 40;
            this.label7.Text = "Inspection Columns";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(434, 443);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 20);
            this.label8.TabIndex = 41;
            this.label8.Text = "Inspection Rows";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(1089, 443);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 20);
            this.label9.TabIndex = 46;
            this.label9.Text = "Inspection Rows";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(896, 443);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 20);
            this.label10.TabIndex = 45;
            this.label10.Text = "Inspection Columns";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(712, 443);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 20);
            this.label11.TabIndex = 44;
            this.label11.Text = "Inspection Count";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(712, 386);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 20);
            this.label12.TabIndex = 43;
            this.label12.Text = "Frontside Recipe";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(712, 336);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 20);
            this.label13.TabIndex = 42;
            this.label13.Text = "Cluster Recipe";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.TB_INSPECTIONDIES_SG);
            this.panel1.Controls.Add(this.TB_INSPECTIONCOLUMNS_SG);
            this.panel1.Controls.Add(this.TB_INSPECTIONROWS_SG);
            this.panel1.Controls.Add(this.TB_INSPECTIONDIES);
            this.panel1.Controls.Add(this.TB_INSPECTIONCOLUMNS);
            this.panel1.Controls.Add(this.TB_INSPECTIONROWS);
            this.panel1.Controls.Add(this.TB_CLUSTERRECIPE);
            this.panel1.Controls.Add(this.TB_FRONTSIDERECIPE);
            this.panel1.Controls.Add(this.TB_FRONTSIDERECIPE_SG);
            this.panel1.Controls.Add(this.TB_CLUSTERRECIPE_SG);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 218);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1305, 293);
            this.panel1.TabIndex = 47;
            // 
            // CHB_AP
            // 
            this.CHB_AP.AutoSize = true;
            this.CHB_AP.Location = new System.Drawing.Point(17, 171);
            this.CHB_AP.Name = "CHB_AP";
            this.CHB_AP.Size = new System.Drawing.Size(131, 29);
            this.CHB_AP.TabIndex = 48;
            this.CHB_AP.Text = "ALL PASS";
            this.CHB_AP.UseVisualStyleBackColor = true;
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel2.IsDerivedStyle = true;
            this.metroSetLabel2.Location = new System.Drawing.Point(498, 27);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(238, 24);
            this.metroSetLabel2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 49;
            this.metroSetLabel2.Text = "PPID Search";
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroLite";
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel3.IsDerivedStyle = true;
            this.metroSetLabel3.Location = new System.Drawing.Point(498, 96);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(66, 24);
            this.metroSetLabel3.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel3.StyleManager = null;
            this.metroSetLabel3.TabIndex = 50;
            this.metroSetLabel3.Text = "Device";
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroLite";
            // 
            // metroSetLabel4
            // 
            this.metroSetLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel4.IsDerivedStyle = true;
            this.metroSetLabel4.Location = new System.Drawing.Point(500, 133);
            this.metroSetLabel4.Name = "metroSetLabel4";
            this.metroSetLabel4.Size = new System.Drawing.Size(66, 24);
            this.metroSetLabel4.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel4.StyleManager = null;
            this.metroSetLabel4.TabIndex = 51;
            this.metroSetLabel4.Text = "PPID";
            this.metroSetLabel4.ThemeAuthor = "Narwin";
            this.metroSetLabel4.ThemeName = "MetroLite";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1300, 505);
            this.Controls.Add(this.metroSetLabel4);
            this.Controls.Add(this.metroSetLabel3);
            this.Controls.Add(this.metroSetLabel2);
            this.Controls.Add(this.CHB_AP);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTN_PPIDSERACH);
            this.Controls.Add(this.TB_DEVICE);
            this.Controls.Add(this.CB_PPID);
            this.Controls.Add(this.STATUS_LB);
            this.Controls.Add(this.metroSetLabel1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(14, 88, 14, 15);
            this.Text = "ARMS";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetLabel STATUS_LB;
        private System.Windows.Forms.ComboBox CB_PPID;
        private System.Windows.Forms.TextBox TB_DEVICE;
        private System.Windows.Forms.Button BTN_PPIDSERACH;
        private System.Windows.Forms.TextBox TB_CLUSTERRECIPE_SG;
        private System.Windows.Forms.TextBox TB_FRONTSIDERECIPE_SG;
        private System.Windows.Forms.TextBox TB_INSPECTIONDIES_SG;
        private System.Windows.Forms.TextBox TB_INSPECTIONCOLUMNS_SG;
        private System.Windows.Forms.TextBox TB_INSPECTIONROWS_SG;
        private System.Windows.Forms.TextBox TB_INSPECTIONROWS;
        private System.Windows.Forms.TextBox TB_INSPECTIONCOLUMNS;
        private System.Windows.Forms.TextBox TB_INSPECTIONDIES;
        private System.Windows.Forms.TextBox TB_FRONTSIDERECIPE;
        private System.Windows.Forms.TextBox TB_CLUSTERRECIPE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox CHB_AP;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel4;
    }
}

