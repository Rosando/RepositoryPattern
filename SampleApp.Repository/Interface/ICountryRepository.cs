using SampleApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Repository
{
    public interface ICountryRepository: IRepository<Country>
    {
        Country GetByID(int id);
    }
}
