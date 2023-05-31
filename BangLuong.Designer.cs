
namespace PayrollManagement
{
    partial class BangLuong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label10 = new System.Windows.Forms.Label();
            this.nam = new System.Windows.Forms.ComboBox();
            this.tennv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.idnv = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.thang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CCview = new System.Windows.Forms.DataGridView();
            this.solanditre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.sogiotc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.songaylt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.songaylv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_tatca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CCview)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(279, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 17);
            this.label10.TabIndex = 75;
            this.label10.Text = "Năm";
            // 
            // nam
            // 
            this.nam.FormattingEnabled = true;
            this.nam.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023"});
            this.nam.Location = new System.Drawing.Point(322, 27);
            this.nam.Name = "nam";
            this.nam.Size = new System.Drawing.Size(72, 24);
            this.nam.TabIndex = 74;
            this.nam.SelectedIndexChanged += new System.EventHandler(this.nam_SelectedIndexChanged);
            // 
            // tennv
            // 
            this.tennv.Location = new System.Drawing.Point(192, 139);
            this.tennv.Multiline = true;
            this.tennv.Name = "tennv";
            this.tennv.Size = new System.Drawing.Size(227, 33);
            this.tennv.TabIndex = 71;
            this.tennv.TextChanged += new System.EventHandler(this.tennv_TextChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(44, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 28);
            this.label4.TabIndex = 70;
            this.label4.Text = "Tên nhân viên";
            // 
            // idnv
            // 
            this.idnv.FormattingEnabled = true;
            this.idnv.Location = new System.Drawing.Point(175, 85);
            this.idnv.Name = "idnv";
            this.idnv.Size = new System.Drawing.Size(56, 24);
            this.idnv.TabIndex = 69;
            this.idnv.SelectedIndexChanged += new System.EventHandler(this.idnv_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(67, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 68;
            this.label3.Text = "Tháng";
            // 
            // thang
            // 
            this.thang.FormattingEnabled = true;
            this.thang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.thang.Location = new System.Drawing.Point(159, 27);
            this.thang.Name = "thang";
            this.thang.Size = new System.Drawing.Size(72, 24);
            this.thang.TabIndex = 67;
            this.thang.SelectedIndexChanged += new System.EventHandler(this.thang_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(67, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 66;
            this.label2.Text = "Mã nhân viên";
            // 
            // CCview
            // 
            this.CCview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CCview.Location = new System.Drawing.Point(27, 270);
            this.CCview.Name = "CCview";
            this.CCview.RowHeadersWidth = 51;
            this.CCview.RowTemplate.Height = 24;
            this.CCview.Size = new System.Drawing.Size(1317, 485);
            this.CCview.TabIndex = 86;
            this.CCview.SelectionChanged += new System.EventHandler(this.CCview_SelectionChanged);
            // 
            // solanditre
            // 
            this.solanditre.Location = new System.Drawing.Point(237, 68);
            this.solanditre.Name = "solanditre";
            this.solanditre.Size = new System.Drawing.Size(86, 22);
            this.solanditre.TabIndex = 95;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(95, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 17);
            this.label9.TabIndex = 94;
            this.label9.Text = "Số lần đi trễ";
            // 
            // sogiotc
            // 
            this.sogiotc.Location = new System.Drawing.Point(237, 150);
            this.sogiotc.Name = "sogiotc";
            this.sogiotc.Size = new System.Drawing.Size(86, 22);
            this.sogiotc.TabIndex = 93;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(95, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 17);
            this.label8.TabIndex = 92;
            this.label8.Text = "Số giờ tăng ca";
            // 
            // songaylt
            // 
            this.songaylt.Location = new System.Drawing.Point(237, 107);
            this.songaylt.Name = "songaylt";
            this.songaylt.Size = new System.Drawing.Size(86, 22);
            this.songaylt.TabIndex = 91;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(95, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 17);
            this.label7.TabIndex = 90;
            this.label7.Text = "Số ngày làm thêm";
            // 
            // songaylv
            // 
            this.songaylv.Location = new System.Drawing.Point(237, 34);
            this.songaylv.Name = "songaylv";
            this.songaylv.Size = new System.Drawing.Size(86, 22);
            this.songaylv.TabIndex = 89;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(95, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 17);
            this.label5.TabIndex = 88;
            this.label5.Text = "Số ngày làm việc";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.solanditre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.songaylv);
            this.groupBox1.Controls.Add(this.sogiotc);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.songaylt);
            this.groupBox1.Location = new System.Drawing.Point(73, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 212);
            this.groupBox1.TabIndex = 96;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_tatca);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.thang);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.idnv);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.nam);
            this.groupBox2.Controls.Add(this.tennv);
            this.groupBox2.Location = new System.Drawing.Point(750, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(487, 212);
            this.groupBox2.TabIndex = 97;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lọc";
            // 
            // btn_tatca
            // 
            this.btn_tatca.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_tatca.Location = new System.Drawing.Point(282, 79);
            this.btn_tatca.Name = "btn_tatca";
            this.btn_tatca.Size = new System.Drawing.Size(71, 35);
            this.btn_tatca.TabIndex = 76;
            this.btn_tatca.Text = "Tất cả";
            this.btn_tatca.UseVisualStyleBackColor = true;
            this.btn_tatca.Click += new System.EventHandler(this.btn_tatca_Click);
            // 
            // BangLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1370, 784);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CCview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BangLuong";
            this.Text = "BangLuong";
            this.Load += new System.EventHandler(this.BangLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CCview)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox nam;
        private System.Windows.Forms.TextBox tennv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox idnv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox thang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView CCview;
        private System.Windows.Forms.TextBox solanditre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox sogiotc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox songaylt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox songaylv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_tatca;
    }
}