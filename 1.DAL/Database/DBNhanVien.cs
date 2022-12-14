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
    internal class DBNhanVien : IEntityTypeConfiguration<BangNhanVien>
    {
        public void Configure(EntityTypeBuilder<BangNhanVien> builder)
        {
            builder.ToTable("NhanVien");
            builder.HasKey(x => x.Id);
            builder.Property(p => p.IdCV).IsRequired();
            builder.HasOne(x => x.ChucVu).WithMany().HasForeignKey(p => p.IdCV);
            builder.Property(p => p.Ma).HasColumnName("Ma").HasColumnType("nvarchar(30)").IsRequired();
            builder.Property(p => p.Ho).HasColumnName("Ho").HasColumnType("nvarchar(30)").IsRequired();
            builder.Property(p => p.TenDem).HasColumnName("TenDem").HasColumnType("nvarchar(30)").IsRequired();
            builder.Property(p => p.Ten).HasColumnName("Ten").HasColumnType("nvarchar(30)").IsRequired();
            builder.Property(p => p.GioiTinh).HasColumnName("GioiTinh").HasColumnType("nvarchar(10)").IsRequired();
            builder.Property(p => p.NgaySinh).HasColumnName("NgaySinh").HasColumnType("Datetime").IsRequired();
            builder.Property(p => p.DiaChi).HasColumnName("DiaChi").HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(p => p.SDT).HasColumnName("SDT").HasColumnType("nvarchar(15)").IsRequired();
            builder.Property(p => p.MatKhau).HasColumnName("MatKhau").HasColumnType("nvarchar(15)").IsRequired();
            builder.Property(p => p.TrangThai).HasColumnName("TrangThai").HasColumnType("int").IsRequired();
        }
    }
}
