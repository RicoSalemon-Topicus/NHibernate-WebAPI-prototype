using NHibernate;
using NHibernate.Cfg;
using ISession = NHibernate.ISession;

namespace NHibernate_WebAPI_prototype.Services.Implementation
{
    public class HibernateHelper
    {
        private static ISessionFactory? _sessionFactory;
        public static ISessionFactory GetNHibernateSessionFactory()
        {
            if (_sessionFactory == null)
            {
                var configuration = new Configuration();
                configuration.Configure();
                _sessionFactory = configuration.BuildSessionFactory();
            }

            return _sessionFactory;
        }

        public static ISession OpenSession()
        {
            ISessionFactory fac = GetNHibernateSessionFactory();
            ISession ses = fac.OpenSession();
            return ses;
        }
    }
}
