using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cancel_Nicole_Lab2.Models;

namespace Cancel_Nicole_Lab2.Data
{
    public class Cancel_Nicole_Lab2Context : DbContext
    {
        public Cancel_Nicole_Lab2Context (DbContextOptions<Cancel_Nicole_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Cancel_Nicole_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Cancel_Nicole_Lab2.Models.Publisher>? Publisher { get; set; }
    }
}
