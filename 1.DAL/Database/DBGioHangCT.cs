using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace _1.DAL.Database
{
    internal class DBGioHangCT : IEntityTypeConfiguration<BangGioHangChiTiet>
    {
        public void Configure(EntityTypeBuilder<BangGioHangChiTiet> builder)
        {
            builder.ToTable("GioHangCT");
            builder.HasKey(x => new {x.IdCTSP,x.IdGioHang}); ;
            builder.Property(p => p.IdCTSP).IsRequired();
            builder.Property(p => p.IdGioHang).IsRequired();
            builder.HasOne(x => x.GioHang).WithMany().HasForeignKey(x => x.IdGioHang);
            builder.HasOne(x => x.CTSanPham).WithMany().HasForeignKey(x => x.IdCTSP);
            builder.Property(p => p.SoLuong).HasColumnType("int").IsRequired();
            builder.Property(p => p.DonGia).HasColumnType("decimal").IsRequired();
        }
    }
}
