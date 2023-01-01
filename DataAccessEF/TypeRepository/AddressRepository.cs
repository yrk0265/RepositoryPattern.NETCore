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
    class AddressRepository : GenericRepository<Address>, IAdressRepository
    {
        public AddressRepository(PeopleContext context) : base(context) { }

        public IEnumerable<Address> Find(Expression<Func<Address, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
