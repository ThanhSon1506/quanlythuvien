using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BEL_theloai
    {
        private string ma_the_loai;
        private string the_loai;
        bool da_xoa;
        public BEL_theloai()
        {
            this.ma_the_loai = "";
            this.the_loai = "";
            this.da_xoa = false;
        }

        public BEL_theloai(string _ma_the_loai, string _the_loai,bool _da_xoa)
        {
            this.ma_the_loai = _ma_the_loai;
            this.the_loai = _the_loai;
            this.da_xoa = _da_xoa;
        }

        public string Ma_the_loai
        {
            get { return ma_the_loai; }
            set { ma_the_loai= value;}
        }

        public string The_loai
        {
            get { return the_loai; }
            set { the_loai = value;}
        }
        public bool Da_xoa
        {
            get { return da_xoa; }
            set { da_xoa = value; }
        }
    }
}
