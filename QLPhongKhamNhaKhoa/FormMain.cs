using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPhongKhamNhaKhoa
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnQuanLyThuoc_Click(object sender, EventArgs e)
        {
            panel_Select.Top = btnQuanLyThuoc.Top;
            UserControlQuanLyThuoc userControl_QuanLyThuoc = new UserControlQuanLyThuoc();
            panel_HienThi.Controls.Clear();
            panel_HienThi.Controls.Add(userControl_QuanLyThuoc);
            userControl_QuanLyThuoc.Dock = DockStyle.Fill;
        }

       
    }
}
