using DataCodeFirst.Configurations;
using DataCodeFirst.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace DataCodeFirst.Context
{
    public class Lab1DBContext : DbContext
    {
        public Lab1DBContext([NotNullAttribute] DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ChucVuConfig());
            modelBuilder.ApplyConfiguration(new CuaHangConfig());
            modelBuilder.ApplyConfiguration(new DongSanPhamConfig());
            modelBuilder.ApplyConfiguration(new HoaDonCofig());
            modelBuilder.ApplyConfiguration(new KhachHangConfig());
            modelBuilder.ApplyConfiguration(new NhanVienConfig());
            modelBuilder.ApplyConfiguration(new PhieuBaoHagConfig());
            modelBuilder.ApplyConfiguration(new SanPhamConfig());
            modelBuilder.ApplyConfiguration(new ThuongHieuConfig());
            
            
        }

        public DbSet<CuaHang> CuaHangs { get; set; }
        public DbSet<ChucVu> ChucVus { get; set; }
        public DbSet<DongSanPham> dongSanPhams { get; set; }
        public DbSet<HoaDon> hoaDons { get; set; }
        public DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        public DbSet<KhachHang> khachHangs { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<PhieuBaoHanh> phieuBaoHanhs { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<ThuongHieu> ThuongHieus { get; set; }


    }
}
