using NHibernate_WebAPI_prototype.Models;
using NHibernate_WebAPI_prototype.Services.Implementation;
using ISession = NHibernate.ISession;

namespace NHibernate_WebAPI_prototype.Repository.Implementation
{
    public class CovCachingRepository : ICovCachingRepository
    {
        public IList<Person> GetPersons()
        {
            ISession ses = HibernateHelper.OpenSession();
            IList<Person> persons = ses.QueryOver<Person>().List();
            return persons;
        }

        public IList<Insurance> GetInsurances()
        {
            ISession ses = HibernateHelper.OpenSession();
            IList<Insurance> insurances = ses.QueryOver<Insurance>().List();
            return insurances;
        }

        public IList<Person> GetAdultPersonByName(string firstName)
        {
            ISession ses = HibernateHelper.OpenSession();
            var persons = ses.QueryOver<Person>()
                .Where(p => p.FirstName == firstName)
                .WhereRestrictionOn(p => p.Age).IsBetween(18).And(65)
                .List<Person>();
            return persons;
        }

        public Insurance? GetInsuranceById(int id)
        {
            ISession ses = HibernateHelper.OpenSession();
            return ses.Load<Insurance>(id);
        }

        //Error handling nvt voor dit prototype (buiten scope)
        public bool AddPerson(Person person)
        {
            ISession ses = HibernateHelper.OpenSession();
            ses.Save(person);
            try
            {
                ses.Flush();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
    }
}
