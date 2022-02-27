
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_clusterRecipeName = new System.Windows.Forms.TextBox();
            this.tb_frontsideRecipeName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_inspectionDies = new System.Windows.Forms.TextBox();
            this.tb_rowDies = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_columnDies = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_DBConnection = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 252);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(534, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "SECS/GEM STATUS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ready";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cluster Recipe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Frontside Recipe";
            // 
            // tb_clusterRecipeName
            // 
            this.tb_clusterRecipeName.Location = new System.Drawing.Point(181, 74);
            this.tb_clusterRecipeName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_clusterRecipeName.Name = "tb_clusterRecipeName";
            this.tb_clusterRecipeName.Size = new System.Drawing.Size(354, 25);
            this.tb_clusterRecipeName.TabIndex = 5;
            // 
            // tb_frontsideRecipeName
            // 
            this.tb_frontsideRecipeName.Location = new System.Drawing.Point(181, 128);
            this.tb_frontsideRecipeName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_frontsideRecipeName.Name = "tb_frontsideRecipeName";
            this.tb_frontsideRecipeName.Size = new System.Drawing.Size(354, 25);
            this.tb_frontsideRecipeName.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Inspection Dies";
            // 
            // tb_inspectionDies
            // 
            this.tb_inspectionDies.Location = new System.Drawing.Point(127, 198);
            this.tb_inspectionDies.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_inspectionDies.Name = "tb_inspectionDies";
            this.tb_inspectionDies.Size = new System.Drawing.Size(52, 25);
            this.tb_inspectionDies.TabIndex = 8;
            // 
            // tb_rowDies
            // 
            this.tb_rowDies.Location = new System.Drawing.Point(290, 198);
            this.tb_rowDies.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_rowDies.Name = "tb_rowDies";
            this.tb_rowDies.Size = new System.Drawing.Size(52, 25);
            this.tb_rowDies.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Row Dies";
            // 
            // tb_columnDies
            // 
            this.tb_columnDies.Location = new System.Drawing.Point(482, 198);
            this.tb_columnDies.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_columnDies.Name = "tb_columnDies";
            this.tb_columnDies.Size = new System.Drawing.Size(52, 25);
            this.tb_columnDies.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(386, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Column Dies";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "DB Connection";
            // 
            // lb_DBConnection
            // 
            this.lb_DBConnection.AutoSize = true;
            this.lb_DBConnection.Location = new System.Drawing.Point(178, 43);
            this.lb_DBConnection.Name = "lb_DBConnection";
            this.lb_DBConnection.Size = new System.Drawing.Size(49, 15);
            this.lb_DBConnection.TabIndex = 14;
            this.lb_DBConnection.Text = "Ready";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 296);
            this.Controls.Add(this.lb_DBConnection);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_columnDies);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_rowDies);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_inspectionDies);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_frontsideRecipeName);
            this.Controls.Add(this.tb_clusterRecipeName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_clusterRecipeName;
        private System.Windows.Forms.TextBox tb_frontsideRecipeName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_inspectionDies;
        private System.Windows.Forms.TextBox tb_rowDies;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_columnDies;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_DBConnection;
    }
}

