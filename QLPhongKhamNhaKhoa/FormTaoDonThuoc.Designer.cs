namespace QLPhongKhamNhaKhoa
{
    partial class FormTaoDonThuoc
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_Space = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lvs_ChiTietDonThuoc = new System.Windows.Forms.ListView();
            this.lbl_TenDonThuoc = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTenDon = new System.Windows.Forms.TextBox();
            this.btn_SuaDon = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.lsb_Thuoc = new System.Windows.Forms.ListBox();
            this.lbl_DanhSachChon = new System.Windows.Forms.Label();
            this.btn_TaoDon = new System.Windows.Forms.Button();
            this.btn_Chon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_SoLuong = new System.Windows.Forms.Label();
            this.lbl_Thuoc = new System.Windows.Forms.Label();
            this.cmb_Thuoc = new System.Windows.Forms.ComboBox();
            this.dgv_DonThuoc = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DonThuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 48);
            this.panel1.TabIndex = 19;
            // 
            // pnl_Space
            // 
            this.pnl_Space.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnl_Space.Location = new System.Drawing.Point(406, 58);
            this.pnl_Space.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_Space.Name = "pnl_Space";
            this.pnl_Space.Size = new System.Drawing.Size(24, 905);
            this.pnl_Space.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "Danh sách đơn thuốc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(637, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 29);
            this.label3.TabIndex = 28;
            this.label3.Text = "Chi tiết đơn thuốc";
            // 
            // lvs_ChiTietDonThuoc
            // 
            this.lvs_ChiTietDonThuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lvs_ChiTietDonThuoc.HideSelection = false;
            this.lvs_ChiTietDonThuoc.Location = new System.Drawing.Point(449, 85);
            this.lvs_ChiTietDonThuoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvs_ChiTietDonThuoc.MultiSelect = false;
            this.lvs_ChiTietDonThuoc.Name = "lvs_ChiTietDonThuoc";
            this.lvs_ChiTietDonThuoc.Size = new System.Drawing.Size(680, 184);
            this.lvs_ChiTietDonThuoc.TabIndex = 27;
            this.lvs_ChiTietDonThuoc.UseCompatibleStateImageBehavior = false;
            this.lvs_ChiTietDonThuoc.View = System.Windows.Forms.View.Details;
            // 
            // lbl_TenDonThuoc
            // 
            this.lbl_TenDonThuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_TenDonThuoc.AutoSize = true;
            this.lbl_TenDonThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenDonThuoc.Location = new System.Drawing.Point(1265, 530);
            this.lbl_TenDonThuoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TenDonThuoc.Name = "lbl_TenDonThuoc";
            this.lbl_TenDonThuoc.Size = new System.Drawing.Size(85, 25);
            this.lbl_TenDonThuoc.TabIndex = 26;
            this.lbl_TenDonThuoc.Text = "Tên đơn";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Enabled = false;
            this.txtSoLuong.Location = new System.Drawing.Point(1028, 434);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(88, 26);
            this.txtSoLuong.TabIndex = 40;
            this.txtSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSoLuong.Visible = false;
            // 
            // txtTenDon
            // 
            this.txtTenDon.Location = new System.Drawing.Point(926, 320);
            this.txtTenDon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenDon.Name = "txtTenDon";
            this.txtTenDon.Size = new System.Drawing.Size(190, 26);
            this.txtTenDon.TabIndex = 39;
            this.txtTenDon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_SuaDon
            // 
            this.btn_SuaDon.Location = new System.Drawing.Point(1028, 578);
            this.btn_SuaDon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_SuaDon.Name = "btn_SuaDon";
            this.btn_SuaDon.Size = new System.Drawing.Size(90, 71);
            this.btn_SuaDon.TabIndex = 37;
            this.btn_SuaDon.Text = "Sửa đơn";
            this.btn_SuaDon.UseVisualStyleBackColor = true;
            this.btn_SuaDon.Click += new System.EventHandler(this.btn_SuaDon_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(1028, 654);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(90, 71);
            this.btn_Xoa.TabIndex = 38;
            this.btn_Xoa.Text = "Xóa thuốc";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // lsb_Thuoc
            // 
            this.lsb_Thuoc.FormattingEnabled = true;
            this.lsb_Thuoc.ItemHeight = 20;
            this.lsb_Thuoc.Location = new System.Drawing.Point(449, 321);
            this.lsb_Thuoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lsb_Thuoc.Name = "lsb_Thuoc";
            this.lsb_Thuoc.Size = new System.Drawing.Size(354, 404);
            this.lsb_Thuoc.TabIndex = 36;
            this.lsb_Thuoc.Visible = false;
            // 
            // lbl_DanhSachChon
            // 
            this.lbl_DanhSachChon.AutoSize = true;
            this.lbl_DanhSachChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DanhSachChon.Location = new System.Drawing.Point(505, 274);
            this.lbl_DanhSachChon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DanhSachChon.Name = "lbl_DanhSachChon";
            this.lbl_DanhSachChon.Size = new System.Drawing.Size(183, 29);
            this.lbl_DanhSachChon.TabIndex = 35;
            this.lbl_DanhSachChon.Text = "Danh sách chọn";
            this.lbl_DanhSachChon.Visible = false;
            // 
            // btn_TaoDon
            // 
            this.btn_TaoDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_TaoDon.Location = new System.Drawing.Point(926, 578);
            this.btn_TaoDon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_TaoDon.Name = "btn_TaoDon";
            this.btn_TaoDon.Size = new System.Drawing.Size(93, 146);
            this.btn_TaoDon.TabIndex = 33;
            this.btn_TaoDon.Text = "Tạo đơn";
            this.btn_TaoDon.UseVisualStyleBackColor = true;
            this.btn_TaoDon.Click += new System.EventHandler(this.btn_TaoDon_Click);
            // 
            // btn_Chon
            // 
            this.btn_Chon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Chon.Enabled = false;
            this.btn_Chon.Location = new System.Drawing.Point(926, 500);
            this.btn_Chon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Chon.Name = "btn_Chon";
            this.btn_Chon.Size = new System.Drawing.Size(192, 69);
            this.btn_Chon.TabIndex = 34;
            this.btn_Chon.Text = "Chọn";
            this.btn_Chon.UseVisualStyleBackColor = true;
            this.btn_Chon.Visible = false;
            this.btn_Chon.Click += new System.EventHandler(this.btn_Chon_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(811, 321);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "Tên đơn";
            // 
            // lbl_SoLuong
            // 
            this.lbl_SoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_SoLuong.AutoSize = true;
            this.lbl_SoLuong.Enabled = false;
            this.lbl_SoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoLuong.Location = new System.Drawing.Point(823, 435);
            this.lbl_SoLuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SoLuong.Name = "lbl_SoLuong";
            this.lbl_SoLuong.Size = new System.Drawing.Size(90, 25);
            this.lbl_SoLuong.TabIndex = 31;
            this.lbl_SoLuong.Text = "Số lượng";
            this.lbl_SoLuong.Visible = false;
            // 
            // lbl_Thuoc
            // 
            this.lbl_Thuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Thuoc.AutoSize = true;
            this.lbl_Thuoc.Enabled = false;
            this.lbl_Thuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Thuoc.Location = new System.Drawing.Point(823, 376);
            this.lbl_Thuoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Thuoc.Name = "lbl_Thuoc";
            this.lbl_Thuoc.Size = new System.Drawing.Size(68, 25);
            this.lbl_Thuoc.TabIndex = 32;
            this.lbl_Thuoc.Text = "Thuốc";
            this.lbl_Thuoc.Visible = false;
            // 
            // cmb_Thuoc
            // 
            this.cmb_Thuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Thuoc.Enabled = false;
            this.cmb_Thuoc.FormattingEnabled = true;
            this.cmb_Thuoc.Location = new System.Drawing.Point(926, 377);
            this.cmb_Thuoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_Thuoc.Name = "cmb_Thuoc";
            this.cmb_Thuoc.Size = new System.Drawing.Size(190, 28);
            this.cmb_Thuoc.TabIndex = 29;
            this.cmb_Thuoc.Visible = false;
            // 
            // dgv_DonThuoc
            // 
            this.dgv_DonThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DonThuoc.Location = new System.Drawing.Point(0, 85);
            this.dgv_DonThuoc.Name = "dgv_DonThuoc";
            this.dgv_DonThuoc.RowHeadersWidth = 62;
            this.dgv_DonThuoc.RowTemplate.Height = 28;
            this.dgv_DonThuoc.Size = new System.Drawing.Size(399, 649);
            this.dgv_DonThuoc.TabIndex = 41;
            this.dgv_DonThuoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DonThuoc_CellContentClick);
            // 
            // FormTaoDonThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 738);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_DonThuoc);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtTenDon);
            this.Controls.Add(this.btn_SuaDon);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.lsb_Thuoc);
            this.Controls.Add(this.lbl_DanhSachChon);
            this.Controls.Add(this.btn_TaoDon);
            this.Controls.Add(this.btn_Chon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_SoLuong);
            this.Controls.Add(this.lbl_Thuoc);
            this.Controls.Add(this.cmb_Thuoc);
            this.Controls.Add(this.lvs_ChiTietDonThuoc);
            this.Controls.Add(this.lbl_TenDonThuoc);
            this.Controls.Add(this.pnl_Space);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "FormTaoDonThuoc";
            this.Text = "FormTaoDonThuoc";
            this.Load += new System.EventHandler(this.FormTaoDonThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DonThuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_Space;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvs_ChiTietDonThuoc;
        private System.Windows.Forms.Label lbl_TenDonThuoc;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTenDon;
        private System.Windows.Forms.Button btn_SuaDon;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.ListBox lsb_Thuoc;
        private System.Windows.Forms.Label lbl_DanhSachChon;
        private System.Windows.Forms.Button btn_TaoDon;
        private System.Windows.Forms.Button btn_Chon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_SoLuong;
        private System.Windows.Forms.Label lbl_Thuoc;
        private System.Windows.Forms.ComboBox cmb_Thuoc;
        private System.Windows.Forms.DataGridView dgv_DonThuoc;
    }
}