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
    public partial class UserControlQuanLyThuoc : UserControl
    {
        public UserControlQuanLyThuoc()
        {
            InitializeComponent();
            DataGrid_QuanLyThuoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        DentalClinicDataContext dentalClinic = new DentalClinicDataContext();

        private void UserControlQuanLyThuoc_Load(object sender, EventArgs e)
        {
            var medicines = from all in dentalClinic.Medicines
                            join t in dentalClinic.TypeMedicines on all.TypeMedicineId equals t.TypeMedicineId
                            select new
                            {
                                MaThuoc = all.MedicineId,
                                TenThuoc = all.nameMedicine,
                                SoLuong = all.quantity,
                                NgayHetHan = all.expirationDate,
                                DonViTinh = all.unit,
                                LoaiThuoc = t.nameTypeOfMedicine
                            };

            DataGrid_QuanLyThuoc.DataSource = medicines;

        }




       

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "" || txtTimKiem.Text == "Tìm kiếm")
            {
                var medicines = from all in dentalClinic.Medicines
                                join t in dentalClinic.TypeMedicines on all.TypeMedicineId equals t.TypeMedicineId
                                select new
                                {
                                    MaThuoc = all.MedicineId,
                                    TenThuoc = all.nameMedicine,

                                    NgayHetHan = all.expirationDate,
                                    DonViTinh = all.unit,
                                    LoaiThuoc = t.nameTypeOfMedicine
                                };

                DataGrid_QuanLyThuoc.DataSource = medicines;
            }
            else
            {
                var list = from s in dentalClinic.Medicines
                           join t in dentalClinic.TypeMedicines on s.TypeMedicineId equals t.TypeMedicineId
                           where s.nameMedicine.Contains(txtTimKiem.Text) || s.MedicineId.Contains(txtTimKiem.Text)
                           select new
                           {
                               MaThuoc = s.MedicineId,
                               TenThuoc = s.nameMedicine,

                               NgayHetHan = s.expirationDate,
                               DonViTinh = s.unit,
                               LoaiThuoc = t.nameTypeOfMedicine
                           };
                DataGrid_QuanLyThuoc.DataSource = list;
            }
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddThuoc add = new FormAddThuoc();
            add.click_CloseForm += Add_click_CloseForm;
            add.ShowDialog();
        }

        private void Add_click_CloseForm(object sender, EventArgs e)
        {
            this.UserControlQuanLyThuoc_Load(sender, e);
        }
        FormEditThuoc edit = new FormEditThuoc();

        private void Edit_click_CloseForm(object sender, EventArgs e)
        {
            this.UserControlQuanLyThuoc_Load(sender, e);
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {

            edit.click_CloseForm += Edit_click_CloseForm;
            //edit.txtMaThuoc.Enabled = false;
            edit.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Medicine medicine = new Medicine();
            medicine = dentalClinic.Medicines.Where(s => s.MedicineId == Cons.temp).Single();
            dentalClinic.Medicines.DeleteOnSubmit(medicine);
            dentalClinic.SubmitChanges();
            UserControlQuanLyThuoc_Load(sender, e);
        }
        private void DataGrid_QuanLyThuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Frm_EditThuoc edit = new Frm_EditThuoc();
            int i = DataGrid_QuanLyThuoc.CurrentCell.RowIndex;
            edit.txtMaThuoc.Text = DataGrid_QuanLyThuoc.Rows[i].Cells[0].Value.ToString();
            edit.txtTenThuoc.Text = DataGrid_QuanLyThuoc.Rows[i].Cells[1].Value.ToString();
            edit.txtSoLuong.Text = DataGrid_QuanLyThuoc.Rows[i].Cells[2].Value.ToString();
            edit.dtpkHanSuDung.Text = DataGrid_QuanLyThuoc.Rows[i].Cells[3].Value.ToString();
            edit.txtDonViTinh.Text = DataGrid_QuanLyThuoc.Rows[i].Cells[4].Value.ToString();
            edit.cbLoaiThuoc.Text = DataGrid_QuanLyThuoc.Rows[i].Cells[5].Value.ToString();
            Cons.temp = DataGrid_QuanLyThuoc.Rows[i].Cells[0].Value.ToString();
        }



        private void txtTimKiem_KeyDown(object sender, EventArgs e)
        {
            if (txtTimKiem.Text  == "Tìm kiếm")
            {
                txtTimKiem.Text = "";
            }
        }

        private void txtTimKiem_KeyUp(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                txtTimKiem.Text = "Tìm kiếm";
            }
        }

        
    }

}
