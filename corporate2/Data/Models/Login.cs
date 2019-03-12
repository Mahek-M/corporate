using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace corporate2.Models
{
    public class Login
    {
        
        [Key]
        [Required]
        public string Username { get; set; }
        public string Password { get; set; }
        [Display(Name ="Remberme")]
        public string Remberme { get; set; }
    }
}
