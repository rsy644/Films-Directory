using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcFilm.Models;

namespace MvcFilm.Data
{
    public class MvcFilmContext : DbContext
    {
        public MvcFilmContext (DbContextOptions<MvcFilmContext> options)
            : base(options)
        {
        }

        public DbSet<Film> Film { get; set; }
    }
}


