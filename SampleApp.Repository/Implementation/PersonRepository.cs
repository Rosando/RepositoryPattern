using SampleApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Repository
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        public PersonRepository(SampleAppContext context): base(context)
        {

        }

        public Person GetById(long id)
        {
            return SampleAppContext.Persons.Include("Country").Where(x => x.PersonID == id).FirstOrDefault();
        }

        public SampleAppContext SampleAppContext
        {
            get { return Context as SampleAppContext; }
        }
    }
}
