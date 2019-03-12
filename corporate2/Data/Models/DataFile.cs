using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace corporate2.Data.Models
{
    public class DataFile
    {
        [Key]
        public int Id { get; set; }
        public string Extension { get; set; }
        public string Path { get; set; }

    }
}
