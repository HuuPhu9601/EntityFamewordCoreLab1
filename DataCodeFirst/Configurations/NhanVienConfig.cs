using DataCodeFirst.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataCodeFirst.Configurations
{
    public class NhanVienConfig : IEntityTypeConfiguration<NhanVien>
    {
        public void Configure(EntityTypeBuilder<NhanVien> builder)
        {
            builder.ToTable("NhanVien");
            builder.HasKey(x => x.NhanVienID);
            builder.Property(x => x.NhanVienID).UseIdentityColumn();
            builder.HasOne(x => x.CuaHang).WithMany(x => x.NhanViens).HasForeignKey(x => x.CuaHangId);
            builder.HasOne(x => x.ChucVu).WithMany(x => x.NhanViens).HasForeignKey(x => x.ChucVuId);
        }
    }
}
