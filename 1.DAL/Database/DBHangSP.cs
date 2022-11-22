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
    internal class DBHangSP : IEntityTypeConfiguration<BangHangSanPham>
    {
        public void Configure(EntityTypeBuilder<BangHangSanPham> builder)
        {
            builder.ToTable("HangSP");
            builder.HasKey(x => x.Id);
            builder.Property(p => p.MaHang).HasColumnName("MaHang").HasColumnType("nvarchar(30)").IsRequired();
            builder.Property(p => p.TenHang).HasColumnName("TenHang").HasColumnType("nvarchar(300)").IsRequired();
        }
    }
}
