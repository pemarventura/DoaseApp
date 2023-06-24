using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoaseApp.Shared.DataContext
{
    public class DoaseContext : DbContext
    {
        public DoaseContext(DbContextOptions<DoaseContext> options) : base(options) 
        {

        }

        public DbSet<Person> Person { get; set; }
    }
}
