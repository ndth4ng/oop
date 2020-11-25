using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP8
{
    class CongTy : NhanVien
    {
        List<NhanVien> nvs;

        string tenCT;
        int mucGopChuan;
        int nganSach;
        int nguonThu;
        int nguonChi;

        public string TenCT { get => tenCT; set => tenCT = value; }
        public int MucGopChuan { get => mucGopChuan; set => mucGopChuan = value; }
        public int NganSach { get => nganSach; set => nganSach = value; }
        public int NguonThu { get => nguonThu; set => nguonThu = value; }
        public int NguonChi { get => nguonChi; set => nguonChi = value; }       

        public CongTy()
        {
            nvs = new List<NhanVien>();
        }

        public CongTy(string _tenCT, int _mucGopChuan, int _nganSach, int _nguonThu, int _nguonChi)
        {
            nvs = new List<NhanVien>();
            tenCT = _tenCT;
            mucGopChuan = _mucGopChuan;
            nganSach = _nganSach;
            nguonThu = _nguonThu;
            NguonChi = _nguonChi;
        }

        public void TuyenDung(NhanVien nv)
        {
            nvs.Add(nv);
        }

        public bool KiemTra(NhanVien nv)
        {
            if (nv.MucDongGop < mucGopChuan)
                return true;
            return false;
        }

        public void SaThai(NhanVien nv)
        {
            nvs.Remove(nv);
        }

        public void PhaSan()
        {
            int vonDieuLe = nganSach + TongMucDongGop() - nguonChi - TongLuong();
            if (vonDieuLe < 0)
                Console.WriteLine("Von dieu le = {0} - Cong ty pha san!",vonDieuLe);
            else
                Console.WriteLine("Von dieu le = {0} - Cong ty khong bi pha san!",vonDieuLe);
        }

        public int TongMucDongGop()
        {
            int tong = 0;
            foreach(NhanVien nv in nvs)
            {
                tong += nv.MucDongGop;
            }
            return tong;
        }

        public int TongLuong()
        {
            int tong = 0;
            foreach (NhanVien nv in nvs)
            {
                tong += nv.Luong;
            }
            return tong;
        }

        public List<NhanVien> getDSNV()
        {
            return nvs;
        }
    }
}
