
namespace PayrollManagement
{
    partial class TrinhDo
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
            this.idtd = new System.Windows.Forms.ComboBox();
            this.ViewTD = new System.Windows.Forms.DataGridView();
            this.delBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.tentd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ViewTD)).BeginInit();
            this.SuspendLayout();
            // 
            // idtd
            // 
            this.idtd.FormattingEnabled = true;
            this.idtd.Location = new System.Drawing.Point(627, 51);
            this.idtd.Name = "idtd";
            this.idtd.Size = new System.Drawing.Size(65, 24);
            this.idtd.TabIndex = 45;
            this.idtd.SelectionChangeCommitted += new System.EventHandler(this.idtd_SelectionChangeCommitted);
            // 
            // ViewTD
            // 
            this.ViewTD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewTD.Location = new System.Drawing.Point(82, 211);
            this.ViewTD.Name = "ViewTD";
            this.ViewTD.RowHeadersWidth = 51;
            this.ViewTD.RowTemplate.Height = 24;
            this.ViewTD.Size = new System.Drawing.Size(556, 372);
            this.ViewTD.TabIndex = 44;
            // 
            // delBtn
            // 
            this.delBtn.BackColor = System.Drawing.Color.Silver;
            this.delBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.delBtn.Location = new System.Drawing.Point(508, 105);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(90, 45);
            this.delBtn.TabIndex = 43;
            this.delBtn.Text = "Xóa";
            this.delBtn.UseVisualStyleBackColor = false;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Silver;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.addBtn.Location = new System.Drawing.Point(230, 105);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(139, 45);
            this.addBtn.TabIndex = 42;
            this.addBtn.Text = "Thêm";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.Silver;
            this.editBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.editBtn.Location = new System.Drawing.Point(627, 105);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(139, 45);
            this.editBtn.TabIndex = 41;
            this.editBtn.Text = "Chỉnh sửa";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // tentd
            // 
            this.tentd.Location = new System.Drawing.Point(176, 55);
            this.tentd.Name = "tentd";
            this.tentd.Size = new System.Drawing.Size(193, 22);
            this.tentd.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(74, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "Tên trình độ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(522, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Mã trình độ";
            // 
            // TrinhDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 782);
            this.Controls.Add(this.idtd);
            this.Controls.Add(this.ViewTD);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.tentd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TrinhDo";
            this.Text = "TrinhDo";
            this.Load += new System.EventHandler(this.TrinhDo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewTD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox idtd;
        private System.Windows.Forms.DataGridView ViewTD;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.TextBox tentd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}