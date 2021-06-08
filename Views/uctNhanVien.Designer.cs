
namespace Doan_QLNH.Views
{
    partial class uctNhanVien
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
            this.grQLNhanVien = new System.Windows.Forms.GroupBox();
            this.cmbGioiTinhNhanVien = new System.Windows.Forms.ComboBox();
            this.dtpNgaysinhNhanVien = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDiaChiNhanVien = new System.Windows.Forms.TextBox();
            this.txtHolotNhanVien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmailNhanVien = new System.Windows.Forms.TextBox();
            this.txtIDNhanVien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSDTNhanVien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDSNhanVien = new System.Windows.Forms.DataGridView();
            this.IdNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoLot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnhide = new System.Windows.Forms.Button();
            this.pnlDSNhanVien = new System.Windows.Forms.Panel();
            this.grQLNhanVien.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // grQLNhanVien
            // 
            this.grQLNhanVien.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grQLNhanVien.Controls.Add(this.cmbGioiTinhNhanVien);
            this.grQLNhanVien.Controls.Add(this.dtpNgaysinhNhanVien);
            this.grQLNhanVien.Controls.Add(this.label10);
            this.grQLNhanVien.Controls.Add(this.txtTenNhanVien);
            this.grQLNhanVien.Controls.Add(this.label6);
            this.grQLNhanVien.Controls.Add(this.label9);
            this.grQLNhanVien.Controls.Add(this.txtDiaChiNhanVien);
            this.grQLNhanVien.Controls.Add(this.txtHolotNhanVien);
            this.grQLNhanVien.Controls.Add(this.label5);
            this.grQLNhanVien.Controls.Add(this.label8);
            this.grQLNhanVien.Controls.Add(this.txtEmailNhanVien);
            this.grQLNhanVien.Controls.Add(this.txtIDNhanVien);
            this.grQLNhanVien.Controls.Add(this.label4);
            this.grQLNhanVien.Controls.Add(this.label7);
            this.grQLNhanVien.Controls.Add(this.txtSDTNhanVien);
            this.grQLNhanVien.Controls.Add(this.label3);
            this.grQLNhanVien.Location = new System.Drawing.Point(61, 60);
            this.grQLNhanVien.Name = "grQLNhanVien";
            this.grQLNhanVien.Size = new System.Drawing.Size(570, 313);
            this.grQLNhanVien.TabIndex = 0;
            this.grQLNhanVien.TabStop = false;
            this.grQLNhanVien.Enter += new System.EventHandler(this.grQLNhanVien_Enter);
            // 
            // cmbGioiTinhNhanVien
            // 
            this.cmbGioiTinhNhanVien.FormattingEnabled = true;
            this.cmbGioiTinhNhanVien.Location = new System.Drawing.Point(389, 173);
            this.cmbGioiTinhNhanVien.Name = "cmbGioiTinhNhanVien";
            this.cmbGioiTinhNhanVien.Size = new System.Drawing.Size(161, 24);
            this.cmbGioiTinhNhanVien.TabIndex = 3;
            // 
            // dtpNgaysinhNhanVien
            // 
            this.dtpNgaysinhNhanVien.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaysinhNhanVien.Location = new System.Drawing.Point(109, 177);
            this.dtpNgaysinhNhanVien.Name = "dtpNgaysinhNhanVien";
            this.dtpNgaysinhNhanVien.Size = new System.Drawing.Size(161, 22);
            this.dtpNgaysinhNhanVien.TabIndex = 2;
            this.dtpNgaysinhNhanVien.Value = new System.DateTime(2021, 6, 3, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ngày sinh:";
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(109, 138);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(161, 22);
            this.txtTenNhanVien.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(288, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Giới tính:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tên:";
            // 
            // txtDiaChiNhanVien
            // 
            this.txtDiaChiNhanVien.Location = new System.Drawing.Point(389, 133);
            this.txtDiaChiNhanVien.Name = "txtDiaChiNhanVien";
            this.txtDiaChiNhanVien.Size = new System.Drawing.Size(161, 22);
            this.txtDiaChiNhanVien.TabIndex = 1;
            // 
            // txtHolotNhanVien
            // 
            this.txtHolotNhanVien.Location = new System.Drawing.Point(109, 100);
            this.txtHolotNhanVien.Name = "txtHolotNhanVien";
            this.txtHolotNhanVien.Size = new System.Drawing.Size(161, 22);
            this.txtHolotNhanVien.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Địa chỉ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Họ lót:";
            // 
            // txtEmailNhanVien
            // 
            this.txtEmailNhanVien.Location = new System.Drawing.Point(389, 95);
            this.txtEmailNhanVien.Name = "txtEmailNhanVien";
            this.txtEmailNhanVien.Size = new System.Drawing.Size(161, 22);
            this.txtEmailNhanVien.TabIndex = 1;
            // 
            // txtIDNhanVien
            // 
            this.txtIDNhanVien.Enabled = false;
            this.txtIDNhanVien.Location = new System.Drawing.Point(109, 63);
            this.txtIDNhanVien.Name = "txtIDNhanVien";
            this.txtIDNhanVien.Size = new System.Drawing.Size(161, 22);
            this.txtIDNhanVien.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "ID Nhân Viên:";
            // 
            // txtSDTNhanVien
            // 
            this.txtSDTNhanVien.Location = new System.Drawing.Point(389, 58);
            this.txtSDTNhanVien.Name = "txtSDTNhanVien";
            this.txtSDTNhanVien.Size = new System.Drawing.Size(161, 22);
            this.txtSDTNhanVien.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "SĐT:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.dgvDSNhanVien);
            this.groupBox1.Location = new System.Drawing.Point(712, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1080, 313);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dgvDSNhanVien
            // 
            this.dgvDSNhanVien.AllowUserToOrderColumns = true;
            this.dgvDSNhanVien.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgvDSNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdNhanVien,
            this.HoLot,
            this.Ten,
            this.Ngaysinh,
            this.GioiTinh,
            this.DienThoai,
            this.Email,
            this.DiaChi});
            this.dgvDSNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSNhanVien.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvDSNhanVien.Location = new System.Drawing.Point(3, 18);
            this.dgvDSNhanVien.Name = "dgvDSNhanVien";
            this.dgvDSNhanVien.RowHeadersWidth = 51;
            this.dgvDSNhanVien.RowTemplate.Height = 24;
            this.dgvDSNhanVien.Size = new System.Drawing.Size(1074, 292);
            this.dgvDSNhanVien.TabIndex = 0;
            // 
            // IdNhanVien
            // 
            this.IdNhanVien.DataPropertyName = "IdNhanVien";
            this.IdNhanVien.HeaderText = "Mã Nhân Viên";
            this.IdNhanVien.MinimumWidth = 6;
            this.IdNhanVien.Name = "IdNhanVien";
            this.IdNhanVien.Width = 125;
            // 
            // HoLot
            // 
            this.HoLot.DataPropertyName = "HoLot";
            this.HoLot.HeaderText = "Họ Lót";
            this.HoLot.MinimumWidth = 6;
            this.HoLot.Name = "HoLot";
            this.HoLot.Width = 125;
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Tên";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            this.Ten.Width = 125;
            // 
            // Ngaysinh
            // 
            this.Ngaysinh.DataPropertyName = "Ngaysinh";
            this.Ngaysinh.HeaderText = "Ngày Sinh";
            this.Ngaysinh.MinimumWidth = 6;
            this.Ngaysinh.Name = "Ngaysinh";
            this.Ngaysinh.Width = 125;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Width = 125;
            // 
            // DienThoai
            // 
            this.DienThoai.DataPropertyName = "DienThoai";
            this.DienThoai.HeaderText = "SĐT";
            this.DienThoai.MinimumWidth = 6;
            this.DienThoai.Name = "DienThoai";
            this.DienThoai.Width = 125;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(109, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(708, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(61, 390);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(170, 390);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(282, 390);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(391, 390);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(508, 390);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(721, 390);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnhide
            // 
            this.btnhide.Location = new System.Drawing.Point(838, 390);
            this.btnhide.Name = "btnhide";
            this.btnhide.Size = new System.Drawing.Size(75, 23);
            this.btnhide.TabIndex = 3;
            this.btnhide.Text = "<<";
            this.btnhide.UseVisualStyleBackColor = true;
            this.btnhide.Click += new System.EventHandler(this.btnhide_Click);
            // 
            // pnlDSNhanVien
            // 
            this.pnlDSNhanVien.Location = new System.Drawing.Point(613, 443);
            this.pnlDSNhanVien.Name = "pnlDSNhanVien";
            this.pnlDSNhanVien.Size = new System.Drawing.Size(1179, 296);
            this.pnlDSNhanVien.TabIndex = 4;
            this.pnlDSNhanVien.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDSNhanVien_Paint);
            // 
            // uctNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.pnlDSNhanVien);
            this.Controls.Add(this.btnhide);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grQLNhanVien);
            this.Name = "uctNhanVien";
            this.Size = new System.Drawing.Size(1808, 785);
            this.Load += new System.EventHandler(this.uctNhanVien_Load);
            this.grQLNhanVien.ResumeLayout(false);
            this.grQLNhanVien.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grQLNhanVien;
        private System.Windows.Forms.ComboBox cmbGioiTinhNhanVien;
        private System.Windows.Forms.DateTimePicker dtpNgaysinhNhanVien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDiaChiNhanVien;
        private System.Windows.Forms.TextBox txtHolotNhanVien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmailNhanVien;
        private System.Windows.Forms.TextBox txtIDNhanVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSDTNhanVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDSNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnhide;
        private System.Windows.Forms.Panel pnlDSNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoLot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
    }
}
