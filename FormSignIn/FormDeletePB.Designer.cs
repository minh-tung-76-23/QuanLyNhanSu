namespace FormSignIn
{
    partial class FormDeletePB
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDeletePB = new System.Windows.Forms.Button();
            this.txtDeleteMaPB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(388, 228);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(172, 55);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDeletePB
            // 
            this.btnDeletePB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletePB.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePB.Location = new System.Drawing.Point(161, 228);
            this.btnDeletePB.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnDeletePB.Name = "btnDeletePB";
            this.btnDeletePB.Size = new System.Drawing.Size(164, 55);
            this.btnDeletePB.TabIndex = 12;
            this.btnDeletePB.Text = "Xóa";
            this.btnDeletePB.UseVisualStyleBackColor = true;
            this.btnDeletePB.Click += new System.EventHandler(this.btnDeletePB_Click);
            // 
            // txtDeleteMaPB
            // 
            this.txtDeleteMaPB.Location = new System.Drawing.Point(323, 134);
            this.txtDeleteMaPB.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtDeleteMaPB.Name = "txtDeleteMaPB";
            this.txtDeleteMaPB.Size = new System.Drawing.Size(295, 27);
            this.txtDeleteMaPB.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nhập Mã Phòng Ban";
            // 
            // FormDeletePB
            // 
            this.AcceptButton = this.btnDeletePB;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 407);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDeletePB);
            this.Controls.Add(this.txtDeleteMaPB);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormDeletePB";
            this.Text = "Xóa Phòng Ban";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDeletePB;
        private System.Windows.Forms.TextBox txtDeleteMaPB;
        private System.Windows.Forms.Label label3;
    }
}