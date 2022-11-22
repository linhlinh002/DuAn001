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
    internal class DBHoaDon : IEntityTypeConfiguration<BangHoaDon>
    {
        public void Configure(EntityTypeBuilder<BangHoaDon> builder)
        {
            builder.ToTable("HoaDon");
            builder.HasKey(x => x.id);
            builder.Property(p => p.IdKH).IsRequired();
            builder.Property(p => p.IdNV).IsRequired();
            builder.HasOne(p => p.KhachHang).WithMany().HasForeignKey(p => p.IdKH);
            builder.HasOne(p => p.NhanVien).WithMany().HasForeignKey(p => p.IdNV);
            builder.Property(p => p.Ma).HasColumnName("MaHD").HasColumnType("nvarchar(20)").IsRequired();
            builder.Property(p => p.NgayTao).HasColumnName("NgayTao").HasColumnType("DateTime").IsRequired();
            builder.Property(p => p.NgayThanhToan).HasColumnName("NgayThanhToan").HasColumnType("DateTime").IsRequired();
            builder.Property(p => p.NgayShip).HasColumnName("NgayShip").HasColumnType("DateTime").IsRequired();
            builder.Property(p => p.NgayNhan).HasColumnName("NgayNhan").HasColumnType("DateTime").IsRequired();
            builder.Property(p => p.TinhTrang).HasColumnName("TinhTrang").HasColumnType("int").IsRequired();
            builder.Property(p => p.TenNguoiNhan).HasColumnName("NguoiNhan").HasColumnType("nvarchar(30)").IsRequired();
            builder.Property(p => p.SDT).HasColumnName("SDT").HasColumnType("nvarchar(20)").IsRequired();
            builder.Property(p => p.DiaChi).HasColumnName("DiaChi").HasColumnType("nvarchar(40)").IsRequired();
        }
    }
}
