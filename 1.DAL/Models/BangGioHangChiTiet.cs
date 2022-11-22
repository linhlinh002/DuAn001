using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class BangGioHangChiTiet
    {
        public Guid IdCTSP { get; set; }
        public Guid IdGioHang { get; set; }
        
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public virtual BangGioHang GioHang { get; set; }
        public virtual BangChiTietSanPham CTSanPham { get; set; }
    }
}
