using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLLopHoc.DAL;

namespace QLLopHoc
{
    public partial class frmSinhVien : Form
    {
        private LopHocEntities2 database = new LopHocEntities2();
        public frmSinhVien()
        {
            InitializeComponent();
            LoadThongTinSinhVien();
            ChangeGridViewHeaderName();
        }

        private void ChangeGridViewHeaderName()
        {         
            dgvSinhVien.Columns[0].HeaderText = "Mã lớp";
            dgvSinhVien.Columns[1].HeaderText = "Tên lớp";
            dgvSinhVien.Columns[2].HeaderText = "Địa chỉ";
            dgvSinhVien.Columns[3].HeaderText = "Tuổi";
            dgvSinhVien.Columns[4].HeaderText = "Lớp";
            dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvSinhVien.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void AddSinhVienBinding()
        {
            //Refresh
            txtMaSV.DataBindings.Clear();
            txtTenSV.DataBindings.Clear();
            txtTuoi.DataBindings.Clear();
            txtDiaChiSV.DataBindings.Clear();
            txtMaSV.DataBindings.Clear();
            cmbLopHoc.DataBindings.Clear();
            //Add
            txtMaSV.DataBindings.Add("Text", dgvSinhVien.DataSource, "MaSV");
            txtTenSV.DataBindings.Add("Text", dgvSinhVien.DataSource, "TenSV");
            txtTuoi.DataBindings.Add("Text", dgvSinhVien.DataSource, "Tuoi");
            txtDiaChiSV.DataBindings.Add("Text", dgvSinhVien.DataSource, "DiaChi");
            cmbLopHoc.DataBindings.Add("Text", dgvSinhVien.DataSource, "TenLop");
        }

        private void LoadThongTinSinhVien()
        {
            var dsSinhVien = from sv in database.SINHVIENs
                           select new { MaSV = sv.MASV, TenSV = sv.TENSV, DiaChi = sv.DIACHI, Tuoi = sv.TUOI, TenLop = sv.LOPHOC.TENLOP };
            dgvSinhVien.DataSource = dsSinhVien.ToList();
            cmbLopHoc.DataSource = database.LOPHOCs.ToList();
            cmbLopHoc.DisplayMember = "TenLop";
            //Add binding
            AddSinhVienBinding();
        }

        private void btnThemSV_Click(object sender, EventArgs e)
        {
            string MaSV = txtMaSV.Text;
            string TenSV = txtTenSV.Text;
            string TuoiSV = txtTuoi.Text;
            string DiaChi = txtDiaChiSV.Text;

            LOPHOC lop = cmbLopHoc.SelectedValue as LOPHOC;
            //
            SINHVIEN sv = database.SINHVIENs.Where(s => s.MASV == MaSV).SingleOrDefault();
            if (sv != null)
            {
                MessageBox.Show("Mã sinh viên đã tồn tại!");
                return;
            }
            else if (String.IsNullOrEmpty(MaSV) || String.IsNullOrEmpty(TenSV))
            {
                MessageBox.Show("Mã sinh viên hoặc Tên sinh viên không được để trống!");
                return;
            }
            else
            {
                sv = new SINHVIEN();
                sv.MASV = MaSV;
                sv.TENSV = TenSV;
                sv.DIACHI = DiaChi;
                sv.TUOI = Int32.Parse(TuoiSV);
                sv.LOPHOC = lop;

                database.SINHVIENs.Add(sv);
                database.SaveChanges();

                LoadThongTinSinhVien();
                MessageBox.Show("Thêm mới sinh viên thành công!");
            }
        }

        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            string MaSV = txtMaSV.Text;

            SINHVIEN sv = database.SINHVIENs.Where(s => s.MASV == MaSV).SingleOrDefault();
            if (sv != null)
            {
                MessageBox.Show("Mã sinh viên đã tồn tại!");
                return;
            }
            else if (String.IsNullOrEmpty(MaSV))
            {
                MessageBox.Show("Mã sinh viên cần xóa không được để trống!");
                return;
            }
            else
            {
                database.SINHVIENs.Remove(sv);
                database.SaveChanges();

                LoadThongTinSinhVien();
                MessageBox.Show("Xóa sinh viên thành công!");
            }
        }

        private void btnSuaSV_Click(object sender, EventArgs e)
        {
            string MaSV = txtMaSV.Text;
            string TenSV = txtTenSV.Text;
            string TuoiSV = txtTuoi.Text;
            string DiaChi = txtDiaChiSV.Text;

            LOPHOC lop = cmbLopHoc.SelectedValue as LOPHOC;
            SINHVIEN sv = database.SINHVIENs.Where(s => s.MASV == MaSV).SingleOrDefault();
            if (sv == null)
            {
                MessageBox.Show("Mã sinh viên không tồn tại!");
                return;
            }
            else if (String.IsNullOrEmpty(MaSV))
            {
                MessageBox.Show("Mã sinh viên cần sửa không được để trống!");
                return;
            }
            else
            {
                sv.TENSV = TenSV;
                sv.TUOI = Int32.Parse(TuoiSV);
                sv.DIACHI = DiaChi;
                sv.LOPHOC = lop;
                database.SaveChanges();
                LoadThongTinSinhVien();
                MessageBox.Show("Cập nhật lớp học mới thành công!");
            }
        }

        private void btnTimKiemDC_Click(object sender, EventArgs e)
        {
            var dsDiaChiSV = from sv in database.SINHVIENs
                             where sv.DIACHI == txtDiaChiSV.Text
                             select new { MaSV = sv.MASV, TenSV = sv.TENSV, DiaChi = sv.DIACHI, Tuoi = sv.TUOI, TenLop = sv.LOPHOC.TENLOP };

            dgvSinhVien.DataSource = dsDiaChiSV.ToList();
            cmbLopHoc.DataSource = database.LOPHOCs.ToList();
            cmbLopHoc.DisplayMember = "TenLop";
            //Add binding
            AddSinhVienBinding();
        }

        private void btnTimKiemTuoi_Click(object sender, EventArgs e)
        {
            var dsTuoiSV = from sv in database.SINHVIENs
                             where sv.TUOI.ToString() == txtTuoi.Text
                             select new { MaSV = sv.MASV, TenSV = sv.TENSV, DiaChi = sv.DIACHI, Tuoi = sv.TUOI, TenLop = sv.LOPHOC.TENLOP };

            dgvSinhVien.DataSource = dsTuoiSV.ToList();
            cmbLopHoc.DataSource = database.LOPHOCs.ToList();
            cmbLopHoc.DisplayMember = "TenLop";
            //Add binding
            AddSinhVienBinding();
        }

        private void btnTimKiemLop_Click(object sender, EventArgs e)
        {
            LOPHOC lop = cmbLopHoc.SelectedValue as LOPHOC;
            string maLop = lop.MALOP;
            var dsLopSV = from sv in database.SINHVIENs
                          where sv.MALOP == maLop 
                          select new { MaSV = sv.MASV, TenSV = sv.TENSV, DiaChi = sv.DIACHI, Tuoi = sv.TUOI, TenLop = sv.LOPHOC.TENLOP };

            dgvSinhVien.DataSource = dsLopSV.ToList();
            cmbLopHoc.DataSource = database.LOPHOCs.ToList();
            cmbLopHoc.DisplayMember = "TenLop";
            //Add binding
            AddSinhVienBinding();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadThongTinSinhVien();
        }
    }
}
