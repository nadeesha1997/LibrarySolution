using LibrarySystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySystem.Data
{
    public class LibraryDataContext:DbContext
    {
        public LibraryDataContext(DbContextOptions<LibraryDataContext> options):base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
    }
}
