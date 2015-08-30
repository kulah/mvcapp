using System;
using System.Collections.Generic;

namespace MvcApp.Models
{
    public partial class USERLIST
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string adsoyad { get; set; }
        public string email { get; set; }
        public string tip { get; set; }
        public string user_grup { get; set; }
        public string kurum { get; set; }
    }
}
