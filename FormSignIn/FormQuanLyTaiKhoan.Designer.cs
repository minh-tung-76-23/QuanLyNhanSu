namespace FormSignIn
{
    partial class FormQuanLyTaiKhoan
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
            this.dtGVQLTK = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelTK = new System.Windows.Forms.Button();
            this.btnEditTK = new System.Windows.Forms.Button();
            this.btnAddTK = new System.Windows.Forms.Button();
            this.cBUser = new System.Windows.Forms.ComboBox();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVQLTK)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGVQLTK
            // 
            this.dtGVQLTK.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtGVQLTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVQLTK.Location = new System.Drawing.Point(463, 96);
            this.dtGVQLTK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtGVQLTK.MultiSelect = false;
            this.dtGVQLTK.Name = "dtGVQLTK";
            this.dtGVQLTK.ReadOnly = true;
            this.dtGVQLTK.RowHeadersWidth = 51;
            this.dtGVQLTK.RowTemplate.Height = 24;
            this.dtGVQLTK.Size = new System.Drawing.Size(384, 380);
            this.dtGVQLTK.TabIndex = 0;
            this.dtGVQLTK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVQLTK_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý Tài Khoản";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelTK);
            this.groupBox1.Controls.Add(this.btnEditTK);
            this.groupBox1.Controls.Add(this.btnAddTK);
            this.groupBox1.Controls.Add(this.cBUser);
            this.groupBox1.Controls.Add(this.txtPW);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(33, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 386);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnDelTK
            // 
            this.btnDelTK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelTK.Location = new System.Drawing.Point(297, 277);
            this.btnDelTK.Name = "btnDelTK";
            this.btnDelTK.Size = new System.Drawing.Size(94, 40);
            this.btnDelTK.TabIndex = 14;
            this.btnDelTK.Text = "Xóa";
            this.btnDelTK.UseVisualStyleBackColor = true;
            this.btnDelTK.Click += new System.EventHandler(this.btnDelTK_Click);
            // 
            // btnEditTK
            // 
            this.btnEditTK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditTK.Location = new System.Drawing.Point(169, 277);
            this.btnEditTK.Name = "btnEditTK";
            this.btnEditTK.Size = new System.Drawing.Size(94, 40);
            this.btnEditTK.TabIndex = 13;
            this.btnEditTK.Text = "Sửa";
            this.btnEditTK.UseVisualStyleBackColor = true;
            this.btnEditTK.Click += new System.EventHandler(this.btnEditTK_Click);
            // 
            // btnAddTK
            // 
            this.btnAddTK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTK.Location = new System.Drawing.Point(38, 277);
            this.btnAddTK.Name = "btnAddTK";
            this.btnAddTK.Size = new System.Drawing.Size(94, 40);
            this.btnAddTK.TabIndex = 12;
            this.btnAddTK.Text = "Thêm";
            this.btnAddTK.UseVisualStyleBackColor = true;
            this.btnAddTK.Click += new System.EventHandler(this.btnAddTK_Click);
            // 
            // cBUser
            // 
            this.cBUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBUser.FormattingEnabled = true;
            this.cBUser.Items.AddRange(new object[] {
            "Quản Lý",
            "Nhân Viên"});
            this.cBUser.Location = new System.Drawing.Point(165, 202);
            this.cBUser.Name = "cBUser";
            this.cBUser.Size = new System.Drawing.Size(203, 27);
            this.cBUser.TabIndex = 11;
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(165, 136);
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(203, 27);
            this.txtPW.TabIndex = 4;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(165, 72);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(203, 27);
            this.txtUserName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Người Dùng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mật Khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Tài Khoản";
            // 
            // FormQuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 534);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtGVQLTK);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormQuanLyTaiKhoan";
            this.Text = "Quản Lý Tài Khoản";
            this.Load += new System.EventHandler(this.FormQuanLyTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGVQLTK)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGVQLTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelTK;
        private System.Windows.Forms.Button btnEditTK;
        private System.Windows.Forms.Button btnAddTK;
        private System.Windows.Forms.ComboBox cBUser;
    }
}