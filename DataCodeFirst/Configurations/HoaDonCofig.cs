using DataCodeFirst.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataCodeFirst.Configurations
{
    public class HoaDonCofig : IEntityTypeConfiguration<HoaDon>
    {
        public void Configure(EntityTypeBuilder<HoaDon> builder)
        {
            builder.ToTable("HoaDon");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).UseIdentityColumn();
            builder.HasOne(x => x.KhachHang).WithMany(x => x.HoaDons).HasForeignKey(x => x.KhachHangId);
            builder.HasOne(x => x.NhanVien).WithMany(x => x.HoaDons).HasForeignKey(x => x.NhanVienId);
        }
    }
}
