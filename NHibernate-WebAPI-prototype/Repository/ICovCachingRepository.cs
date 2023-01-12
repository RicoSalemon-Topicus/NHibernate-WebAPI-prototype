using NHibernate_WebAPI_prototype.Models;

namespace NHibernate_WebAPI_prototype.Repository
{
    public interface ICovCachingRepository
    {
        public IList<Person> GetPersons();
        public IList<Insurance> GetInsurances();
        public IList<Person> GetAdultPersonByName(string firstname);
        bool AddPerson(Person person);
    }
}
