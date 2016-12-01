using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Repository
{
    public interface IUnitOfWork
    {
        ICountryRepository Countries { get; }
        IPersonRepository Persons { get; }
        int complete();
    }
}
