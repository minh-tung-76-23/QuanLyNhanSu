namespace FormSignIn
{
    partial class FormDeleteStaff
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
            this.txtDeleteMaNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDeleteNV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDeleteMaNV
            // 
            this.txtDeleteMaNV.Location = new System.Drawing.Point(254, 84);
            this.txtDeleteMaNV.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtDeleteMaNV.Name = "txtDeleteMaNV";
            this.txtDeleteMaNV.Size = new System.Drawing.Size(263, 27);
            this.txtDeleteMaNV.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nhập Mã Nhân Viên";
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(312, 163);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(153, 46);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDeleteNV
            // 
            this.btnDeleteNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteNV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteNV.Location = new System.Drawing.Point(110, 163);
            this.btnDeleteNV.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnDeleteNV.Name = "btnDeleteNV";
            this.btnDeleteNV.Size = new System.Drawing.Size(146, 46);
            this.btnDeleteNV.TabIndex = 8;
            this.btnDeleteNV.Text = "Xóa";
            this.btnDeleteNV.UseVisualStyleBackColor = true;
            this.btnDeleteNV.Click += new System.EventHandler(this.btnDeleteNV_Click);
            // 
            // FormDeleteStaff
            // 
            this.AcceptButton = this.btnDeleteNV;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 289);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDeleteNV);
            this.Controls.Add(this.txtDeleteMaNV);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormDeleteStaff";
            this.Text = "Xóa thông tin nhân viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDeleteMaNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDeleteNV;
    }
}