using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SampleApp.Model
{
    public class SampleAppContext : DbContext
    {
        public SampleAppContext(): base("Name=SampleApp")
        {

        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Country> Countries { get; set; }
    }
}
