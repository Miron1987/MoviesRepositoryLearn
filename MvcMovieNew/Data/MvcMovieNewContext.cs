using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MvcMovieNew.Models
{
    public class MvcMovieNewContext : DbContext
    {
        public MvcMovieNewContext (DbContextOptions<MvcMovieNewContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovieNew.Models.Movie> Movie { get; set; }
    }
}
