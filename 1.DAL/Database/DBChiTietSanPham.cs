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
    internal class DBChiTietSanPham : IEntityTypeConfiguration<BangChiTietSanPham>
    {
        public void Configure(EntityTypeBuilder<BangChiTietSanPham> builder)
        {
            builder.ToTable("ChiTietSP");
            builder.HasKey(x => x.Id);
            builder.Property(p => p.IdLoai).IsRequired();
            builder.Property(p => p.IdHang).IsRequired();
            builder.Property(p => p.IdSp).IsRequired();
            builder.Property(p => p.IdMauSac).IsRequired();
            // cột Loại sản phẩm
            builder.HasOne(x => x.LoaiSP).WithMany().HasForeignKey(p => p.IdLoai);
            // cột Màu sắc
            builder.HasOne(x => x.MauSac)
            .WithMany().HasForeignKey(p => p.IdMauSac);
            // cột Sản phẩm
            builder.HasOne(x => x.SanPham)
           .WithMany().HasForeignKey(p => p.IdSp);
            // cột Hãng sản phẩm
            builder.HasOne(x => x.HangSP)
           .WithMany().HasForeignKey(p => p.IdHang);
            // cột Số lượng tồn
            builder.Property(p => p.Soluongton).HasColumnName("Soluongton").HasColumnType("int").IsRequired();
            // cột Mô tả
            builder.Property(p => p.Mota).HasColumnName("Mota").HasColumnType("nvarchar(300)").IsRequired();
            // cột Giá nhập
            builder.Property(p => p.GiaNhap).HasColumnName("GiaNhap").HasColumnType("decimal(20, 0)");
            // cột Giá bán
            builder.Property(p => p.GiaBan).HasColumnName("GiaBan").HasColumnType("decimal(20, 0)");
            // cột Size

            builder.Property(p => p.Size).HasColumnName("Size").HasColumnType("int"); ;
        }
    }
}
