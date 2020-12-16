using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
   public class BEL_tacgia
    {
       private string ma_tac_gia;
       private string ten_tac_gia;
       private string tieu_su;
       private bool da_xoa;
       public BEL_tacgia() {
           this.ma_tac_gia = "";
           this.ten_tac_gia = "";
           this.tieu_su = "";
           this.da_xoa = false;
       }
       public BEL_tacgia(string matacgia, string tentacgia , string tieusu, bool daxoa) {
           this.ma_tac_gia = matacgia;
           this.ten_tac_gia = tentacgia;
           this.tieu_su = tieusu;
           this.da_xoa = daxoa;
       }
       public string Matacgia {
           get { return ma_tac_gia; }
           set { ma_tac_gia = value; }
       }
       public string Tentacgia
       {
           get { return ten_tac_gia; }
           set { ten_tac_gia = value; }
       }
       public string Tieusu
       {
           get { return tieu_su; }
           set { tieu_su = value; }
       }
       public bool Daxoa
       {
           get { return da_xoa; }
           set { da_xoa = value; }
       }
    }
}
