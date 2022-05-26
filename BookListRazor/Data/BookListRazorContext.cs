using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookListRazor.Models;

namespace BookListRazor.Data
{
    public class BookListRazorContext : DbContext
    {
        public BookListRazorContext (DbContextOptions<BookListRazorContext> options)
            : base(options)
        {
        }

        public DbSet<BookListRazor.Models.Book>? Book { get; set; }
    }
}
