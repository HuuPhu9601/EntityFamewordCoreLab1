using DataCodeFirst.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataCodeFirst.Entities
{
    public class NhanVien
    {
        public int NhanVienID { get; set; }

        public int MaNv { get; set; }

        public string TenNv { get; set; }

        public string TenDemNV { get; set; }

        public int GioiTinh { get; set; }

        public string Diachi { get; set; }

        public float LuongNV { get; set; }

        public int Sodt { get; set; }

        public int IDTrangThai { get; set; }

        public int CuaHangId { get; set; }

        public int ChucVuId { get; set; }

        public CuaHang CuaHang { get; set; }

        public ChucVu ChucVu { get; set; }

        public List<HoaDon> HoaDons { get; set; }
    }
}
