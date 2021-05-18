using System;
using System.Collections.Generic;
using System.Text;

namespace DataCodeFirst.Entities
{
    public class PhieuBaoHanh
    {
        public int PhieuBaoHanhID { get; set; }

        public int MaPhieu { get; set; }

        public int SanPhamId { get; set; }

        public int HoaDonId { get; set; }

        public SanPham SanPham { get; set; }

        public HoaDon HoaDon { get; set; }

        public DateTime NGAYBATDAU { get; set; }

        public DateTime NGAYKETTHUC { get; set; }

        public string MOTA { get; set; }

        public int IMEI { get; set; }

        public int IDTRANGTHAI { get; set; }
    }
}
