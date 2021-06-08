
namespace Doan_QLNH.Views
{
    partial class uctThucDon
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
            this.dgvDSThucDon = new System.Windows.Forms.DataGridView();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grQLNhanVien = new System.Windows.Forms.GroupBox();
            this.cmbTrangThai = new System.Windows.Forms.ComboBox();
            this.cmbLoaiThucDon = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDonGiaTon = new System.Windows.Forms.TextBox();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.txtTenThucDonMoi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoLuongTon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIDThucDon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.picThucDon = new System.Windows.Forms.PictureBox();
            this.openfileDialod_Image = new System.Windows.Forms.OpenFileDialog();
            this.btnThemAnh = new System.Windows.Forms.Button();
            this.IdThucDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiThucDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThucDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HinhAnh = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSThucDon)).BeginInit();
            this.grQLNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picThucDon)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(964, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 23);
            this.label3.TabIndex = 39;
            this.label3.Text = "DANH SÁCH THỰC ĐƠN";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.dgvDSThucDon);
            this.groupBox1.Location = new System.Drawing.Point(757, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(971, 365);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            // 
            // dgvDSThucDon
            // 
            this.dgvDSThucDon.AllowUserToAddRows = false;
            this.dgvDSThucDon.AllowUserToOrderColumns = true;
            this.dgvDSThucDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSThucDon.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgvDSThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSThucDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdThucDon,
            this.TenLoaiThucDon,
            this.TenThucDon,
            this.DonViTinh,
            this.SoLuongTon,
            this.DonGiaTon,
            this.TrangThai,
            this.HinhAnh});
            this.dgvDSThucDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSThucDon.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvDSThucDon.Location = new System.Drawing.Point(3, 18);
            this.dgvDSThucDon.Name = "dgvDSThucDon";
            this.dgvDSThucDon.RowHeadersWidth = 51;
            this.dgvDSThucDon.RowTemplate.Height = 24;
            this.dgvDSThucDon.Size = new System.Drawing.Size(965, 344);
            this.dgvDSThucDon.TabIndex = 0;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(391, 564);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(81, 58);
            this.btnHuy.TabIndex = 35;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click_1);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(285, 564);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(84, 58);
            this.btnLuu.TabIndex = 36;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(418, 500);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(85, 58);
            this.btnSua.TabIndex = 33;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(317, 500);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 58);
            this.btnXoa.TabIndex = 37;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(228, 500);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(83, 58);
            this.btnThem.TabIndex = 34;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(110, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 23);
            this.label1.TabIndex = 32;
            this.label1.Text = "QUẢN LÝ THỰC ĐƠN";
            // 
            // grQLNhanVien
            // 
            this.grQLNhanVien.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grQLNhanVien.Controls.Add(this.btnThemAnh);
            this.grQLNhanVien.Controls.Add(this.picThucDon);
            this.grQLNhanVien.Controls.Add(this.cmbTrangThai);
            this.grQLNhanVien.Controls.Add(this.cmbLoaiThucDon);
            this.grQLNhanVien.Controls.Add(this.label9);
            this.grQLNhanVien.Controls.Add(this.label10);
            this.grQLNhanVien.Controls.Add(this.label2);
            this.grQLNhanVien.Controls.Add(this.label6);
            this.grQLNhanVien.Controls.Add(this.txtDonGiaTon);
            this.grQLNhanVien.Controls.Add(this.txtDonViTinh);
            this.grQLNhanVien.Controls.Add(this.txtTenThucDonMoi);
            this.grQLNhanVien.Controls.Add(this.label5);
            this.grQLNhanVien.Controls.Add(this.label8);
            this.grQLNhanVien.Controls.Add(this.txtSoLuongTon);
            this.grQLNhanVien.Controls.Add(this.label4);
            this.grQLNhanVien.Controls.Add(this.txtIDThucDon);
            this.grQLNhanVien.Controls.Add(this.label7);
            this.grQLNhanVien.Location = new System.Drawing.Point(38, 110);
            this.grQLNhanVien.Name = "grQLNhanVien";
            this.grQLNhanVien.Size = new System.Drawing.Size(682, 365);
            this.grQLNhanVien.TabIndex = 31;
            this.grQLNhanVien.TabStop = false;
            // 
            // cmbTrangThai
            // 
            this.cmbTrangThai.FormattingEnabled = true;
            this.cmbTrangThai.Location = new System.Drawing.Point(142, 258);
            this.cmbTrangThai.Name = "cmbTrangThai";
            this.cmbTrangThai.Size = new System.Drawing.Size(150, 24);
            this.cmbTrangThai.TabIndex = 3;
            // 
            // cmbLoaiThucDon
            // 
            this.cmbLoaiThucDon.FormattingEnabled = true;
            this.cmbLoaiThucDon.Location = new System.Drawing.Point(142, 52);
            this.cmbLoaiThucDon.Name = "cmbLoaiThucDon";
            this.cmbLoaiThucDon.Size = new System.Drawing.Size(150, 24);
            this.cmbLoaiThucDon.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Trạng thái:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Đơn vị tính:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên thực đơn:";
            // 
            // txtDonGiaTon
            // 
            this.txtDonGiaTon.Location = new System.Drawing.Point(142, 217);
            this.txtDonGiaTon.Name = "txtDonGiaTon";
            this.txtDonGiaTon.Size = new System.Drawing.Size(150, 22);
            this.txtDonGiaTon.TabIndex = 1;
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Location = new System.Drawing.Point(142, 133);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(150, 22);
            this.txtDonViTinh.TabIndex = 1;
            // 
            // txtTenThucDonMoi
            // 
            this.txtTenThucDonMoi.Location = new System.Drawing.Point(142, 93);
            this.txtTenThucDonMoi.Name = "txtTenThucDonMoi";
            this.txtTenThucDonMoi.Size = new System.Drawing.Size(150, 22);
            this.txtTenThucDonMoi.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Đơn giá Tồn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tên Loại thực đơn:";
            // 
            // txtSoLuongTon
            // 
            this.txtSoLuongTon.Enabled = false;
            this.txtSoLuongTon.Location = new System.Drawing.Point(142, 178);
            this.txtSoLuongTon.Name = "txtSoLuongTon";
            this.txtSoLuongTon.Size = new System.Drawing.Size(150, 22);
            this.txtSoLuongTon.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số lượng Tồn:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtIDThucDon
            // 
            this.txtIDThucDon.Enabled = false;
            this.txtIDThucDon.Location = new System.Drawing.Point(142, 13);
            this.txtIDThucDon.Name = "txtIDThucDon";
            this.txtIDThucDon.Size = new System.Drawing.Size(150, 22);
            this.txtIDThucDon.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "ID Thực đơn:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(334, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Hình Ảnh:";
            // 
            // picThucDon
            // 
            this.picThucDon.Location = new System.Drawing.Point(422, 18);
            this.picThucDon.Name = "picThucDon";
            this.picThucDon.Size = new System.Drawing.Size(222, 217);
            this.picThucDon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picThucDon.TabIndex = 4;
            this.picThucDon.TabStop = false;
            // 
            // openfileDialod_Image
            // 
            this.openfileDialod_Image.FileName = "openfileDialod_Image";
            // 
            // btnThemAnh
            // 
            this.btnThemAnh.Location = new System.Drawing.Point(337, 52);
            this.btnThemAnh.Name = "btnThemAnh";
            this.btnThemAnh.Size = new System.Drawing.Size(75, 63);
            this.btnThemAnh.TabIndex = 5;
            this.btnThemAnh.Text = "Thêm ảnh";
            this.btnThemAnh.UseVisualStyleBackColor = true;
            this.btnThemAnh.Click += new System.EventHandler(this.btnThemAnh_Click);
            // 
            // IdThucDon
            // 
            this.IdThucDon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdThucDon.DataPropertyName = "IdThucDon";
            this.IdThucDon.HeaderText = "Mã Thực Đơn";
            this.IdThucDon.MinimumWidth = 6;
            this.IdThucDon.Name = "IdThucDon";
            // 
            // TenLoaiThucDon
            // 
            this.TenLoaiThucDon.DataPropertyName = "TenLoaiThucDon";
            this.TenLoaiThucDon.HeaderText = "Loại Thực Đơn";
            this.TenLoaiThucDon.MinimumWidth = 6;
            this.TenLoaiThucDon.Name = "TenLoaiThucDon";
            // 
            // TenThucDon
            // 
            this.TenThucDon.DataPropertyName = "TenThucDon";
            this.TenThucDon.HeaderText = "Tên Thực Đơn";
            this.TenThucDon.MinimumWidth = 6;
            this.TenThucDon.Name = "TenThucDon";
            // 
            // DonViTinh
            // 
            this.DonViTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DonViTinh.DataPropertyName = "DonViTinh";
            this.DonViTinh.HeaderText = "Đơn Vị Tính";
            this.DonViTinh.MinimumWidth = 6;
            this.DonViTinh.Name = "DonViTinh";
            // 
            // SoLuongTon
            // 
            this.SoLuongTon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoLuongTon.DataPropertyName = "SoLuongTon";
            this.SoLuongTon.HeaderText = "Số Lượng Tồn";
            this.SoLuongTon.MinimumWidth = 6;
            this.SoLuongTon.Name = "SoLuongTon";
            // 
            // DonGiaTon
            // 
            this.DonGiaTon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DonGiaTon.DataPropertyName = "DonGiaTon";
            this.DonGiaTon.HeaderText = "Giá Tiền";
            this.DonGiaTon.MinimumWidth = 6;
            this.DonGiaTon.Name = "DonGiaTon";
            // 
            // TrangThai
            // 
            this.TrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            // 
            // HinhAnh
            // 
            this.HinhAnh.DataPropertyName = "HinhAnh";
            this.HinhAnh.HeaderText = "Hình Ảnh";
            this.HinhAnh.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.HinhAnh.MinimumWidth = 6;
            this.HinhAnh.Name = "HinhAnh";
            this.HinhAnh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HinhAnh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // uctThucDon
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
            this.Name = "uctThucDon";
            this.Size = new System.Drawing.Size(1776, 736);
            this.Load += new System.EventHandler(this.uctThucDon_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSThucDon)).EndInit();
            this.grQLNhanVien.ResumeLayout(false);
            this.grQLNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picThucDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDSThucDon;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grQLNhanVien;
        private System.Windows.Forms.ComboBox cmbTrangThai;
        private System.Windows.Forms.ComboBox cmbLoaiThucDon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDonGiaTon;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.TextBox txtTenThucDonMoi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoLuongTon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIDThucDon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picThucDon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.OpenFileDialog openfileDialod_Image;
        private System.Windows.Forms.Button btnThemAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdThucDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiThucDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThucDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewImageColumn HinhAnh;
    }
}
