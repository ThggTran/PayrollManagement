
namespace PayrollManagement
{
    partial class PhongBan
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
            this.tenpb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ViewPB = new System.Windows.Forms.DataGridView();
            this.idpb = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SearchNV = new System.Windows.Forms.PictureBox();
            this.searchPBTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ViewPB)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchNV)).BeginInit();
            this.SuspendLayout();
            // 
            // delBtn
            // 
            this.delBtn.BackColor = System.Drawing.Color.Silver;
            this.delBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.delBtn.Location = new System.Drawing.Point(176, 67);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(90, 45);
            this.delBtn.TabIndex = 24;
            this.delBtn.Text = "Xóa";
            this.delBtn.UseVisualStyleBackColor = false;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Silver;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.addBtn.Location = new System.Drawing.Point(68, 67);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(90, 45);
            this.addBtn.TabIndex = 23;
            this.addBtn.Text = "Thêm";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.Silver;
            this.editBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.editBtn.Location = new System.Drawing.Point(282, 67);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(90, 45);
            this.editBtn.TabIndex = 22;
            this.editBtn.Text = "Sửa";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // tenpb
            // 
            this.tenpb.Location = new System.Drawing.Point(173, 107);
            this.tenpb.Name = "tenpb";
            this.tenpb.Size = new System.Drawing.Size(237, 22);
            this.tenpb.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(41, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tên phòng ban:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(41, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã phòng ban:";
            // 
            // ViewPB
            // 
            this.ViewPB.AllowUserToOrderColumns = true;
            this.ViewPB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewPB.Location = new System.Drawing.Point(18, 129);
            this.ViewPB.Name = "ViewPB";
            this.ViewPB.RowHeadersWidth = 51;
            this.ViewPB.RowTemplate.Height = 24;
            this.ViewPB.Size = new System.Drawing.Size(478, 372);
            this.ViewPB.TabIndex = 27;
            this.ViewPB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewPB_CellContentClick);
            // 
            // idpb
            // 
            this.idpb.FormattingEnabled = true;
            this.idpb.Location = new System.Drawing.Point(176, 48);
            this.idpb.Name = "idpb";
            this.idpb.Size = new System.Drawing.Size(65, 24);
            this.idpb.TabIndex = 29;
            this.idpb.SelectedIndexChanged += new System.EventHandler(this.idpb_SelectedIndexChanged);
            this.idpb.SelectionChangeCommitted += new System.EventHandler(this.idpb_SelectionChangeCommitted);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.delBtn);
            this.panel1.Controls.Add(this.editBtn);
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Location = new System.Drawing.Point(607, 299);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 190);
            this.panel1.TabIndex = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.idpb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tenpb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(607, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 149);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết: ";
            // 
            // SearchNV
            // 
            this.SearchNV.BackgroundImage = global::PayrollManagement.Properties.Resources.Imgsearch;
            this.SearchNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchNV.ErrorImage = null;
            this.SearchNV.Location = new System.Drawing.Point(18, 63);
            this.SearchNV.Name = "SearchNV";
            this.SearchNV.Size = new System.Drawing.Size(40, 29);
            this.SearchNV.TabIndex = 35;
            this.SearchNV.TabStop = false;
            // 
            // searchPBTxt
            // 
            this.searchPBTxt.Location = new System.Drawing.Point(64, 63);
            this.searchPBTxt.Multiline = true;
            this.searchPBTxt.Name = "searchPBTxt";
            this.searchPBTxt.Size = new System.Drawing.Size(241, 29);
            this.searchPBTxt.TabIndex = 36;
            this.searchPBTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
            // 
            // PhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 782);
            this.Controls.Add(this.searchPBTxt);
            this.Controls.Add(this.SearchNV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ViewPB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PhongBan";
            this.Text = "PhongBan";
            this.Load += new System.EventHandler(this.PhongBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewPB)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.TextBox tenpb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ViewPB;
        private System.Windows.Forms.ComboBox idpb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox SearchNV;
        private System.Windows.Forms.TextBox searchPBTxt;
    }
}