using System;
using System.Collections.Generic;
using System.Text;
using DataCodeFirst.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataCodeFirst.Configurations
{
    public class CuaHangConfig : IEntityTypeConfiguration<CuaHang>
    {
        public void Configure(EntityTypeBuilder<CuaHang> builder)
        {
            builder.ToTable("CuaHang");
            builder.HasKey(z => z.CuaHangID);
            builder.Property(x => x.TenCh).HasMaxLength(200);
            builder.Property(x => x.CuaHangID).UseIdentityColumn();
        }
    }
}
