using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bibalala.Models;
using Bibalala.Models.Bibalala;

namespace Bibalala.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<PageText> PageTexts { get; set; }        

    }
  

}
