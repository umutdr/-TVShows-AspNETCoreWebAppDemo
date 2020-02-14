using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AspNETCoreWebAppDemo.Models;

namespace AspNETCoreWebAppDemo.Data
{
    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<TvShow> TvShow { get; set; }
    }
}
