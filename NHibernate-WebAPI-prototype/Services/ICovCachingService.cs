using NHibernate_WebAPI_prototype.Models;

namespace NHibernate_WebAPI_prototype.Services
{
    public interface ICovCachingService
    {
        public IList<Person> GetPersons();
        public IList<Insurance> GetInsurances();
        public IList<Person> GetAdultPersonsByName(string name);
        bool AddPerson(Person person);
    }
}
