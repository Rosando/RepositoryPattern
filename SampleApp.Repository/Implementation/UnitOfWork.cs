using SampleApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Repository.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SampleAppContext _context;

        public UnitOfWork(SampleAppContext context)
        {
            _context = context;
            Persons = new PersonRepository(_context);
            Countries = new CountryRepository(_context);
        }

        public IPersonRepository Persons { get; private set; }
        public ICountryRepository Countries { get; private set; }

        public int complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
