using DataCodeFirst.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataCodeFirst.Configurations
{
    public class DongSanPhamConfig : IEntityTypeConfiguration<DongSanPham>
    {
        public void Configure(EntityTypeBuilder<DongSanPham> builder)
        {
            builder.ToTable("DongSanPham");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).UseIdentityColumn();
            builder.Property(x => x.TENDSP).HasMaxLength(100);
        }
    }
}
