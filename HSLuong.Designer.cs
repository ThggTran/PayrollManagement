
namespace PayrollManagement
{
    partial class HSLuong
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
            this.gv_HSL = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gv_HSL)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_HSL
            // 
            this.gv_HSL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_HSL.Location = new System.Drawing.Point(53, 116);
            this.gv_HSL.Name = "gv_HSL";
            this.gv_HSL.RowHeadersWidth = 51;
            this.gv_HSL.RowTemplate.Height = 24;
            this.gv_HSL.Size = new System.Drawing.Size(631, 253);
            this.gv_HSL.TabIndex = 0;
            // 
            // HSLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 782);
            this.Controls.Add(this.gv_HSL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HSLuong";
            this.Text = "HSLuong";
            this.Load += new System.EventHandler(this.HSLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_HSL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_HSL;
    }
}