namespace QLPhongKhamNhaKhoa
{
    partial class UserControlQuanLyThuoc
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
            this.panel_Title_BenhNhan = new System.Windows.Forms.Panel();
            this.DataGrid_QuanLyThuoc = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnEdit = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_QuanLyThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Title_BenhNhan
            // 
            this.panel_Title_BenhNhan.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel_Title_BenhNhan.Location = new System.Drawing.Point(0, 3);
            this.panel_Title_BenhNhan.Name = "panel_Title_BenhNhan";
            this.panel_Title_BenhNhan.Size = new System.Drawing.Size(859, 53);
            this.panel_Title_BenhNhan.TabIndex = 0;
            // 
            // DataGrid_QuanLyThuoc
            // 
            this.DataGrid_QuanLyThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_QuanLyThuoc.Location = new System.Drawing.Point(3, 268);
            this.DataGrid_QuanLyThuoc.Name = "DataGrid_QuanLyThuoc";
            this.DataGrid_QuanLyThuoc.RowHeadersWidth = 62;
            this.DataGrid_QuanLyThuoc.RowTemplate.Height = 28;
            this.DataGrid_QuanLyThuoc.Size = new System.Drawing.Size(993, 308);
            this.DataGrid_QuanLyThuoc.TabIndex = 1;
            this.DataGrid_QuanLyThuoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_QuanLyThuoc_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(230, 179);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 64);
            this.label1.TabIndex = 13;
            this.label1.Text = "Quản lý thuốc";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(557, 75);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(250, 26);
            this.txtTimKiem.TabIndex = 14;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::QLPhongKhamNhaKhoa.Properties.Resources.Edit_File_26px;
            this.btnEdit.Location = new System.Drawing.Point(291, 62);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(49, 59);
            this.btnEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEdit.TabIndex = 17;
            this.btnEdit.TabStop = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::QLPhongKhamNhaKhoa.Properties.Resources.Delete_File_26px;
            this.btnDelete.Location = new System.Drawing.Point(376, 62);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(49, 59);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDelete.TabIndex = 16;
            this.btnDelete.TabStop = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::QLPhongKhamNhaKhoa.Properties.Resources.Add_File_26px;
            this.btnAdd.Location = new System.Drawing.Point(202, 62);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(49, 59);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdd.TabIndex = 15;
            this.btnAdd.TabStop = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // UserControlQuanLyThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGrid_QuanLyThuoc);
            this.Controls.Add(this.panel_Title_BenhNhan);
            this.Name = "UserControlQuanLyThuoc";
            this.Size = new System.Drawing.Size(1020, 608);
            this.Load += new System.EventHandler(this.UserControlQuanLyThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_QuanLyThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Title_BenhNhan;
        private System.Windows.Forms.DataGridView DataGrid_QuanLyThuoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox btnAdd;
        private System.Windows.Forms.PictureBox btnDelete;
        private System.Windows.Forms.PictureBox btnEdit;
    }
}
