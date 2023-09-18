using Bibalala.Models;
using Bibalala.Models.Bibalala;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using User.Bibalala.Models;

namespace Bibalala.Data
{
    public class UserDataContext : DbContext
    {
        public UserDataContext(DbContextOptions<UserDataContext> options) : base(options) { }
        public DbSet<PreRegisterInformation> PreRegisterInformations { get; set; }
        public DbSet<CountryList> CountryList { get; set; }
      
    }

}
