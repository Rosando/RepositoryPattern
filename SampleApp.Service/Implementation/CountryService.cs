using SampleApp.Model;
using SampleApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Service.Implementation
{
    public class CountryService : EntityService<Country>, ICountryService
    {
        IUnitOfWork _unitOfWork;
        ICountryRepository _countryRepository;

        public CountryService(IUnitOfWork unitOfWork, ICountryRepository countryRepository): base(unitOfWork, countryRepository)
        {
            _unitOfWork = unitOfWork;
            _countryRepository = countryRepository;
        }

        public Country GetById(int Id)
        {
            return _countryRepository.GetByID(Id);
        }
    }
}
