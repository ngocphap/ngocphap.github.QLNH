
namespace Doan_QLNH.Views
{
    partial class frmDoiMatKhau
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
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnThayDoi = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtPassCu = new DevExpress.XtraEditors.TextEdit();
            this.txtNhapLaiPass = new DevExpress.XtraEditors.TextEdit();
            this.txtPassMoi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtUser = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblSao = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassCu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhapLaiPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassMoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Appearance.Font = new System.Drawing.Font("Segoe UI Black", 7.8F);
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(672, 330);
            this.btnExit.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(250, 115);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Hủy";
            // 
            // btnThayDoi
            // 
            this.btnThayDoi.Appearance.Font = new System.Drawing.Font("Segoe UI Black", 7.8F);
            this.btnThayDoi.Appearance.Options.UseFont = true;
            this.btnThayDoi.Location = new System.Drawing.Point(360, 330);
            this.btnThayDoi.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.btnThayDoi.Name = "btnThayDoi";
            this.btnThayDoi.Size = new System.Drawing.Size(252, 115);
            this.btnThayDoi.TabIndex = 6;
            this.btnThayDoi.Text = "Thay Đổi ";
            this.btnThayDoi.Click += new System.EventHandler(this.btnOkDangKy_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnExit);
            this.groupControl1.Controls.Add(this.txtPassCu);
            this.groupControl1.Controls.Add(this.btnThayDoi);
            this.groupControl1.Controls.Add(this.txtNhapLaiPass);
            this.groupControl1.Controls.Add(this.txtPassMoi);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtUser);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.lblSao);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(19, 10);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1038, 486);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Đổi Mật Khẩu";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // txtPassCu
            // 
            this.txtPassCu.Location = new System.Drawing.Point(360, 132);
            this.txtPassCu.Margin = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.txtPassCu.Name = "txtPassCu";
            this.txtPassCu.Properties.UseSystemPasswordChar = true;
            this.txtPassCu.Size = new System.Drawing.Size(562, 22);
            this.txtPassCu.TabIndex = 1;
            // 
            // txtNhapLaiPass
            // 
            this.txtNhapLaiPass.Location = new System.Drawing.Point(360, 250);
            this.txtNhapLaiPass.Margin = new System.Windows.Forms.Padding(12, 15, 12, 15);
            this.txtNhapLaiPass.Name = "txtNhapLaiPass";
            this.txtNhapLaiPass.Properties.UseSystemPasswordChar = true;
            this.txtNhapLaiPass.Size = new System.Drawing.Size(569, 22);
            this.txtNhapLaiPass.TabIndex = 1;
            // 
            // txtPassMoi
            // 
            this.txtPassMoi.Location = new System.Drawing.Point(360, 198);
            this.txtPassMoi.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.txtPassMoi.Name = "txtPassMoi";
            this.txtPassMoi.Properties.UseSystemPasswordChar = true;
            this.txtPassMoi.Size = new System.Drawing.Size(562, 22);
            this.txtPassMoi.TabIndex = 1;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(108, 258);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(12, 15, 12, 15);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(144, 17);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Nhập Lại Mật Khẩu mới:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(108, 139);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(83, 17);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Mật Khẩu Cũ:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(108, 205);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(88, 17);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Mật Khẩu mới:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(360, 78);
            this.txtUser.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(562, 22);
            this.txtUser.TabIndex = 1;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(290, 258);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(24, 24, 24, 24);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(8, 16);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "*";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(225, 206);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(19, 19, 19, 19);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(8, 16);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "*";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(225, 140);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(8, 16);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "*";
            // 
            // lblSao
            // 
            this.lblSao.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblSao.Appearance.Options.UseForeColor = true;
            this.lblSao.Location = new System.Drawing.Point(236, 85);
            this.lblSao.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.lblSao.Name = "lblSao";
            this.lblSao.Size = new System.Drawing.Size(8, 16);
            this.lblSao.TabIndex = 0;
            this.lblSao.Text = "*";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(108, 86);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(101, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên Đăng Nhập:";
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 505);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmDoiMatKhau";
            this.Text = "frmDoiMatKhau";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassCu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhapLaiPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassMoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnThayDoi;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtPassCu;
        private DevExpress.XtraEditors.TextEdit txtPassMoi;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtUser;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lblSao;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtNhapLaiPass;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}