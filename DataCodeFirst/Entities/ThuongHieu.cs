using System;
using System.Collections.Generic;
using System.Text;

namespace DataCodeFirst.Entities
{
    public class ThuongHieu
    {
        public int ID { get; set; }

        public int MATH { get; set; }

        public string   TENTH { get; set; }

        public string WEBSITE { get; set; }

        public int IDTRANGTHAI { get; set; }

        public List<SanPham> SanPhams { get; set; }
    }
}
