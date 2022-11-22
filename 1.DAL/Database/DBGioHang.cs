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
    internal class DBGioHang : IEntityTypeConfiguration<BangGioHang>
    {
        public void Configure(EntityTypeBuilder<BangGioHang> builder)
        {
            builder.ToTable("GioHang");
            builder.HasKey(x => x.Id);
            builder.Property(p => p.IdNV).IsRequired();
            builder.Property(p => p.IdKH).IsRequired();
            builder.Property(p => p.Ma).HasColumnName("MaGioHang").HasColumnType("nvarchar(30)").IsRequired();
            builder.Property(p => p.NgayTao).HasColumnName("NgayTao").HasColumnType("DateTime").IsRequired();
            builder.Property(p => p.NgayThanhToan).HasColumnName("NgayThanhToan").HasColumnType("DateTime").IsRequired();
            builder.Property(p => p.NguoiNhan).HasColumnName("NguoiNhan").HasColumnType("nvarchar(300)").IsRequired();
            builder.Property(p => p.DiaChi).HasColumnName("DiaChi").HasColumnType("nvarchar(300)").IsRequired();
            builder.Property(p => p.SDT).HasColumnName("SDT").HasColumnType("nvarchar(30)").IsRequired();
            builder.Property(p => p.TinhTrang).HasColumnName("TinhTrang").HasColumnType("int").IsRequired();
            builder.HasOne(x => x.KhachHang).WithMany().HasForeignKey(p => p.IdKH);
            builder.HasOne(x => x.NhanVien).WithMany().HasForeignKey(p => p.IdNV);
        }
    }
}
