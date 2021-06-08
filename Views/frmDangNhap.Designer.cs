
namespace Doan_QLNH.Views
{
    partial class frmDangNhap
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.btnOkDangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.helytextHienFrmDangKy = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.txtUser = new DevExpress.XtraEditors.TextEdit();
            this.txtPassWord = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassWord.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnExit);
            this.groupControl1.Controls.Add(this.checkEdit1);
            this.groupControl1.Controls.Add(this.btnOkDangNhap);
            this.groupControl1.Controls.Add(this.helytextHienFrmDangKy);
            this.groupControl1.Controls.Add(this.txtUser);
            this.groupControl1.Controls.Add(this.txtPassWord);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Images = this.imageCollection1;
            this.groupControl1.Location = new System.Drawing.Point(17, 17);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(876, 410);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông Tin Đăng Nhập";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // btnExit
            // 
            this.btnExit.Appearance.Font = new System.Drawing.Font("Segoe UI Black", 12F);
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.ImageOptions.ImageIndex = 1;
            this.btnExit.ImageOptions.ImageList = this.imageCollection1;
            this.btnExit.Location = new System.Drawing.Point(461, 286);
            this.btnExit.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(212, 90);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(50, 50);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "48px-Crystal_Clear_action_exit.png");
            this.imageCollection1.Images.SetKeyName(1, "48px-Crystal_Clear_action_exit1.png");
            this.imageCollection1.Images.SetKeyName(2, "48px-Crystal_Clear_action_stop.png");
            this.imageCollection1.Images.SetKeyName(3, "1439854729_DeleteRed.png");
            this.imageCollection1.Images.SetKeyName(4, "angle-electric-blue-yellow-png-favpng-pvV1N1KwD6K64N5pBUdrC7XMe.jpg");
            this.imageCollection1.Images.SetKeyName(5, "kisspng-computer-icons-login-symbol-clip-art-5ae315b19562d1.604406871524831665611" +
        "9.jpg");
            this.imageCollection1.Images.SetKeyName(6, "png-transparent-computer-icons-login-iconfinder-door-login-icon-miscellaneous-ang" +
        "le-authorization-thumbnail.png");
            this.imageCollection1.Images.SetKeyName(7, "png-transparent-computer-icons-user-icon-design-patient-miscellaneous-balance-sym" +
        "bol.png");
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(489, 212);
            this.checkEdit1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Black", 10F);
            this.checkEdit1.Properties.Appearance.Options.UseFont = true;
            this.checkEdit1.Properties.Caption = "Ghi nhớ";
            this.checkEdit1.Size = new System.Drawing.Size(185, 27);
            this.checkEdit1.TabIndex = 3;
            // 
            // btnOkDangNhap
            // 
            this.btnOkDangNhap.Appearance.Font = new System.Drawing.Font("Segoe UI Black", 12F);
            this.btnOkDangNhap.Appearance.Options.UseFont = true;
            this.btnOkDangNhap.ImageOptions.ImageIndex = 4;
            this.btnOkDangNhap.ImageOptions.ImageList = this.imageCollection1;
            this.btnOkDangNhap.Location = new System.Drawing.Point(108, 286);
            this.btnOkDangNhap.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnOkDangNhap.Name = "btnOkDangNhap";
            this.btnOkDangNhap.Size = new System.Drawing.Size(236, 90);
            this.btnOkDangNhap.TabIndex = 1;
            this.btnOkDangNhap.Text = "Đăng Nhập";
            this.btnOkDangNhap.Click += new System.EventHandler(this.btnOkDangNhap_Click);
            // 
            // helytextHienFrmDangKy
            // 
            this.helytextHienFrmDangKy.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.helytextHienFrmDangKy.Appearance.Options.UseFont = true;
            this.helytextHienFrmDangKy.Location = new System.Drawing.Point(326, 224);
            this.helytextHienFrmDangKy.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.helytextHienFrmDangKy.Name = "helytextHienFrmDangKy";
            this.helytextHienFrmDangKy.Size = new System.Drawing.Size(54, 18);
            this.helytextHienFrmDangKy.TabIndex = 2;
            this.helytextHienFrmDangKy.Text = "Đăng ký";
            this.helytextHienFrmDangKy.Click += new System.EventHandler(this.hyperlinkLabelControl1_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(326, 88);
            this.txtUser.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.txtUser.Name = "txtUser";
            this.txtUser.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Black", 12F);
            this.txtUser.Properties.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtUser.Properties.Appearance.Options.UseFont = true;
            this.txtUser.Properties.Appearance.Options.UseForeColor = true;
            this.txtUser.Size = new System.Drawing.Size(325, 34);
            this.txtUser.TabIndex = 1;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(326, 142);
            this.txtPassWord.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Black", 12F);
            this.txtPassWord.Properties.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtPassWord.Properties.Appearance.Options.UseFont = true;
            this.txtPassWord.Properties.Appearance.Options.UseForeColor = true;
            this.txtPassWord.Properties.UseSystemPasswordChar = true;
            this.txtPassWord.Size = new System.Drawing.Size(325, 34);
            this.txtPassWord.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI Black", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(60, 222);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(191, 23);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Bạn chưa có tài khoản:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI Black", 12F);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(70, 148);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(101, 28);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Mật Khẩu:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Black", 12F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(70, 92);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(159, 28);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên Đăng Nhập:";
            // 
            // frmDangNhap
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(902, 431);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassWord.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.HyperlinkLabelControl helytextHienFrmDangKy;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnOkDangNhap;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        public DevExpress.XtraEditors.TextEdit txtPassWord;
        private DevExpress.Utils.ImageCollection imageCollection1;
        public DevExpress.XtraEditors.TextEdit txtUser;
    }
}