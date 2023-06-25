using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rehber_CF_EF_WinForm.Data
{
    public class RehberContext : DbContext
    {
        public DbSet<Kisi> Kisiler => Set<Kisi>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=.;database=RehberDB;trusted_connection=true");
        }
    }
}
