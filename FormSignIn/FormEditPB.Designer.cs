namespace FormSignIn
{
    partial class FormEditPB
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtEditDiaChi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEditTenPB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEditMaPB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(310, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 32);
            this.label4.TabIndex = 25;
            this.label4.Text = "Nhập thông tin";
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Location = new System.Drawing.Point(459, 392);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(162, 57);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(252, 392);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(162, 57);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtEditDiaChi
            // 
            this.txtEditDiaChi.Location = new System.Drawing.Point(353, 285);
            this.txtEditDiaChi.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.txtEditDiaChi.Name = "txtEditDiaChi";
            this.txtEditDiaChi.Size = new System.Drawing.Size(331, 27);
            this.txtEditDiaChi.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "Địa Chỉ";
            // 
            // txtEditTenPB
            // 
            this.txtEditTenPB.Location = new System.Drawing.Point(353, 220);
            this.txtEditTenPB.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.txtEditTenPB.Name = "txtEditTenPB";
            this.txtEditTenPB.Size = new System.Drawing.Size(331, 27);
            this.txtEditTenPB.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tên Phòng Ban";
            // 
            // txtEditMaPB
            // 
            this.txtEditMaPB.Location = new System.Drawing.Point(353, 152);
            this.txtEditMaPB.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.txtEditMaPB.Name = "txtEditMaPB";
            this.txtEditMaPB.Size = new System.Drawing.Size(331, 27);
            this.txtEditMaPB.TabIndex = 18;
            this.txtEditMaPB.TextChanged += new System.EventHandler(this.txtEditMaPB_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Mã Phòng Ban";
            // 
            // FormEditPB
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 534);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtEditDiaChi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEditTenPB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEditMaPB);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormEditPB";
            this.Text = "Sửa thông tin Phòng Ban";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtEditDiaChi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEditTenPB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEditMaPB;
        private System.Windows.Forms.Label label3;
    }
}