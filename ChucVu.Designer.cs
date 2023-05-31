
namespace PayrollManagement
{
    partial class ChucVu
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
            this.idcv = new System.Windows.Forms.ComboBox();
            this.ViewCV = new System.Windows.Forms.DataGridView();
            this.delBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.tencv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ViewCV)).BeginInit();
            this.SuspendLayout();
            // 
            // idcv
            // 
            this.idcv.FormattingEnabled = true;
            this.idcv.Location = new System.Drawing.Point(619, 50);
            this.idcv.Name = "idcv";
            this.idcv.Size = new System.Drawing.Size(65, 24);
            this.idcv.TabIndex = 37;
            this.idcv.SelectionChangeCommitted += new System.EventHandler(this.idcv_SelectionChangeCommitted);
            // 
            // ViewCV
            // 
            this.ViewCV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewCV.Location = new System.Drawing.Point(59, 189);
            this.ViewCV.Name = "ViewCV";
            this.ViewCV.RowHeadersWidth = 51;
            this.ViewCV.RowTemplate.Height = 24;
            this.ViewCV.Size = new System.Drawing.Size(554, 372);
            this.ViewCV.TabIndex = 36;
            // 
            // delBtn
            // 
            this.delBtn.BackColor = System.Drawing.Color.Silver;
            this.delBtn.FlatAppearance.BorderSize = 0;
            this.delBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.delBtn.Location = new System.Drawing.Point(500, 104);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(90, 45);
            this.delBtn.TabIndex = 35;
            this.delBtn.Text = "Xóa";
            this.delBtn.UseVisualStyleBackColor = false;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Silver;
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.addBtn.Location = new System.Drawing.Point(267, 104);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(139, 45);
            this.addBtn.TabIndex = 34;
            this.addBtn.Text = "Thêm";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.Silver;
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.editBtn.Location = new System.Drawing.Point(619, 104);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(139, 45);
            this.editBtn.TabIndex = 33;
            this.editBtn.Text = "Chỉnh sửa";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // tencv
            // 
            this.tencv.Location = new System.Drawing.Point(213, 46);
            this.tencv.Name = "tencv";
            this.tencv.Size = new System.Drawing.Size(193, 22);
            this.tencv.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(111, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Tên chức vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(514, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Mã chức vụ";
            // 
            // ChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 782);
            this.Controls.Add(this.idcv);
            this.Controls.Add(this.ViewCV);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.tencv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChucVu";
            this.Text = "ChucVu";
            this.Load += new System.EventHandler(this.ChucVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewCV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox idcv;
        private System.Windows.Forms.DataGridView ViewCV;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.TextBox tencv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}