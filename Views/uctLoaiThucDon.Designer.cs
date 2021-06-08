
namespace Doan_QLNH.Views
{
    partial class uctLoaiThucDon
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDSLoaiThucDon = new System.Windows.Forms.DataGridView();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grQLNhanVien = new System.Windows.Forms.GroupBox();
            this.cmbTrangThaiThucDon = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenThucDon = new System.Windows.Forms.TextBox();
            this.txtDienGiaiThucDon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIDThucDon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLoaiThucDon)).BeginInit();
            this.grQLNhanVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(190, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 23);
            this.label3.TabIndex = 30;
            this.label3.Text = "DANH SÁCH LOẠI THỰC ĐƠN";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.dgvDSLoaiThucDon);
            this.groupBox1.Location = new System.Drawing.Point(21, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1080, 477);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // dgvDSLoaiThucDon
            // 
            this.dgvDSLoaiThucDon.AllowUserToOrderColumns = true;
            this.dgvDSLoaiThucDon.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgvDSLoaiThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSLoaiThucDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSLoaiThucDon.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvDSLoaiThucDon.Location = new System.Drawing.Point(3, 18);
            this.dgvDSLoaiThucDon.Name = "dgvDSLoaiThucDon";
            this.dgvDSLoaiThucDon.RowHeadersWidth = 51;
            this.dgvDSLoaiThucDon.RowTemplate.Height = 24;
            this.dgvDSLoaiThucDon.Size = new System.Drawing.Size(1074, 456);
            this.dgvDSLoaiThucDon.TabIndex = 0;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(1512, 422);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(81, 23);
            this.btnHuy.TabIndex = 26;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click_1);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(1422, 422);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(84, 23);
            this.btnLuu.TabIndex = 27;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(1332, 422);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(85, 23);
            this.btnSua.TabIndex = 24;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(1231, 422);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 23);
            this.btnXoa.TabIndex = 28;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(1142, 422);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(83, 23);
            this.btnThem.TabIndex = 25;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(1265, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "QUẢN LÝ THỰC ĐƠN";
            // 
            // grQLNhanVien
            // 
            this.grQLNhanVien.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grQLNhanVien.Controls.Add(this.cmbTrangThaiThucDon);
            this.grQLNhanVien.Controls.Add(this.label2);
            this.grQLNhanVien.Controls.Add(this.label6);
            this.grQLNhanVien.Controls.Add(this.txtTenThucDon);
            this.grQLNhanVien.Controls.Add(this.txtDienGiaiThucDon);
            this.grQLNhanVien.Controls.Add(this.label8);
            this.grQLNhanVien.Controls.Add(this.txtIDThucDon);
            this.grQLNhanVien.Controls.Add(this.label7);
            this.grQLNhanVien.Location = new System.Drawing.Point(1142, 73);
            this.grQLNhanVien.Name = "grQLNhanVien";
            this.grQLNhanVien.Size = new System.Drawing.Size(447, 229);
            this.grQLNhanVien.TabIndex = 22;
            this.grQLNhanVien.TabStop = false;
            // 
            // cmbTrangThaiThucDon
            // 
            this.cmbTrangThaiThucDon.FormattingEnabled = true;
            this.cmbTrangThaiThucDon.Location = new System.Drawing.Point(206, 167);
            this.cmbTrangThaiThucDon.Name = "cmbTrangThaiThucDon";
            this.cmbTrangThaiThucDon.Size = new System.Drawing.Size(150, 24);
            this.cmbTrangThaiThucDon.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Trạng thái:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Diễn giải:";
            // 
            // txtTenThucDon
            // 
            this.txtTenThucDon.Location = new System.Drawing.Point(206, 82);
            this.txtTenThucDon.Name = "txtTenThucDon";
            this.txtTenThucDon.Size = new System.Drawing.Size(150, 22);
            this.txtTenThucDon.TabIndex = 1;
            // 
            // txtDienGiaiThucDon
            // 
            this.txtDienGiaiThucDon.Location = new System.Drawing.Point(206, 123);
            this.txtDienGiaiThucDon.Name = "txtDienGiaiThucDon";
            this.txtDienGiaiThucDon.Size = new System.Drawing.Size(150, 22);
            this.txtDienGiaiThucDon.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(85, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tên :";
            // 
            // txtIDThucDon
            // 
            this.txtIDThucDon.Enabled = false;
            this.txtIDThucDon.Location = new System.Drawing.Point(206, 43);
            this.txtIDThucDon.Name = "txtIDThucDon";
            this.txtIDThucDon.Size = new System.Drawing.Size(150, 22);
            this.txtIDThucDon.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(85, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "ID Loại thực đơn:";
            // 
            // uctLoaiThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grQLNhanVien);
            this.Name = "uctLoaiThucDon";
            this.Size = new System.Drawing.Size(1744, 552);
            this.Load += new System.EventHandler(this.uctLoaiThucDon_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLoaiThucDon)).EndInit();
            this.grQLNhanVien.ResumeLayout(false);
            this.grQLNhanVien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDSLoaiThucDon;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grQLNhanVien;
        private System.Windows.Forms.ComboBox cmbTrangThaiThucDon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenThucDon;
        private System.Windows.Forms.TextBox txtDienGiaiThucDon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIDThucDon;
        private System.Windows.Forms.Label label7;
    }
}
