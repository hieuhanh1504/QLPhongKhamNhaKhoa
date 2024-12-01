namespace QLPhongKhamNhaKhoa
{
    partial class FormMain
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel_ChucNang = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQuanLyThuoc = new System.Windows.Forms.Button();
            this.panel_Select = new System.Windows.Forms.Panel();
            this.panel_HienThi = new System.Windows.Forms.Panel();
            this.panel_ChucNang.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel_ChucNang
            // 
            this.panel_ChucNang.BackColor = System.Drawing.Color.SteelBlue;
            this.panel_ChucNang.Controls.Add(this.panel1);
            this.panel_ChucNang.Controls.Add(this.panel_Select);
            this.panel_ChucNang.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_ChucNang.Location = new System.Drawing.Point(0, 0);
            this.panel_ChucNang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_ChucNang.Name = "panel_ChucNang";
            this.panel_ChucNang.Size = new System.Drawing.Size(280, 648);
            this.panel_ChucNang.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnQuanLyThuoc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 648);
            this.panel1.TabIndex = 5;
            // 
            // btnQuanLyThuoc
            // 
            this.btnQuanLyThuoc.Location = new System.Drawing.Point(0, 144);
            this.btnQuanLyThuoc.Name = "btnQuanLyThuoc";
            this.btnQuanLyThuoc.Size = new System.Drawing.Size(278, 59);
            this.btnQuanLyThuoc.TabIndex = 0;
            this.btnQuanLyThuoc.Text = "Quản lý thuốc";
            this.btnQuanLyThuoc.UseVisualStyleBackColor = true;
            this.btnQuanLyThuoc.Click += new System.EventHandler(this.btnQuanLyThuoc_Click);
            // 
            // panel_Select
            // 
            this.panel_Select.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel_Select.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel_Select.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel_Select.Location = new System.Drawing.Point(0, 89);
            this.panel_Select.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_Select.Name = "panel_Select";
            this.panel_Select.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel_Select.Size = new System.Drawing.Size(9, 60);
            this.panel_Select.TabIndex = 4;
            // 
            // panel_HienThi
            // 
            this.panel_HienThi.Location = new System.Drawing.Point(280, 0);
            this.panel_HienThi.Name = "panel_HienThi";
            this.panel_HienThi.Size = new System.Drawing.Size(1044, 645);
            this.panel_HienThi.TabIndex = 3;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 648);
            this.Controls.Add(this.panel_HienThi);
            this.Controls.Add(this.panel_ChucNang);
            this.Controls.Add(this.button1);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.panel_ChucNang.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel_ChucNang;
        private System.Windows.Forms.Panel panel_Select;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnQuanLyThuoc;
        private System.Windows.Forms.Panel panel_HienThi;
    }
}