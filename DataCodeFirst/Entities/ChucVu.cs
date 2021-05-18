using System;
using System.Collections.Generic;
using System.Text;

namespace DataCodeFirst.Entities
{
    public class ChucVu
    {
        public int ID { get; set; }

        public int MaCV { get; set; }

        public string TenCV { get; set; }

        public List<NhanVien> NhanViens { get; set; }
    }
}
