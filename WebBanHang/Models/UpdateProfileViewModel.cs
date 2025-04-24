using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebBanHang.Models
{
    public class UpdateProfileViewModel
    {
        public string FullName { get; set; }
        public string Phone { get; set; }
        public DateTime? Birthday { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
    }
}