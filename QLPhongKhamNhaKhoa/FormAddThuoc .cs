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
    public partial class FormAddThuoc : Form
    {
        public FormAddThuoc()
        {
            InitializeComponent();

            DentalClinicDataContext dental = new DentalClinicDataContext();
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
                DentalClinicDataContext dental = new DentalClinicDataContext();
                Medicine medicine = new Medicine();
                medicine.MedicineId = txtMaThuoc.Text;
                medicine.nameMedicine = txtTenThuoc.Text;
                medicine.quantity = int.Parse(txtSoLuong.Text);
                medicine.expirationDate = dtpkHanSuDung.Value;
                medicine.unit = txtDonViTinh.Text;
                medicine.TypeMedicineId = cbLoaiThuoc.SelectedValue.ToString();
                medicine.price = decimal.Parse(txtDonGia.Text);
                dental.Medicines.InsertOnSubmit(medicine);
                dental.SubmitChanges();
                click_CloseForm(sender, e);
                this.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Yêu cầu nhập dúng định dạng!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
