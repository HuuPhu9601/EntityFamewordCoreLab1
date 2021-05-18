using DataCodeFirst.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataCodeFirst.Configurations
{
    public class PhieuBaoHagConfig : IEntityTypeConfiguration<PhieuBaoHanh>
    {
        public void Configure(EntityTypeBuilder<PhieuBaoHanh> builder)
        {
            builder.ToTable("PhieuBaoHanh");
            builder.HasKey(x => x.PhieuBaoHanhID);
            builder.Property(x => x.PhieuBaoHanhID).UseIdentityColumn();
            builder.HasOne(x => x.SanPham).WithMany(x => x.PhieuBaoHanhs).HasForeignKey(x => x.SanPhamId);
            builder.HasOne(x => x.HoaDon).WithMany(x => x.PhieuBaoHanhs).HasForeignKey(x => x.HoaDonId);
        }
    }
}
