
namespace PayrollManagement
{
    partial class HopDong
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
            this.viewhd = new System.Windows.Forms.DataGridView();
            this.addBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tenhd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.thoihan = new System.Windows.Forms.TextBox();
            this.mahd = new System.Windows.Forms.ComboBox();
            this.loaihd = new System.Windows.Forms.ComboBox();
            this.SearchNV = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.viewhd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchNV)).BeginInit();
            this.SuspendLayout();
            // 
            // viewhd
            // 
            this.viewhd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewhd.Location = new System.Drawing.Point(54, 290);
            this.viewhd.Name = "viewhd";
            this.viewhd.RowHeadersWidth = 51;
            this.viewhd.RowTemplate.Height = 24;
            this.viewhd.Size = new System.Drawing.Size(794, 349);
            this.viewhd.TabIndex = 54;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Silver;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.addBtn.Location = new System.Drawing.Point(254, 168);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(122, 45);
            this.addBtn.TabIndex = 53;
            this.addBtn.Text = "Thêm";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(49, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 52;
            this.label2.Text = "Tên hợp đồng";
            // 
            // tenhd
            // 
            this.tenhd.Location = new System.Drawing.Point(174, 42);
            this.tenhd.Name = "tenhd";
            this.tenhd.Size = new System.Drawing.Size(221, 22);
            this.tenhd.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(467, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 50;
            this.label1.Text = "Mã hợp đồng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(49, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 56;
            this.label3.Text = "Loại hợp đồng";
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.Silver;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.updateBtn.Location = new System.Drawing.Point(453, 168);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(122, 45);
            this.updateBtn.TabIndex = 57;
            this.updateBtn.Text = "Chỉnh Sửa";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.BackColor = System.Drawing.Color.Silver;
            this.delBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.delBtn.Location = new System.Drawing.Point(581, 168);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(122, 45);
            this.delBtn.TabIndex = 58;
            this.delBtn.Text = "Xóa";
            this.delBtn.UseVisualStyleBackColor = false;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(67, 248);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(146, 22);
            this.textBox2.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(49, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 61;
            this.label4.Text = "Thời hạn";
            // 
            // thoihan
            // 
            this.thoihan.Location = new System.Drawing.Point(174, 124);
            this.thoihan.Name = "thoihan";
            this.thoihan.Size = new System.Drawing.Size(221, 22);
            this.thoihan.TabIndex = 60;
            // 
            // mahd
            // 
            this.mahd.FormattingEnabled = true;
            this.mahd.Location = new System.Drawing.Point(581, 42);
            this.mahd.Name = "mahd";
            this.mahd.Size = new System.Drawing.Size(79, 24);
            this.mahd.TabIndex = 62;
            this.mahd.SelectionChangeCommitted += new System.EventHandler(this.mahd_SelectionChangeCommitted);
            // 
            // loaihd
            // 
            this.loaihd.FormattingEnabled = true;
            this.loaihd.Items.AddRange(new object[] {
            "tháng",
            "năm"});
            this.loaihd.Location = new System.Drawing.Point(174, 81);
            this.loaihd.Name = "loaihd";
            this.loaihd.Size = new System.Drawing.Size(79, 24);
            this.loaihd.TabIndex = 63;
            // 
            // SearchNV
            // 
            this.SearchNV.BackgroundImage = global::PayrollManagement.Properties.Resources.Imgsearch;
            this.SearchNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchNV.ErrorImage = null;
            this.SearchNV.Location = new System.Drawing.Point(26, 248);
            this.SearchNV.Name = "SearchNV";
            this.SearchNV.Size = new System.Drawing.Size(26, 22);
            this.SearchNV.TabIndex = 64;
            this.SearchNV.TabStop = false;
            // 
            // HopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 782);
            this.Controls.Add(this.SearchNV);
            this.Controls.Add(this.loaihd);
            this.Controls.Add(this.mahd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.thoihan);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.viewhd);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tenhd);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HopDong";
            this.Text = "HopDong";
            this.Load += new System.EventHandler(this.HopDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewhd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView viewhd;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tenhd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox thoihan;
        private System.Windows.Forms.ComboBox mahd;
        private System.Windows.Forms.ComboBox loaihd;
        private System.Windows.Forms.PictureBox SearchNV;
    }
}