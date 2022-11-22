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
    internal class DBSanPham : IEntityTypeConfiguration<BangSanPham>
    {
        public void Configure(EntityTypeBuilder<BangSanPham> builder)
        {
            builder.ToTable("SanPham");
            builder.HasKey(x => x.Id);
            builder.Property(p => p.MaSP).HasColumnName("MaSp").HasColumnType("nvarchar(30)").IsRequired();
            builder.Property(p => p.TenSP).HasColumnName("TenSP").HasColumnType("nvarchar(300)").IsRequired();
        }
    }
}
