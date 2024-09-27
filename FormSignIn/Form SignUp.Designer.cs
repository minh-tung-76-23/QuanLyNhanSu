namespace FormSignIn
{
    partial class Form_SignUp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPW1 = new System.Windows.Forms.TextBox();
            this.txtPW2 = new System.Windows.Forms.TextBox();
            this.cBUser = new System.Windows.Forms.ComboBox();
            this.lbError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập thông tin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tài Khoản ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật Khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhập lại mật khẩu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Người sử dụng";
            // 
            // btnSignUp
            // 
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.Location = new System.Drawing.Point(266, 301);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(111, 41);
            this.btnSignUp.TabIndex = 5;
            this.btnSignUp.Text = "Đăng ký";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Location = new System.Drawing.Point(428, 301);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 41);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(181, 99);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(343, 27);
            this.txtUserName.TabIndex = 7;
            // 
            // txtPW1
            // 
            this.txtPW1.Location = new System.Drawing.Point(181, 151);
            this.txtPW1.Name = "txtPW1";
            this.txtPW1.PasswordChar = '*';
            this.txtPW1.Size = new System.Drawing.Size(343, 27);
            this.txtPW1.TabIndex = 8;
            // 
            // txtPW2
            // 
            this.txtPW2.Location = new System.Drawing.Point(181, 199);
            this.txtPW2.Name = "txtPW2";
            this.txtPW2.PasswordChar = '*';
            this.txtPW2.Size = new System.Drawing.Size(343, 27);
            this.txtPW2.TabIndex = 9;
            this.txtPW2.TextChanged += new System.EventHandler(this.txtPW2_TextChanged);
            // 
            // cBUser
            // 
            this.cBUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBUser.FormattingEnabled = true;
            this.cBUser.Items.AddRange(new object[] {
            "Quản Lý",
            "Nhân Viên"});
            this.cBUser.Location = new System.Drawing.Point(181, 256);
            this.cBUser.Name = "cBUser";
            this.cBUser.Size = new System.Drawing.Size(228, 27);
            this.cBUser.TabIndex = 10;
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(188, 229);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 15);
            this.lbError.TabIndex = 11;
            // 
            // Form_SignUp
            // 
            this.AcceptButton = this.btnSignUp;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 412);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.cBUser);
            this.Controls.Add(this.txtPW2);
            this.Controls.Add(this.txtPW1);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Form_SignUp";
            this.Text = "Đăng Ký";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_SignUp_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPW1;
        private System.Windows.Forms.TextBox txtPW2;
        private System.Windows.Forms.ComboBox cBUser;
        private System.Windows.Forms.Label lbError;
    }
}