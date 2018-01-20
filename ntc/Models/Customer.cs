using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ntc.Models
{
    public class Customer
    {
        public  int custid { get; set; }
        public string custname { get; set; }
        public int custsal { get; set; }
        
        [Required]

        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string confirmemail { get; set; }
        public string username { get; set; }
        public string password{get;set; }


    }
}