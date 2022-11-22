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
    internal class DBChucVu : IEntityTypeConfiguration<BangChucVu>
    {
        public void Configure(EntityTypeBuilder<BangChucVu> builder)
        {
            builder.ToTable("ChucVu");
            builder.HasKey(x => x.Id);
            builder.Property(p => p.MaCV).HasColumnName("MaCV").HasColumnType("nvarchar(30)").IsRequired();
            builder.Property(p => p.TenCV).HasColumnName("TenCV").HasColumnType("nvarchar(30)").IsRequired();
        }
    }
}
