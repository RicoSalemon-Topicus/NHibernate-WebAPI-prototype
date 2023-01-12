namespace NHibernate_WebAPI_prototype.Models
{
    public class Person
    {
        public virtual int Id { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual int Age { get; set; }
        public virtual string Place { get; set; }
        public virtual IList<Insurance> Insurances { get; set; }
    }
}
