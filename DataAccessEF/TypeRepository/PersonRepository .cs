using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessEF.TypeRepository
{
    public class PersonRepository : GenericRepository<Person>, IPersonRepository
    {
        public PersonRepository(PeopleContext context) : base(context) { }

        public IEnumerable<Person> Find(Expression<Func<Person, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetAdultPersons()
        {
            return context.Person.Where(pers => pers.Age >= 18).ToList();
        }
    }
}
