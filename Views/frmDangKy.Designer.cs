
namespace Doan_QLNH.Views
{
    partial class frmDangKy
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
            this.btnOkDangKy = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtPassWorld = new DevExpress.XtraEditors.TextEdit();
            this.txtPassWordNhapLai = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtUser = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblSao = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassWorld.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassWordNhapLai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Appearance.Font = new System.Drawing.Font("Segoe UI Black", 7.8F);
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(670, 335);
            this.btnExit.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 92);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Hủy";
            // 
            // btnOkDangKy
            // 
            this.btnOkDangKy.Appearance.Font = new System.Drawing.Font("Segoe UI Black", 7.8F);
            this.btnOkDangKy.Appearance.Options.UseFont = true;
            this.btnOkDangKy.Location = new System.Drawing.Point(219, 335);
            this.btnOkDangKy.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnOkDangKy.Name = "btnOkDangKy";
            this.btnOkDangKy.Size = new System.Drawing.Size(202, 92);
            this.btnOkDangKy.TabIndex = 3;
            this.btnOkDangKy.Text = "Đăng Ký";
            this.btnOkDangKy.Click += new System.EventHandler(this.btnOkDangKy_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnExit);
            this.groupControl1.Controls.Add(this.txtPassWorld);
            this.groupControl1.Controls.Add(this.btnOkDangKy);
            this.groupControl1.Controls.Add(this.txtPassWordNhapLai);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtUser);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.lblSao);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(17, 5);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1038, 486);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Thông Tin Đăng Ký";
            // 
            // txtPassWorld
            // 
            this.txtPassWorld.Location = new System.Drawing.Point(420, 128);
            this.txtPassWorld.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.txtPassWorld.Name = "txtPassWorld";
            this.txtPassWorld.Properties.UseSystemPasswordChar = true;
            this.txtPassWorld.Size = new System.Drawing.Size(450, 22);
            this.txtPassWorld.TabIndex = 1;
            // 
            // txtPassWordNhapLai
            // 
            this.txtPassWordNhapLai.Location = new System.Drawing.Point(420, 179);
            this.txtPassWordNhapLai.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.txtPassWordNhapLai.Name = "txtPassWordNhapLai";
            this.txtPassWordNhapLai.Properties.UseSystemPasswordChar = true;
            this.txtPassWordNhapLai.Size = new System.Drawing.Size(450, 22);
            this.txtPassWordNhapLai.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(219, 132);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(62, 17);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Mật Khẩu:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(219, 185);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(113, 17);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Nhập lại Mật Khẩu:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(420, 84);
            this.txtUser.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(450, 22);
            this.txtUser.TabIndex = 1;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(385, 185);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(8, 16);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "*";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(312, 134);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(8, 16);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "*";
            // 
            // lblSao
            // 
            this.lblSao.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblSao.Appearance.Options.UseForeColor = true;
            this.lblSao.Location = new System.Drawing.Point(372, 90);
            this.lblSao.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.lblSao.Name = "lblSao";
            this.lblSao.Size = new System.Drawing.Size(8, 16);
            this.lblSao.TabIndex = 0;
            this.lblSao.Text = "*";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(219, 90);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(101, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên Đăng Nhập:";
            // 
            // frmDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 507);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đăng ký";
            this.Load += new System.EventHandler(this.frmDangKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassWorld.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassWordNhapLai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnOkDangKy;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtPassWordNhapLai;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtUser;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtPassWorld;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lblSao;
    }
}