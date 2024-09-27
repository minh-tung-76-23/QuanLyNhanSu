namespace FormSignIn
{
    partial class FormAddPB
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
            this.txtAddMaPB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddTenPB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddDiaChi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAddMaPB
            // 
            this.txtAddMaPB.Location = new System.Drawing.Point(278, 113);
            this.txtAddMaPB.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtAddMaPB.Name = "txtAddMaPB";
            this.txtAddMaPB.Size = new System.Drawing.Size(295, 27);
            this.txtAddMaPB.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mã Phòng Ban";
            // 
            // txtAddTenPB
            // 
            this.txtAddTenPB.Location = new System.Drawing.Point(278, 170);
            this.txtAddTenPB.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtAddTenPB.Name = "txtAddTenPB";
            this.txtAddTenPB.Size = new System.Drawing.Size(295, 27);
            this.txtAddTenPB.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tên Phòng Ban";
            // 
            // txtAddDiaChi
            // 
            this.txtAddDiaChi.Location = new System.Drawing.Point(278, 225);
            this.txtAddDiaChi.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtAddDiaChi.Name = "txtAddDiaChi";
            this.txtAddDiaChi.Size = new System.Drawing.Size(295, 27);
            this.txtAddDiaChi.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Địa Chỉ";
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Location = new System.Drawing.Point(372, 315);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(144, 48);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(188, 315);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(144, 48);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(240, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 32);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nhập thông tin";
            // 
            // FormAddPB
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 397);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAddDiaChi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAddTenPB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAddMaPB);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormAddPB";
            this.Text = "Thêm Phòng Ban";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAddMaPB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddTenPB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddDiaChi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
    }
}