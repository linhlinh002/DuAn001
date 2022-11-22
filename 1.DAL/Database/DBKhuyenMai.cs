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
    internal class DBKhuyenMai : IEntityTypeConfiguration<BangKhuyenMai>
    {
        public void Configure(EntityTypeBuilder<BangKhuyenMai> builder)
        {
            builder.ToTable("KhuyenMai");
            builder.HasKey(x => x.Id);
            builder.Property(p => p.MaKM).HasColumnName("MaKhuyenMai").HasColumnType("nvarchar(30)").IsRequired();
            builder.Property(p => p.MotaKM).HasColumnName("MotaKM").HasColumnType("nvarchar(300)").IsRequired();
        }
    }
}
