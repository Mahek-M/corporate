using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace corporate2.Data.Models
{
    public class Candidate
    {
        [Key]
        public int id { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string Jobtitle { get; set; }
        public string Email { get; set;}
        public string Cell { get; set; }
        public string Home { get; set; }
        public string Fax { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string Some1 { get; set; }
        public string Some2 { get; set; }
        public string Hire { get; set; }
        public string Comptetenices { get; set; }
        public string Jobcategory { get; set; }
        public string Source { get; set; }
        public string Resumeupload { get; set; }
       public DataFile df = new DataFile();
     }
}
