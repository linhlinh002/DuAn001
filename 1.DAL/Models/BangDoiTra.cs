using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class BangDoiTra
    {
        public Guid Id { get; set; }
        public Guid IdKH { get; set; }
        public Guid IdHoaDon { get; set; }
        public string MaDoi { get; set; }
       public virtual BangKhachHang KhachHang { get; set; }
        public virtual BangHoaDon HoaDon { get; set; }
    }
}
