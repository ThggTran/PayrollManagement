
namespace PayrollManagement
{
    partial class NhanVien
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
            this.nhanvienView = new System.Windows.Forms.DataGridView();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.ReloadImg = new System.Windows.Forms.PictureBox();
            this.SearchNV = new System.Windows.Forms.PictureBox();
            this.chucvuTxt = new System.Windows.Forms.ComboBox();
            this.ttt = new System.Windows.Forms.Label();
            this.tttt = new System.Windows.Forms.Label();
            this.trinhdoTxt = new System.Windows.Forms.ComboBox();
            this.pbTxt = new System.Windows.Forms.ComboBox();
            this.uu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReloadImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchNV)).BeginInit();
            this.SuspendLayout();
            // 
            // nhanvienView
            // 
            this.nhanvienView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nhanvienView.Location = new System.Drawing.Point(20, 76);
            this.nhanvienView.Name = "nhanvienView";
            this.nhanvienView.RowHeadersWidth = 51;
            this.nhanvienView.RowTemplate.Height = 24;
            this.nhanvienView.Size = new System.Drawing.Size(1338, 547);
            this.nhanvienView.TabIndex = 0;
            this.nhanvienView.SelectionChanged += new System.EventHandler(this.nhanvienView_SelectionChanged);
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(94, 27);
            this.searchTxt.Multiline = true;
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(258, 29);
            this.searchTxt.TabIndex = 4;
            this.searchTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.Silver;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Sua.Location = new System.Drawing.Point(520, 14);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(163, 45);
            this.btn_Sua.TabIndex = 31;
            this.btn_Sua.Text = "Chỉnh sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.themnvBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Xoa);
            this.panel1.Controls.Add(this.btn_them);
            this.panel1.Controls.Add(this.btn_Sua);
            this.panel1.Location = new System.Drawing.Point(114, 657);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1130, 88);
            this.panel1.TabIndex = 36;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.Silver;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Xoa.Location = new System.Drawing.Point(882, 14);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(122, 45);
            this.btn_Xoa.TabIndex = 33;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.Silver;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_them.Location = new System.Drawing.Point(131, 14);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(122, 45);
            this.btn_them.TabIndex = 32;
            this.btn_them.Text = "Thêm ";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // ReloadImg
            // 
            this.ReloadImg.BackgroundImage = global::PayrollManagement.Properties.Resources.ImgLoadbtn;
            this.ReloadImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReloadImg.Location = new System.Drawing.Point(370, 26);
            this.ReloadImg.Name = "ReloadImg";
            this.ReloadImg.Size = new System.Drawing.Size(32, 30);
            this.ReloadImg.TabIndex = 35;
            this.ReloadImg.TabStop = false;
            this.ReloadImg.Click += new System.EventHandler(this.ReloadImg_Click);
            // 
            // SearchNV
            // 
            this.SearchNV.BackgroundImage = global::PayrollManagement.Properties.Resources.Imgsearch;
            this.SearchNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchNV.ErrorImage = null;
            this.SearchNV.Location = new System.Drawing.Point(45, 27);
            this.SearchNV.Name = "SearchNV";
            this.SearchNV.Size = new System.Drawing.Size(32, 29);
            this.SearchNV.TabIndex = 34;
            this.SearchNV.TabStop = false;
            // 
            // chucvuTxt
            // 
            this.chucvuTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chucvuTxt.FormattingEnabled = true;
            this.chucvuTxt.Location = new System.Drawing.Point(607, 27);
            this.chucvuTxt.Name = "chucvuTxt";
            this.chucvuTxt.Size = new System.Drawing.Size(167, 24);
            this.chucvuTxt.TabIndex = 110;
            this.chucvuTxt.SelectedIndexChanged += new System.EventHandler(this.chucvuTxt_SelectedIndexChanged);
            // 
            // ttt
            // 
            this.ttt.AutoSize = true;
            this.ttt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ttt.Location = new System.Drawing.Point(530, 35);
            this.ttt.Name = "ttt";
            this.ttt.Size = new System.Drawing.Size(71, 17);
            this.ttt.TabIndex = 108;
            this.ttt.Text = "Chức vụ:";
            // 
            // tttt
            // 
            this.tttt.AutoSize = true;
            this.tttt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tttt.Location = new System.Drawing.Point(798, 35);
            this.tttt.Name = "tttt";
            this.tttt.Size = new System.Drawing.Size(74, 17);
            this.tttt.TabIndex = 109;
            this.tttt.Text = "Trình độ:";
            // 
            // trinhdoTxt
            // 
            this.trinhdoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.trinhdoTxt.FormattingEnabled = true;
            this.trinhdoTxt.Location = new System.Drawing.Point(878, 28);
            this.trinhdoTxt.Name = "trinhdoTxt";
            this.trinhdoTxt.Size = new System.Drawing.Size(164, 24);
            this.trinhdoTxt.TabIndex = 111;
            this.trinhdoTxt.SelectedIndexChanged += new System.EventHandler(this.trinhdoTxt_SelectedIndexChanged);
            // 
            // pbTxt
            // 
            this.pbTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.pbTxt.FormattingEnabled = true;
            this.pbTxt.Location = new System.Drawing.Point(1160, 26);
            this.pbTxt.Name = "pbTxt";
            this.pbTxt.Size = new System.Drawing.Size(170, 24);
            this.pbTxt.TabIndex = 113;
            this.pbTxt.SelectedIndexChanged += new System.EventHandler(this.pbTxt_SelectedIndexChanged);
            // 
            // uu
            // 
            this.uu.AutoSize = true;
            this.uu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uu.Location = new System.Drawing.Point(1063, 33);
            this.uu.Name = "uu";
            this.uu.Size = new System.Drawing.Size(91, 17);
            this.uu.TabIndex = 112;
            this.uu.Text = "Phòng ban:";
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 782);
            this.Controls.Add(this.chucvuTxt);
            this.Controls.Add(this.ttt);
            this.Controls.Add(this.tttt);
            this.Controls.Add(this.trinhdoTxt);
            this.Controls.Add(this.pbTxt);
            this.Controls.Add(this.uu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ReloadImg);
            this.Controls.Add(this.SearchNV);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.nhanvienView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienView)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReloadImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView nhanvienView;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.PictureBox SearchNV;
        private System.Windows.Forms.PictureBox ReloadImg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.ComboBox chucvuTxt;
        private System.Windows.Forms.Label ttt;
        private System.Windows.Forms.Label tttt;
        private System.Windows.Forms.ComboBox trinhdoTxt;
        private System.Windows.Forms.ComboBox pbTxt;
        private System.Windows.Forms.Label uu;
    }
}