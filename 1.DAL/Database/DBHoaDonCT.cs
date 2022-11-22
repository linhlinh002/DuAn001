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
    internal class DBHoaDonCT : IEntityTypeConfiguration<BangHoaDonCT>
    {
        public void Configure(EntityTypeBuilder<BangHoaDonCT> builder)
        {
            builder.ToTable("HoaDonChiTiet");
            builder.HasKey(x => new{ x.IDCTSP,x.IdHoaDon});
            builder.Property(p => p.IDKM).IsRequired();
            builder.Property(p => p.IDCTSP).IsRequired();
            builder.Property(p => p.IdHoaDon).IsRequired();
            builder.HasOne(p => p.KhuyenMai).WithMany().HasForeignKey(p => p.IDKM);
            builder.HasOne(p => p.CTSanPham).WithMany().HasForeignKey(p => p.IDCTSP);
            builder.HasOne(p => p.HoaDon).WithMany().HasForeignKey(p => p.IdHoaDon);
            builder.Property(p => p.SoLuong).HasColumnName("SoLuong").HasColumnType("int");
            builder.Property(p => p.Mota).HasColumnName("MoTa").HasColumnType("nvarchar(50)");
            builder.Property(p => p.DonGia).HasColumnName("DonGia").HasColumnType("decimal");
        }
    }
}
