namespace FormSignIn
{
    partial class FormListPB
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
            this.lVPhongBan = new System.Windows.Forms.ListView();
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh Sách Phòng Ban";
            // 
            // lVPhongBan
            // 
            this.lVPhongBan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14});
            this.lVPhongBan.GridLines = true;
            this.lVPhongBan.HideSelection = false;
            this.lVPhongBan.Location = new System.Drawing.Point(73, 85);
            this.lVPhongBan.Name = "lVPhongBan";
            this.lVPhongBan.Size = new System.Drawing.Size(400, 302);
            this.lVPhongBan.TabIndex = 3;
            this.lVPhongBan.UseCompatibleStateImageBehavior = false;
            this.lVPhongBan.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Mã Phòng Ban";
            this.columnHeader12.Width = 130;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Tên Phòng Ban";
            this.columnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader13.Width = 130;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Địa Chỉ";
            this.columnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader14.Width = 130;
            // 
            // FormListPB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 433);
            this.Controls.Add(this.lVPhongBan);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormListPB";
            this.Text = "Danh Sách Phòng Ban";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormListPB_FormClosing);
            this.Load += new System.EventHandler(this.FormListPB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lVPhongBan;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
    }
}