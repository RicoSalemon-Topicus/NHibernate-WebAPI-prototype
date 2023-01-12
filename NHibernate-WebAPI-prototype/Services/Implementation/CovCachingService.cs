using NHibernate_WebAPI_prototype.Models;
using NHibernate_WebAPI_prototype.Repository;

namespace NHibernate_WebAPI_prototype.Services.Implementation
{
    public class CovCachingService : ICovCachingService
    {
        private ICovCachingRepository repository; 

        public CovCachingService(ICovCachingRepository repository)
        {
            this.repository = repository;
        }

        public IList<Person> GetPersons()
        {
            return repository.GetPersons();
        }

        public IList<Insurance> GetInsurances()
        {
            return repository.GetInsurances();
        }

        public IList<Person> GetAdultPersonsByName(string name)
        {
            return repository.GetAdultPersonByName(name);
        }

        public bool AddPerson(Person person)
        {
            return repository.AddPerson(person);
        }
    }
}
