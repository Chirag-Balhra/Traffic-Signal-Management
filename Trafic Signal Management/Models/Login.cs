using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trafic_Signal_Management.Models
{
    public class Login
    {
        [Required]
        public String UserName { get; set; }
        [Required]
        
        public String Password { get; set; }
    }
}
