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
    public partial class frmLopHoc : Form
    {
        private LopHocEntities2 database = new LopHocEntities2();
        public frmLopHoc()
        {
            InitializeComponent();
            LoadThongTinLop();
            ChangeGridViewHeaderName();
        }

        private void LoadThongTinLop()
        {
            var dsLopHoc = from lop in database.LOPHOCs
                           select new { MaLop = lop.MALOP, TenLop = lop.TENLOP };
            dgvLopHoc.DataSource = dsLopHoc.ToList();
            //Add binding
            AddLopHocBinding();
            
        }

        private void AddLopHocBinding()
        {
            //Refresh
            txtMaLop.DataBindings.Clear();
            txtTenLop.DataBindings.Clear();
            //Add
            txtMaLop.DataBindings.Add("Text", dgvLopHoc.DataSource, "MaLop");
            txtTenLop.DataBindings.Add("Text", dgvLopHoc.DataSource, "TenLop");
        }

        private void ChangeGridViewHeaderName()
        {
            dgvLopHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLopHoc.Columns[0].HeaderText = "Mã lớp";
            dgvLopHoc.Columns[1].HeaderText = "Ten lớp";
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            string MaLop = txtMaLop.Text;
            string TenLop = txtTenLop.Text;

            LOPHOC lop = database.LOPHOCs.Where(l => l.MALOP == MaLop).SingleOrDefault();
            if (lop != null)
            {
                MessageBox.Show("Mã lớp học đã tồn tại!");
                return;
            }
            else if (String.IsNullOrEmpty(MaLop) || String.IsNullOrEmpty(TenLop))
            {
                MessageBox.Show("Mã lớp hoặc Tên lớp không được để trống!");
                return;
            }
            else
            {
                lop = new LOPHOC();
                lop.MALOP = MaLop;
                lop.TENLOP = TenLop;
                database.LOPHOCs.Add(lop);
                database.SaveChanges();
                LoadThongTinLop();
                MessageBox.Show("Thêm lớp học mới thành công!");
            }
        }

        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            string MaLop = txtMaLop.Text;
            string TenLop = txtTenLop.Text;

            LOPHOC lop = database.LOPHOCs.Where(l => l.MALOP == MaLop).SingleOrDefault();
            if (lop == null)
            {
                MessageBox.Show("Mã lớp học không tồn tại!");
                return;
            }
            else if (String.IsNullOrEmpty(MaLop))
            {
                MessageBox.Show("Mã lớp cần xóa không được để trống!");
                return;
            }
            else
            {   if (lop.SINHVIENs.Count > 0)
                {
                    MessageBox.Show("Hãy xóa sinh viên trong lớp trước!");
                }
                database.LOPHOCs.Remove(lop);
                database.SaveChanges();
                LoadThongTinLop();
                MessageBox.Show("Xóa lớp học mới thành công!");
            }
        }

        private void btnSuaLop_Click(object sender, EventArgs e)
        {
            string MaLop = txtMaLop.Text;
            string TenLop = txtTenLop.Text;

            LOPHOC lop = database.LOPHOCs.Where(l => l.MALOP == MaLop).SingleOrDefault();
            if (lop == null)
            {
                MessageBox.Show("Mã lớp học không tồn tại!");
                return;
            }
            else if (String.IsNullOrEmpty(MaLop))
            {
                MessageBox.Show("Mã lớp cần sửa không được để trống!");
                return;
            }
            else
            {
                lop.TENLOP = TenLop;
                database.SaveChanges();
                LoadThongTinLop();
                MessageBox.Show("Cập nhật lớp học mới thành công!");
            }
        }

        private void btnQLSV_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSinhVien formSV = new frmSinhVien();
            formSV.ShowDialog();
            formSV = null;
            this.Show();
        }
    }
}
