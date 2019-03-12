using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace corporate2.Data.Models
{
    public class Requirement
    {
        [Key]
        public int id { get; set; }
        [StringLength(60,MinimumLength =3)]
        [Required]
        public string Departement { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Position { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string NoPosition { get; set; }
        [StringLength(100, MinimumLength = 3)]
        [Required]
        public string Skills { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Location { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Status { get; set; }
        [StringLength(100, MinimumLength = 3)]
        [Required]
        public string Comments { get; set; }
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}
