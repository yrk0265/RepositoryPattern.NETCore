using Domain;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessEF.TypeRepository
{
    class EmailRepository : GenericRepository<Email>, IEmailRepository
    {
        public EmailRepository(PeopleContext context) : base(context) { }

        public IEnumerable<Email> Find(Expression<Func<Email, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
