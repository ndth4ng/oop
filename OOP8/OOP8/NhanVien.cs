using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP8
{
    class NhanVien : ConNguoi
    {
        private string maNV;
        private int luong;
        private int mucDongGop;

        public string MaNV { get => maNV; set => maNV = value; }
        public int Luong { get => luong; set => luong = value; }
        public int MucDongGop { get => mucDongGop; set => mucDongGop = value; }

        public NhanVien()
        {
            maNV = "";
            luong = 0;
            mucDongGop = 0;
        }

        public NhanVien(string _maNV, string _ten, int _tuoi, int _luong, int _mucDongGop):base(_ten,_tuoi)
        {
            maNV = _maNV;
            luong = _luong;
            mucDongGop = _mucDongGop;
        }
    }
}
