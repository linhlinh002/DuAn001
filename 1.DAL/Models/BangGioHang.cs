using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class BangGioHang
    {
        public Guid Id { get; set; }
        public Guid IdNV { get; set; }
        public Guid IdKH { get; set; }
        public string Ma { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public string NguoiNhan { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public int TinhTrang { get; set; }
        public virtual BangNhanVien NhanVien { get; set; }
        public virtual BangKhachHang KhachHang { get; set; }
    }
}
