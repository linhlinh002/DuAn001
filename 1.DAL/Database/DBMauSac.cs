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
    internal class DBMauSac : IEntityTypeConfiguration<BangMauSac>
    {
        

        public void Configure(EntityTypeBuilder<BangMauSac> builder)
        {
            builder.ToTable("MauSac");
            builder.HasKey(x => x.Id);
            builder.Property(p => p.MaMs).HasColumnName("MaMS").HasColumnType("nvarchar(30)").IsRequired();
            builder.Property(p => p.TenMs).HasColumnName("TenMS").HasColumnType("nvarchar(300)").IsRequired();
        }
    }
}
