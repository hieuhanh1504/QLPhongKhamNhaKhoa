using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QLPhongKhamNhaKhoa
{
    public partial class FormEditThuoc : Form
    {
        DentalClinicDataContext dental = new DentalClinicDataContext();

        public FormEditThuoc()
        {
            InitializeComponent();
            var type = from a in dental.TypeMedicines

                       select new
                       {
                           a.TypeMedicineId,
                           a.nameTypeOfMedicine
                       };
            cbLoaiThuoc.DataSource = type.ToList();
            cbLoaiThuoc.DisplayMember = "nameTypeOfMedicine";
            cbLoaiThuoc.ValueMember = "TypeMedicineId";

        }

        public event EventHandler click_CloseForm = null;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                Medicine medicine = new Medicine();
                medicine = dental.Medicines.Where(ma => ma.MedicineId == Cons.temp).Single();
                medicine.MedicineId = txtMaThuoc.Text;
                medicine.nameMedicine = txtTenThuoc.Text;
                medicine.quantity = int.Parse(txtSoLuong.Text);
                medicine.expirationDate = dtpkHanSuDung.Value;
                medicine.unit = txtDonViTinh.Text;
                medicine.price = decimal.Parse(txtDonGia.Text);
                medicine.TypeMedicineId = cbLoaiThuoc.SelectedValue.ToString();
                dental.SubmitChanges();
                click_CloseForm(sender, e);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu mời bạn kiểm tra lại", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
