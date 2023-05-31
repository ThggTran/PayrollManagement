
namespace PayrollManagement
{
    partial class ChamCong
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
            this.delBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CCview = new System.Windows.Forms.DataGridView();
            this.thang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.idnv = new System.Windows.Forms.ComboBox();
            this.tennv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.songaylv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.songaylt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.sogiotc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.solanditre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbx_nv = new System.Windows.Forms.TextBox();
            this.maluong = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nam = new System.Windows.Forms.ComboBox();
            this.SearchNV = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CCview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchNV)).BeginInit();
            this.SuspendLayout();
            // 
            // delBtn
            // 
            this.delBtn.BackColor = System.Drawing.Color.Silver;
            this.delBtn.FlatAppearance.BorderSize = 0;
            this.delBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.delBtn.Location = new System.Drawing.Point(1023, 235);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(139, 45);
            this.delBtn.TabIndex = 42;
            this.delBtn.Text = "Xóa";
            this.delBtn.UseVisualStyleBackColor = false;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Silver;
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.addBtn.Location = new System.Drawing.Point(699, 235);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(139, 45);
            this.addBtn.TabIndex = 41;
            this.addBtn.Text = "Thêm";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.Silver;
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.editBtn.Location = new System.Drawing.Point(861, 235);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(139, 45);
            this.editBtn.TabIndex = 40;
            this.editBtn.Text = "Chỉnh sửa";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(137, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Mã nhân viên";
            // 
            // CCview
            // 
            this.CCview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CCview.Location = new System.Drawing.Point(12, 322);
            this.CCview.Name = "CCview";
            this.CCview.RowHeadersWidth = 51;
            this.CCview.RowTemplate.Height = 24;
            this.CCview.Size = new System.Drawing.Size(1331, 434);
            this.CCview.TabIndex = 43;
            this.CCview.SelectionChanged += new System.EventHandler(this.CCview_SelectionChanged);
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
            this.thang.Location = new System.Drawing.Point(207, 186);
            this.thang.Name = "thang";
            this.thang.Size = new System.Drawing.Size(72, 24);
            this.thang.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(134, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 45;
            this.label3.Text = "Tháng";
            // 
            // idnv
            // 
            this.idnv.FormattingEnabled = true;
            this.idnv.Location = new System.Drawing.Point(263, 12);
            this.idnv.Name = "idnv";
            this.idnv.Size = new System.Drawing.Size(56, 24);
            this.idnv.TabIndex = 46;
            this.idnv.SelectionChangeCommitted += new System.EventHandler(this.idnv_SelectionChangeCommitted);
            // 
            // tennv
            // 
            this.tennv.Location = new System.Drawing.Point(263, 55);
            this.tennv.Name = "tennv";
            this.tennv.Size = new System.Drawing.Size(127, 22);
            this.tennv.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(137, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 47;
            this.label4.Text = "Tên nhân viên";
            // 
            // songaylv
            // 
            this.songaylv.Location = new System.Drawing.Point(752, 12);
            this.songaylv.Name = "songaylv";
            this.songaylv.Size = new System.Drawing.Size(86, 22);
            this.songaylv.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(610, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 17);
            this.label5.TabIndex = 49;
            this.label5.Text = "Số ngày làm việc";
            // 
            // ngaysinh
            // 
            this.ngaysinh.Location = new System.Drawing.Point(263, 103);
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Size = new System.Drawing.Size(200, 22);
            this.ngaysinh.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(162, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 54;
            this.label6.Text = "Ngày sinh";
            // 
            // songaylt
            // 
            this.songaylt.Location = new System.Drawing.Point(752, 54);
            this.songaylt.Name = "songaylt";
            this.songaylt.Size = new System.Drawing.Size(86, 22);
            this.songaylt.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(610, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 17);
            this.label7.TabIndex = 55;
            this.label7.Text = "Số ngày làm thêm";
            // 
            // sogiotc
            // 
            this.sogiotc.Location = new System.Drawing.Point(752, 98);
            this.sogiotc.Name = "sogiotc";
            this.sogiotc.Size = new System.Drawing.Size(86, 22);
            this.sogiotc.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(624, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 17);
            this.label8.TabIndex = 57;
            this.label8.Text = "Số giờ tăng ca";
            // 
            // solanditre
            // 
            this.solanditre.Location = new System.Drawing.Point(752, 148);
            this.solanditre.Name = "solanditre";
            this.solanditre.Size = new System.Drawing.Size(86, 22);
            this.solanditre.TabIndex = 60;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(641, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 17);
            this.label9.TabIndex = 59;
            this.label9.Text = "Số lần đi trễ";
            // 
            // tbx_nv
            // 
            this.tbx_nv.Location = new System.Drawing.Point(126, 294);
            this.tbx_nv.Name = "tbx_nv";
            this.tbx_nv.Size = new System.Drawing.Size(247, 22);
            this.tbx_nv.TabIndex = 61;
            this.tbx_nv.TextChanged += new System.EventHandler(this.tbx_nv_TextChanged);
            // 
            // maluong
            // 
            this.maluong.FormattingEnabled = true;
            this.maluong.Location = new System.Drawing.Point(974, 150);
            this.maluong.Name = "maluong";
            this.maluong.Size = new System.Drawing.Size(56, 24);
            this.maluong.TabIndex = 63;
            this.maluong.SelectedIndexChanged += new System.EventHandler(this.maluong_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(894, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 62;
            this.label1.Text = "Mã lương";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(319, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 17);
            this.label10.TabIndex = 65;
            this.label10.Text = "Năm";
            // 
            // nam
            // 
            this.nam.FormattingEnabled = true;
            this.nam.Items.AddRange(new object[] {
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
            this.nam.Location = new System.Drawing.Point(374, 186);
            this.nam.Name = "nam";
            this.nam.Size = new System.Drawing.Size(72, 24);
            this.nam.TabIndex = 64;
            // 
            // SearchNV
            // 
            this.SearchNV.BackgroundImage = global::PayrollManagement.Properties.Resources.Imgsearch;
            this.SearchNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchNV.ErrorImage = null;
            this.SearchNV.Location = new System.Drawing.Point(69, 281);
            this.SearchNV.Name = "SearchNV";
            this.SearchNV.Size = new System.Drawing.Size(40, 35);
            this.SearchNV.TabIndex = 66;
            this.SearchNV.TabStop = false;
            // 
            // ChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1370, 782);
            this.Controls.Add(this.SearchNV);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nam);
            this.Controls.Add(this.maluong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_nv);
            this.Controls.Add(this.solanditre);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.sogiotc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.songaylt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ngaysinh);
            this.Controls.Add(this.songaylv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tennv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idnv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.thang);
            this.Controls.Add(this.CCview);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChamCong";
            this.Text = "ChamCong";
            this.Load += new System.EventHandler(this.ChamCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CCview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView CCview;
        private System.Windows.Forms.ComboBox thang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox idnv;
        private System.Windows.Forms.TextBox tennv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox songaylv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker ngaysinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox songaylt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox sogiotc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox solanditre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbx_nv;
        private System.Windows.Forms.ComboBox maluong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox nam;
        private System.Windows.Forms.PictureBox SearchNV;
    }
}