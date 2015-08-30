using System;
using System.Collections.Generic;

namespace MvcApp.Models
{
    public partial class TAN_KURUM
    {
        public int ID { get; set; }
        public string K_KODU { get; set; }
        public string K_ADI { get; set; }
        public string K_YETKILI_1 { get; set; }
        public string K_YETKILI_2 { get; set; }
        public string K_IL { get; set; }
        public string K_ILCE { get; set; }
        public string K_TIP { get; set; }
        public string K_SEKTOR { get; set; }
        public string K_ADRES { get; set; }
    }
}
