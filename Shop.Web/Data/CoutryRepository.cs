using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Web.Data
{
    public class CoutryRepository:GenericRepository<Country>, ICountrieRepository
    {
        public CoutryRepository(DataContext context) : base(context)
        {

        }


    }
}
