using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class BangChiTietSanPham
    {
        public Guid Id { get; set; }
        public Guid IdSp { get; set; }
        public Guid IdLoai { get; set; }
        public Guid IdMauSac { get; set; }
        public Guid IdHang { get; set; }
        public int Soluongton { get; set; }
        public string Mota { get; set; }
        public decimal GiaNhap { get; set; }
        public decimal GiaBan { get; set; }
        public int Size { get; set; }
        public virtual BangLoaiSP? LoaiSP { get; set; }
        public virtual BangMauSac? MauSac { get; set; }
        public virtual BangSanPham? SanPham { get; set; }
        public virtual BangHangSanPham? HangSP { get; set; }

    }
}
