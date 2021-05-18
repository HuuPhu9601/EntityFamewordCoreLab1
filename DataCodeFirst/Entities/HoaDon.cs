using System;
using System.Collections.Generic;
using System.Text;

namespace DataCodeFirst.Entities
{
    public class HoaDon
    {
        public int ID { get; set; }

        public int KhachHangId { get; set; }

        public int NhanVienId { get; set; }

        public KhachHang KhachHang { get; set; }

        public NhanVien NhanVien { get; set; }

        public int MaHD { get; set; }

        public DateTime NgayTaoHD { get; set; }

        public DateTime NgayThanhToanHD { get; set; }

        public DateTime NgayShipHang { get; set; }

        public DateTime NgayNhanHang { get; set; }

        public string DiaChiGiaoHang { get; set; }

        public int IDTrangThai { get; set; }

        public List<PhieuBaoHanh> PhieuBaoHanhs { get; set; }

    }
}
