namespace PayrollManagement
{
    partial class formNhanvienLogin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.getID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.gioitinhTxt = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tenTxt = new System.Windows.Forms.TextBox();
            this.sdtTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.dateTxt = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.pqTxt = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.kyhdTxt = new System.Windows.Forms.DateTimePicker();
            this.hslTxt = new System.Windows.Forms.TextBox();
            this.luongcbTxt = new System.Windows.Forms.TextBox();
            this.CCview = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.chucvuTxt = new System.Windows.Forms.ComboBox();
            this.trinhdoTxt = new System.Windows.Forms.ComboBox();
            this.pbTxt = new System.Windows.Forms.ComboBox();
            this.hopdongTxt = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.RichDesHDNVtxt = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CCview)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.getID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.gioitinhTxt);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.tenTxt);
            this.groupBox1.Controls.Add(this.sdtTxt);
            this.groupBox1.Controls.Add(this.emailTxt);
            this.groupBox1.Controls.Add(this.dateTxt);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1232, 138);
            this.groupBox1.TabIndex = 130;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin cá nhân";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // getID
            // 
            this.getID.FormattingEnabled = true;
            this.getID.Location = new System.Drawing.Point(1109, 39);
            this.getID.Name = "getID";
            this.getID.Size = new System.Drawing.Size(123, 23);
            this.getID.TabIndex = 109;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1134, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 110;
            this.label3.Text = "(Mã nhân viên)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(37, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 17);
            this.label14.TabIndex = 113;
            this.label14.Text = "Họ và tên:";
            // 
            // gioitinhTxt
            // 
            this.gioitinhTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.gioitinhTxt.FormattingEnabled = true;
            this.gioitinhTxt.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.gioitinhTxt.Location = new System.Drawing.Point(559, 33);
            this.gioitinhTxt.Name = "gioitinhTxt";
            this.gioitinhTxt.Size = new System.Drawing.Size(77, 24);
            this.gioitinhTxt.TabIndex = 86;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(703, 80);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 17);
            this.label15.TabIndex = 115;
            this.label15.Text = "Số điện thoại:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(747, 38);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 17);
            this.label16.TabIndex = 116;
            this.label16.Text = "Email:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(485, 33);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 17);
            this.label17.TabIndex = 117;
            this.label17.Text = "Giới tính:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(37, 80);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 17);
            this.label18.TabIndex = 114;
            this.label18.Text = "Ngày sinh:";
            // 
            // tenTxt
            // 
            this.tenTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenTxt.Location = new System.Drawing.Point(139, 33);
            this.tenTxt.Name = "tenTxt";
            this.tenTxt.Size = new System.Drawing.Size(221, 22);
            this.tenTxt.TabIndex = 35;
            // 
            // sdtTxt
            // 
            this.sdtTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.sdtTxt.Location = new System.Drawing.Point(815, 82);
            this.sdtTxt.Name = "sdtTxt";
            this.sdtTxt.Size = new System.Drawing.Size(268, 22);
            this.sdtTxt.TabIndex = 39;
            // 
            // emailTxt
            // 
            this.emailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.emailTxt.Location = new System.Drawing.Point(815, 38);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(268, 22);
            this.emailTxt.TabIndex = 43;
            // 
            // dateTxt
            // 
            this.dateTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.dateTxt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTxt.Location = new System.Drawing.Point(139, 80);
            this.dateTxt.Name = "dateTxt";
            this.dateTxt.Size = new System.Drawing.Size(221, 22);
            this.dateTxt.TabIndex = 47;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.usernameTxt);
            this.groupBox2.Controls.Add(this.passTxt);
            this.groupBox2.Controls.Add(this.pqTxt);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(538, 161);
            this.groupBox2.TabIndex = 131;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin tài khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 98;
            this.label2.Text = "Tên tài khoản:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 100;
            this.label5.Text = "Mật khẩu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 108;
            this.label7.Text = "Phân quyền:";
            // 
            // usernameTxt
            // 
            this.usernameTxt.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxt.Location = new System.Drawing.Point(139, 39);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(221, 22);
            this.usernameTxt.TabIndex = 52;
            // 
            // passTxt
            // 
            this.passTxt.Font = new System.Drawing.Font("Times New Roman", 7.8F);
            this.passTxt.Location = new System.Drawing.Point(139, 77);
            this.passTxt.Name = "passTxt";
            this.passTxt.Size = new System.Drawing.Size(221, 22);
            this.passTxt.TabIndex = 54;
            // 
            // pqTxt
            // 
            this.pqTxt.Font = new System.Drawing.Font("Times New Roman", 7.8F);
            this.pqTxt.FormattingEnabled = true;
            this.pqTxt.Items.AddRange(new object[] {
            "0",
            "1"});
            this.pqTxt.Location = new System.Drawing.Point(139, 111);
            this.pqTxt.Name = "pqTxt";
            this.pqTxt.Size = new System.Drawing.Size(72, 23);
            this.pqTxt.TabIndex = 79;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.kyhdTxt);
            this.groupBox3.Controls.Add(this.hslTxt);
            this.groupBox3.Controls.Add(this.luongcbTxt);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(556, 156);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(688, 161);
            this.groupBox3.TabIndex = 132;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin hợp đồng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 101;
            this.label4.Text = "Ngày ký hợp đồng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 103;
            this.label6.Text = "Hệ số lương:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 17);
            this.label8.TabIndex = 105;
            this.label8.Text = "Lương cơ bản:";
            // 
            // kyhdTxt
            // 
            this.kyhdTxt.Font = new System.Drawing.Font("Times New Roman", 7.8F);
            this.kyhdTxt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.kyhdTxt.Location = new System.Drawing.Point(210, 44);
            this.kyhdTxt.Name = "kyhdTxt";
            this.kyhdTxt.Size = new System.Drawing.Size(190, 22);
            this.kyhdTxt.TabIndex = 57;
            // 
            // hslTxt
            // 
            this.hslTxt.Font = new System.Drawing.Font("Times New Roman", 7.8F);
            this.hslTxt.Location = new System.Drawing.Point(148, 82);
            this.hslTxt.Name = "hslTxt";
            this.hslTxt.Size = new System.Drawing.Size(48, 22);
            this.hslTxt.TabIndex = 83;
            // 
            // luongcbTxt
            // 
            this.luongcbTxt.Font = new System.Drawing.Font("Times New Roman", 7.8F);
            this.luongcbTxt.Location = new System.Drawing.Point(162, 122);
            this.luongcbTxt.Name = "luongcbTxt";
            this.luongcbTxt.Size = new System.Drawing.Size(238, 22);
            this.luongcbTxt.TabIndex = 62;
            // 
            // CCview
            // 
            this.CCview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CCview.Location = new System.Drawing.Point(0, 27);
            this.CCview.Name = "CCview";
            this.CCview.RowHeadersWidth = 51;
            this.CCview.RowTemplate.Height = 24;
            this.CCview.Size = new System.Drawing.Size(1319, 182);
            this.CCview.TabIndex = 133;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.CCview);
            this.groupBox5.Location = new System.Drawing.Point(10, 570);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1324, 216);
            this.groupBox5.TabIndex = 134;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thông tin lương";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(22, 125);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(77, 17);
            this.label23.TabIndex = 106;
            this.label23.Text = "Phòng ban:";
            // 
            // chucvuTxt
            // 
            this.chucvuTxt.FormattingEnabled = true;
            this.chucvuTxt.Location = new System.Drawing.Point(108, 40);
            this.chucvuTxt.Name = "chucvuTxt";
            this.chucvuTxt.Size = new System.Drawing.Size(193, 23);
            this.chucvuTxt.TabIndex = 48;
            // 
            // trinhdoTxt
            // 
            this.trinhdoTxt.FormattingEnabled = true;
            this.trinhdoTxt.Location = new System.Drawing.Point(108, 80);
            this.trinhdoTxt.Name = "trinhdoTxt";
            this.trinhdoTxt.Size = new System.Drawing.Size(193, 23);
            this.trinhdoTxt.TabIndex = 49;
            // 
            // pbTxt
            // 
            this.pbTxt.FormattingEnabled = true;
            this.pbTxt.Location = new System.Drawing.Point(108, 125);
            this.pbTxt.Name = "pbTxt";
            this.pbTxt.Size = new System.Drawing.Size(193, 23);
            this.pbTxt.TabIndex = 65;
            // 
            // hopdongTxt
            // 
            this.hopdongTxt.FormattingEnabled = true;
            this.hopdongTxt.Location = new System.Drawing.Point(706, 12);
            this.hopdongTxt.Name = "hopdongTxt";
            this.hopdongTxt.Size = new System.Drawing.Size(72, 23);
            this.hopdongTxt.TabIndex = 69;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(22, 80);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(64, 17);
            this.label21.TabIndex = 93;
            this.label21.Text = "Trình độ:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(22, 40);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 17);
            this.label20.TabIndex = 92;
            this.label20.Text = "Chức vụ:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(585, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 17);
            this.label10.TabIndex = 120;
            this.label10.Text = "Mã hợp đồng:";
            // 
            // RichDesHDNVtxt
            // 
            this.RichDesHDNVtxt.Location = new System.Drawing.Point(548, 63);
            this.RichDesHDNVtxt.Name = "RichDesHDNVtxt";
            this.RichDesHDNVtxt.Size = new System.Drawing.Size(396, 85);
            this.RichDesHDNVtxt.TabIndex = 122;
            this.RichDesHDNVtxt.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.RichDesHDNVtxt);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.hopdongTxt);
            this.groupBox4.Controls.Add(this.pbTxt);
            this.groupBox4.Controls.Add(this.trinhdoTxt);
            this.groupBox4.Controls.Add(this.chucvuTxt);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 323);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1232, 226);
            this.groupBox4.TabIndex = 129;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin công việc:";
            // 
            // formNhanvienLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 791);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Name = "formNhanvienLogin";
            this.Text = "formNhanvienLogin";
            this.Load += new System.EventHandler(this.formNhanvienLogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CCview)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox gioitinhTxt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tenTxt;
        private System.Windows.Forms.TextBox sdtTxt;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.DateTimePicker dateTxt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.TextBox passTxt;
        private System.Windows.Forms.ComboBox pqTxt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker kyhdTxt;
        private System.Windows.Forms.TextBox hslTxt;
        private System.Windows.Forms.TextBox luongcbTxt;
        private System.Windows.Forms.DataGridView CCview;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox getID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox chucvuTxt;
        private System.Windows.Forms.ComboBox trinhdoTxt;
        private System.Windows.Forms.ComboBox pbTxt;
        private System.Windows.Forms.ComboBox hopdongTxt;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox RichDesHDNVtxt;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}