using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketWeb.Data
{
    public class ChuyenBay 
    {
        public int ID { get; set; }
        public string MaChuyenBay { get; set; }
        public int SanBayDi_ID { get; set; }
        public int SanBayDen_ID { get; set; }
        public int ThoiGianDuKienBay { get; set; }
        public int SoGhe_Hang1 { get; set; }
        public int SoGhe_Hang2 { get; set; }
        public int MayBayID { get; set; }

    }
}
