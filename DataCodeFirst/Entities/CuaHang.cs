using System;
using System.Collections.Generic;
using System.Text;

namespace DataCodeFirst.Entities
{
    public class CuaHang
    {
        public int CuaHangID { get; set; }
        public int MaCH { get; set; }
        public string TenCh { get; set; }
        public string DicchiCH { get; set; }
        public string ThanhPho { get; set; }
        public int IDTrangThai { get; set; }

        public List<NhanVien> NhanViens { get; set; }
    }
}
