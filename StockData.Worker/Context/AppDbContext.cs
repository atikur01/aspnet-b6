using Microsoft.EntityFrameworkCore;
using StockData.Worker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockData.Worker.Context
{
    public class AppDbContext:DbContext
    {
        public DbSet<Company> companies { get; set; }
       public  DbSet<StockPrice> stocks { get; set; }
        
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
    }
}
