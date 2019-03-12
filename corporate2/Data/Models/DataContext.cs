using corporate2.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace corporate2.Models
{
    public class DataContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            var configuration = builder.Build();
            optionBuilder.UseSqlServer(configuration["ConnectionStrings:RazorPagesMovieContext"]);
        }
        public DbSet<Login> Login { get; set; }
        public DbSet<Requirement> Require { get; set; }
        public DbSet<Candidate> Candidate { get; set; }
        public DbSet<DataFile> DataFile { get; set; }
    }
}
