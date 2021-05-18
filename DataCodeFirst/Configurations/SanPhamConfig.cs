using DataCodeFirst.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataCodeFirst.Configurations
{
    public class SanPhamConfig : IEntityTypeConfiguration<SanPham>
    {
        public void Configure(EntityTypeBuilder<SanPham> builder)
        {
            builder.ToTable("SanPham");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).UseIdentityColumn();
            builder.HasOne(x => x.DongSanPham).WithMany(x => x.SanPhams).HasForeignKey(x => x.DongSanPhamId);
            builder.HasOne(x => x.ThuongHieu).WithMany(x => x.SanPhams).HasForeignKey(x => x.ThuongHieuId);
        }
    }
}
