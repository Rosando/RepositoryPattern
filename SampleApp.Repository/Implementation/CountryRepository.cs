using SampleApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Repository
{
    public class CountryRepository : Repository<Country>, ICountryRepository
    {
        public CountryRepository(SampleAppContext context): base(context)
        {

        }
        public Country GetByID(int id)
        {
            return Find(x => x.CountryID == id).FirstOrDefault();
        }
    }
}
