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
    internal class DBLoaiSP : IEntityTypeConfiguration<BangLoaiSP>
    {
        public void Configure(EntityTypeBuilder<BangLoaiSP> builder)
        {
            builder.ToTable("LoaiSP");
            builder.HasKey(x => x.Id);
            builder.Property(p => p.MaLoai).HasColumnName("MaLoai").HasColumnType("nvarchar(30)").IsRequired();
            builder.Property(p => p.TenLoai).HasColumnName("TenLoai").HasColumnType("nvarchar(300)").IsRequired();
        }
    }
}
