using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace PreviewCinemas.Models
{
    class CinemaContext : DbContext
    {
        public CinemaContext() : base("CinemaContext")
 {
        }
 

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Showing> Showings { get; set; }
        public DbSet<Screen> Screens { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Cart> Cart { get; set; }

    }
}
