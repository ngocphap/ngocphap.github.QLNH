
namespace Doan_QLNH.Views
{
    partial class uctGoiMon
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uctGoiMon));
            this.lvDanhSachBan = new System.Windows.Forms.ListView();
            this.cntxtmenuDSBan = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hiểnThịBànChưaCóNgườiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hIểnThịBànCóNgườiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtDanhSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmBànMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.dgvGoiMon = new System.Windows.Forms.DataGridView();
            this.btnMenu = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lbltenTongTien = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblThanhToan = new System.Windows.Forms.Label();
            this.pnlGoiMon = new System.Windows.Forms.Panel();
            this.btnGoiMon = new System.Windows.Forms.Button();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.lblCuaListBox = new System.Windows.Forms.Label();
            this.lblTenBanTrongListView = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cntxtmenuDSBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoiMon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvDanhSachBan
            // 
            this.lvDanhSachBan.ContextMenuStrip = this.cntxtmenuDSBan;
            this.lvDanhSachBan.GridLines = true;
            this.lvDanhSachBan.HideSelection = false;
            this.lvDanhSachBan.LargeImageList = this.imageList2;
            this.lvDanhSachBan.Location = new System.Drawing.Point(0, 11);
            this.lvDanhSachBan.Name = "lvDanhSachBan";
            this.lvDanhSachBan.Size = new System.Drawing.Size(540, 706);
            this.lvDanhSachBan.TabIndex = 0;
            this.lvDanhSachBan.UseCompatibleStateImageBehavior = false;
            this.lvDanhSachBan.SelectedIndexChanged += new System.EventHandler(this.lvDanhSachBan_SelectedIndexChanged);
            this.lvDanhSachBan.Click += new System.EventHandler(this.lvDanhSachBan_Click);
            // 
            // cntxtmenuDSBan
            // 
            this.cntxtmenuDSBan.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cntxtmenuDSBan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hiểnThịBànChưaCóNgườiToolStripMenuItem,
            this.hIểnThịBànCóNgườiToolStripMenuItem,
            this.cậpNhậtDanhSáchToolStripMenuItem,
            this.thêmBànMớiToolStripMenuItem});
            this.cntxtmenuDSBan.Name = "cntxtmenuDSBan";
            this.cntxtmenuDSBan.Size = new System.Drawing.Size(259, 100);
            this.cntxtmenuDSBan.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // hiểnThịBànChưaCóNgườiToolStripMenuItem
            // 
            this.hiểnThịBànChưaCóNgườiToolStripMenuItem.Name = "hiểnThịBànChưaCóNgườiToolStripMenuItem";
            this.hiểnThịBànChưaCóNgườiToolStripMenuItem.Size = new System.Drawing.Size(258, 24);
            this.hiểnThịBànChưaCóNgườiToolStripMenuItem.Text = "Hiển thị bàn chưa có người";
            this.hiểnThịBànChưaCóNgườiToolStripMenuItem.Click += new System.EventHandler(this.hiểnThịBànChưaCóNgườiToolStripMenuItem_Click);
            // 
            // hIểnThịBànCóNgườiToolStripMenuItem
            // 
            this.hIểnThịBànCóNgườiToolStripMenuItem.Name = "hIểnThịBànCóNgườiToolStripMenuItem";
            this.hIểnThịBànCóNgườiToolStripMenuItem.Size = new System.Drawing.Size(258, 24);
            this.hIểnThịBànCóNgườiToolStripMenuItem.Text = "HIển thị bàn có người";
            this.hIểnThịBànCóNgườiToolStripMenuItem.Click += new System.EventHandler(this.hIểnThịBànCóNgườiToolStripMenuItem_Click);
            // 
            // cậpNhậtDanhSáchToolStripMenuItem
            // 
            this.cậpNhậtDanhSáchToolStripMenuItem.Name = "cậpNhậtDanhSáchToolStripMenuItem";
            this.cậpNhậtDanhSáchToolStripMenuItem.Size = new System.Drawing.Size(258, 24);
            this.cậpNhậtDanhSáchToolStripMenuItem.Text = "Cập nhật danh sách bàn";
            this.cậpNhậtDanhSáchToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtDanhSáchToolStripMenuItem_Click);
            // 
            // thêmBànMớiToolStripMenuItem
            // 
            this.thêmBànMớiToolStripMenuItem.Name = "thêmBànMớiToolStripMenuItem";
            this.thêmBànMớiToolStripMenuItem.Size = new System.Drawing.Size(258, 24);
            this.thêmBànMớiToolStripMenuItem.Text = "Thêm bàn mới";
            this.thêmBànMớiToolStripMenuItem.Click += new System.EventHandler(this.thêmBànMớiToolStripMenuItem_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "151-512.png");
            this.imageList2.Images.SetKeyName(1, "51882.png");
            this.imageList2.Images.SetKeyName(2, "eat-02-512_16677.png");
            this.imageList2.Images.SetKeyName(3, "table.jpg");
            this.imageList2.Images.SetKeyName(4, "table2.jpg");
            // 
            // dgvGoiMon
            // 
            this.dgvGoiMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGoiMon.Location = new System.Drawing.Point(67, 8);
            this.dgvGoiMon.Name = "dgvGoiMon";
            this.dgvGoiMon.RowHeadersWidth = 51;
            this.dgvGoiMon.RowTemplate.Height = 24;
            this.dgvGoiMon.Size = new System.Drawing.Size(860, 288);
            this.dgvGoiMon.TabIndex = 1;
            this.dgvGoiMon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGoiMon_CellContentClick);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Teal;
            this.btnMenu.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnMenu.FlatAppearance.BorderSize = 2;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Rockwell Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.ImageIndex = 109;
            this.btnMenu.ImageList = this.imageList1;
            this.btnMenu.Location = new System.Drawing.Point(955, 361);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(180, 60);
            this.btnMenu.TabIndex = 3;
            this.btnMenu.Text = "Menu";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "48px-Crystal_Clear_action_db_add.png");
            this.imageList1.Images.SetKeyName(1, "48px-Crystal_Clear_action_exit.png");
            this.imageList1.Images.SetKeyName(2, "48px-Crystal_Clear_action_exit1.png");
            this.imageList1.Images.SetKeyName(3, "48px-Crystal_Clear_action_reload.png");
            this.imageList1.Images.SetKeyName(4, "48px-Crystal_Clear_action_stop.png");
            this.imageList1.Images.SetKeyName(5, "48px-Crystal_Clear_app_package_settings.png");
            this.imageList1.Images.SetKeyName(6, "1598352.jpg");
            this.imageList1.Images.SetKeyName(7, "1436969100_shop.png");
            this.imageList1.Images.SetKeyName(8, "1437481933_dollar__.png");
            this.imageList1.Images.SetKeyName(9, "1437482150_corbeille box sale.png");
            this.imageList1.Images.SetKeyName(10, "1437482686_sale-pointer.png");
            this.imageList1.Images.SetKeyName(11, "1438980118_search-icon-tm.png");
            this.imageList1.Images.SetKeyName(12, "1439854729_DeleteRed.png");
            this.imageList1.Images.SetKeyName(13, "1439855724_1-04.png");
            this.imageList1.Images.SetKeyName(14, "1439855765_1-04.png");
            this.imageList1.Images.SetKeyName(15, "1439855765_1-041.png");
            this.imageList1.Images.SetKeyName(16, "1439989152_vector_66_15.png");
            this.imageList1.Images.SetKeyName(17, "1439989214_vector_66_15.png");
            this.imageList1.Images.SetKeyName(18, "coollogo_com-2977885.gif");
            this.imageList1.Images.SetKeyName(19, "coollogo_com-5747582.gif");
            this.imageList1.Images.SetKeyName(20, "coollogo_com-6678794.png");
            this.imageList1.Images.SetKeyName(21, "coollogo_com-9853743.gif");
            this.imageList1.Images.SetKeyName(22, "coollogo_com-10784956.png");
            this.imageList1.Images.SetKeyName(23, "coollogo_com-10789656.png");
            this.imageList1.Images.SetKeyName(24, "coollogo_com-10918245.gif");
            this.imageList1.Images.SetKeyName(25, "coollogo_com-11190812.png");
            this.imageList1.Images.SetKeyName(26, "coollogo_com-13829780.gif");
            this.imageList1.Images.SetKeyName(27, "coollogo_com-22053149.gif");
            this.imageList1.Images.SetKeyName(28, "coollogo_com-22053489.gif");
            this.imageList1.Images.SetKeyName(29, "coollogo_com-29778851.gif");
            this.imageList1.Images.SetKeyName(30, "coollogo_com-29778852.gif");
            this.imageList1.Images.SetKeyName(31, "coollogo_com-40634744.gif");
            this.imageList1.Images.SetKeyName(32, "coollogo_com-71431562.gif");
            this.imageList1.Images.SetKeyName(33, "coollogo_com-73171719.gif");
            this.imageList1.Images.SetKeyName(34, "coollogo_com-87711597.gif");
            this.imageList1.Images.SetKeyName(35, "coollogo_com-87791472.gif");
            this.imageList1.Images.SetKeyName(36, "coollogo_com-98537431.gif");
            this.imageList1.Images.SetKeyName(37, "coollogo_com-111908121.png");
            this.imageList1.Images.SetKeyName(38, "coollogo_com-117324098.gif");
            this.imageList1.Images.SetKeyName(39, "coollogo_com-199112098.gif");
            this.imageList1.Images.SetKeyName(40, "coollogo_com-204993751.gif");
            this.imageList1.Images.SetKeyName(41, "coollogo_com-289184551.gif");
            this.imageList1.Images.SetKeyName(42, "coollogo_com-289623476.gif");
            this.imageList1.Images.SetKeyName(43, "coollogo_com-289623578.gif");
            this.imageList1.Images.SetKeyName(44, "coollogo_com-731717191.gif");
            this.imageList1.Images.SetKeyName(45, "coollogo_com-877914721.gif");
            this.imageList1.Images.SetKeyName(46, "coollogo_com-1173240981.gif");
            this.imageList1.Images.SetKeyName(47, "d.bmp");
            this.imageList1.Images.SetKeyName(48, "d1.bmp");
            this.imageList1.Images.SetKeyName(49, "duo.bmp");
            this.imageList1.Images.SetKeyName(50, "Fasticon-Shop-Cart-Shop-cart-add.ico");
            this.imageList1.Images.SetKeyName(51, "gray.png");
            this.imageList1.Images.SetKeyName(52, "grey-background-2-free-hd-background-and-wallpaper.gif");
            this.imageList1.Images.SetKeyName(53, "home_w (1).ico");
            this.imageList1.Images.SetKeyName(54, "home_w (1).png");
            this.imageList1.Images.SetKeyName(55, "home_w.ico");
            this.imageList1.Images.SetKeyName(56, "home_w.png");
            this.imageList1.Images.SetKeyName(57, "home_w1.ico");
            this.imageList1.Images.SetKeyName(58, "home_w1.png");
            this.imageList1.Images.SetKeyName(59, "money.png");
            this.imageList1.Images.SetKeyName(60, "money1.png");
            this.imageList1.Images.SetKeyName(61, "muahang.png");
            this.imageList1.Images.SetKeyName(62, "payment-icon.png");
            this.imageList1.Images.SetKeyName(63, "Plain Blak Gray.jpg");
            this.imageList1.Images.SetKeyName(64, "pvd.ico");
            this.imageList1.Images.SetKeyName(65, "pvd.png");
            this.imageList1.Images.SetKeyName(66, "pvd1.ico");
            this.imageList1.Images.SetKeyName(67, "pvd2.bmp");
            this.imageList1.Images.SetKeyName(68, "pvd2.ico");
            this.imageList1.Images.SetKeyName(69, "pvd3.bmp");
            this.imageList1.Images.SetKeyName(70, "pvd3.ico");
            this.imageList1.Images.SetKeyName(71, "pvd4.ico");
            this.imageList1.Images.SetKeyName(72, "pvd21.bmp");
            this.imageList1.Images.SetKeyName(73, "save.png");
            this.imageList1.Images.SetKeyName(74, "save1.png");
            this.imageList1.Images.SetKeyName(75, "Save-as-icon.png");
            this.imageList1.Images.SetKeyName(76, "search-ltr.png");
            this.imageList1.Images.SetKeyName(77, "shop-cart-add-icon.png");
            this.imageList1.Images.SetKeyName(78, "supermarket_background_by_vigorousjammer-d4oivv5.png");
            this.imageList1.Images.SetKeyName(79, "supermarket_background_by_vigorousjammer-d4oivv51.png");
            this.imageList1.Images.SetKeyName(80, "Bánh Mỳ.jpg");
            this.imageList1.Images.SetKeyName(81, "cafe-catering-logo-clip-art-png-favpng-Ar3x542hM2QyPWdFnF46TtzHw.jpg");
            this.imageList1.Images.SetKeyName(82, "coffee-cup-icon.jpg");
            this.imageList1.Images.SetKeyName(83, "coffee-vector_1.jpg");
            this.imageList1.Images.SetKeyName(84, "menubar.png");
            this.imageList1.Images.SetKeyName(85, "Mỳ.jpg");
            this.imageList1.Images.SetKeyName(86, "nước.png");
            this.imageList1.Images.SetKeyName(87, "table.jpg");
            this.imageList1.Images.SetKeyName(88, "table2.jpg");
            this.imageList1.Images.SetKeyName(89, "Tra Tien.jpg");
            this.imageList1.Images.SetKeyName(90, "app_icon.ico");
            this.imageList1.Images.SetKeyName(91, "banh-xeo.jpg");
            this.imageList1.Images.SetKeyName(92, "bun-mam.jpg");
            this.imageList1.Images.SetKeyName(93, "bun-rieu-cua.jpg");
            this.imageList1.Images.SetKeyName(94, "ca-kho-to.jpg");
            this.imageList1.Images.SetKeyName(95, "canh-chua-ca-loc.jpg");
            this.imageList1.Images.SetKeyName(96, "cocacola.jpg");
            this.imageList1.Images.SetKeyName(97, "com-chien-ca-man.jpg");
            this.imageList1.Images.SetKeyName(98, "com-suon.jpg");
            this.imageList1.Images.SetKeyName(99, "hu-tieu-nam-vang.jpg");
            this.imageList1.Images.SetKeyName(100, "lau-bo.jpg");
            this.imageList1.Images.SetKeyName(101, "lau-mam.jpg");
            this.imageList1.Images.SetKeyName(102, "mirinda-cam.jpg");
            this.imageList1.Images.SetKeyName(103, "mirinda-soda-kem.jpg");
            this.imageList1.Images.SetKeyName(104, "placeholder.png");
            this.imageList1.Images.SetKeyName(105, "suon-cay-chien-xa.jpg");
            this.imageList1.Images.SetKeyName(106, "suon-non-xao-chua-ngot.jpg");
            this.imageList1.Images.SetKeyName(107, "Goi mon.png");
            this.imageList1.Images.SetKeyName(108, "d5e7ca3deb0598b8d7a974ea65c29572.jpg");
            this.imageList1.Images.SetKeyName(109, "menu.png");
            this.imageList1.Images.SetKeyName(110, "pngtree-restaurant-logo-design-vector-template-image_388753.jpg");
            this.imageList1.Images.SetKeyName(111, "pngtree-black-printer-hand-drawn-printer-office-printer-printer-illustration-png-" +
        "image_456879.jpg");
            // 
            // lbltenTongTien
            // 
            this.lbltenTongTien.AutoSize = true;
            this.lbltenTongTien.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbltenTongTien.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltenTongTien.ForeColor = System.Drawing.Color.Green;
            this.lbltenTongTien.Location = new System.Drawing.Point(3, 18);
            this.lbltenTongTien.Name = "lbltenTongTien";
            this.lbltenTongTien.Size = new System.Drawing.Size(206, 23);
            this.lbltenTongTien.TabIndex = 4;
            this.lbltenTongTien.Text = "Tổng Tiền Thanh Toán:";
            this.lbltenTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblThanhToan);
            this.groupBox1.Controls.Add(this.lbltenTongTien);
            this.groupBox1.Location = new System.Drawing.Point(1196, 306);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 49);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // lblThanhToan
            // 
            this.lblThanhToan.AutoSize = true;
            this.lblThanhToan.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhToan.ForeColor = System.Drawing.Color.Crimson;
            this.lblThanhToan.Location = new System.Drawing.Point(218, 9);
            this.lblThanhToan.Name = "lblThanhToan";
            this.lblThanhToan.Size = new System.Drawing.Size(0, 23);
            this.lblThanhToan.TabIndex = 4;
            // 
            // pnlGoiMon
            // 
            this.pnlGoiMon.Location = new System.Drawing.Point(549, 437);
            this.pnlGoiMon.Name = "pnlGoiMon";
            this.pnlGoiMon.Size = new System.Drawing.Size(1235, 280);
            this.pnlGoiMon.TabIndex = 6;
            // 
            // btnGoiMon
            // 
            this.btnGoiMon.BackColor = System.Drawing.Color.Teal;
            this.btnGoiMon.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnGoiMon.FlatAppearance.BorderSize = 2;
            this.btnGoiMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoiMon.Font = new System.Drawing.Font("Rockwell Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoiMon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGoiMon.ImageIndex = 81;
            this.btnGoiMon.ImageList = this.imageList1;
            this.btnGoiMon.Location = new System.Drawing.Point(1168, 361);
            this.btnGoiMon.Name = "btnGoiMon";
            this.btnGoiMon.Size = new System.Drawing.Size(180, 60);
            this.btnGoiMon.TabIndex = 3;
            this.btnGoiMon.Text = "Gọi Món";
            this.btnGoiMon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGoiMon.UseVisualStyleBackColor = false;
            this.btnGoiMon.Click += new System.EventHandler(this.btnGoiMon_Click);
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.BackColor = System.Drawing.Color.Teal;
            this.btnTinhTien.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnTinhTien.FlatAppearance.BorderSize = 2;
            this.btnTinhTien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTinhTien.Font = new System.Drawing.Font("Rockwell Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhTien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTinhTien.ImageIndex = 89;
            this.btnTinhTien.ImageList = this.imageList1;
            this.btnTinhTien.Location = new System.Drawing.Point(1381, 361);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(180, 60);
            this.btnTinhTien.TabIndex = 3;
            this.btnTinhTien.Text = "Tính Tiền";
            this.btnTinhTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTinhTien.UseVisualStyleBackColor = false;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.BackColor = System.Drawing.Color.Teal;
            this.btnInHoaDon.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnInHoaDon.FlatAppearance.BorderSize = 2;
            this.btnInHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInHoaDon.Font = new System.Drawing.Font("Rockwell Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInHoaDon.ImageIndex = 111;
            this.btnInHoaDon.ImageList = this.imageList1;
            this.btnInHoaDon.Location = new System.Drawing.Point(1594, 361);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(180, 60);
            this.btnInHoaDon.TabIndex = 3;
            this.btnInHoaDon.Text = "In Hóa Đơn";
            this.btnInHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInHoaDon.UseVisualStyleBackColor = false;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // lblCuaListBox
            // 
            this.lblCuaListBox.AutoSize = true;
            this.lblCuaListBox.Location = new System.Drawing.Point(51, 28);
            this.lblCuaListBox.Name = "lblCuaListBox";
            this.lblCuaListBox.Size = new System.Drawing.Size(0, 17);
            this.lblCuaListBox.TabIndex = 8;
            // 
            // lblTenBanTrongListView
            // 
            this.lblTenBanTrongListView.AutoSize = true;
            this.lblTenBanTrongListView.Location = new System.Drawing.Point(3, 11);
            this.lblTenBanTrongListView.Name = "lblTenBanTrongListView";
            this.lblTenBanTrongListView.Size = new System.Drawing.Size(0, 17);
            this.lblTenBanTrongListView.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvGoiMon);
            this.groupBox3.Location = new System.Drawing.Point(546, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1241, 309);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // uctGoiMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblTenBanTrongListView);
            this.Controls.Add(this.lblCuaListBox);
            this.Controls.Add(this.pnlGoiMon);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnInHoaDon);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.btnGoiMon);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lvDanhSachBan);
            this.Name = "uctGoiMon";
            this.Size = new System.Drawing.Size(1787, 769);
            this.Load += new System.EventHandler(this.uctGoiMon_Load);
            this.cntxtmenuDSBan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoiMon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvDanhSachBan;
        private System.Windows.Forms.DataGridView dgvGoiMon;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lbltenTongTien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblThanhToan;
        private System.Windows.Forms.Panel pnlGoiMon;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnGoiMon;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.ContextMenuStrip cntxtmenuDSBan;
        private System.Windows.Forms.ToolStripMenuItem hiểnThịBànChưaCóNgườiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hIểnThịBànCóNgườiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtDanhSáchToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Label lblCuaListBox;
        private System.Windows.Forms.ToolStripMenuItem thêmBànMớiToolStripMenuItem;
        private System.Windows.Forms.Label lblTenBanTrongListView;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}
