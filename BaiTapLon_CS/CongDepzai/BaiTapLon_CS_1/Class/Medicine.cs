using System;
using System.Collections.Generic;

namespace BaiTapLon_CS.Class
{
    public class Medicine
    {
        public int ID_Medicine { get; set; }
        public string Name_Medicine { get; set; }
        public string Image_Medicine { get; set; }
        public DateTime? Date_Of_Manufacture { get; set; }
        public DateTime? Expiry_Date { get; set; }
        public string Packing { get; set; }
        public string Unit { get; set; }
        public decimal? Cost { get; set; }
        public string Registration_Number { get; set; }
        public List<int?> ID_Category { get; set; }
        public List<string> Name_Category { get; set; }
        public DateTime? Import_Date { get; set; }
        public int? Remain_Amount { get; set; }
        public string Source { get; set; }
        public List<string> Name_Manufacturer { get; set; }
        public List<int?> ID_Manufacturer { get; set; }
    }
}

