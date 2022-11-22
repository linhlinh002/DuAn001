using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class BangHoaDonCT
    {
        public Guid IdHoaDon { get; set; }
        public Guid IDKM { get; set; }
        public Guid IDCTSP { get; set; }
        public int SoLuong { get; set; }
        public string Mota { get; set; }
        public decimal DonGia { get; set; }
        public virtual BangHoaDon HoaDon { get; set; }
        public virtual BangKhuyenMai KhuyenMai { get; set; }
        public virtual BangChiTietSanPham CTSanPham { get; set; }
    }
}
