using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EV.Models
{
    public class Login
    {
        [Required] 
        public string Username { get; set; }
        [Required,DataType(DataType.Password)]
        public string Password { get; set; }

    }
}