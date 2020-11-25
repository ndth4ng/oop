using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP8
{
    class ConNguoi
    {
        private string ten;
        private int tuoi;

        public ConNguoi() : this("",0) { }

        public ConNguoi(string _ten, int _tuoi)
        {
            Ten = _ten;
            Tuoi = _tuoi;
        }

        public string Ten { get => ten; set => ten = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
    }
}
