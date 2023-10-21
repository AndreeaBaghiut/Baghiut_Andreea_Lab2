using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Baghiut_Andreea_Lab2.Models;

namespace Baghiut_Andreea_Lab2.Data
{
    public class Baghiut_Andreea_Lab2Context : DbContext
    {
        public Baghiut_Andreea_Lab2Context (DbContextOptions<Baghiut_Andreea_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Baghiut_Andreea_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Baghiut_Andreea_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Baghiut_Andreea_Lab2.Models.Author>? Author { get; set; }
    }
}
