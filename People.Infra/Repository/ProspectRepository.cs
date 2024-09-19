using Microsoft.EntityFrameworkCore;
using People.Domain.Entities;
using People.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People.Infra.Repository
{
    internal class ProspectRepository : IProspectRepository
    {
        private PeopleContext _dbContext;

        public ProspectRepository(PeopleContext peopleContext)
        {
            _dbContext = peopleContext;
        }

        public Prospect Create(Prospect prospect)
        {
            _dbContext.Prospects.Add(prospect);
            _dbContext.SaveChanges();
            return prospect;
            

        }

        public Prospect Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Prospect Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Prospect> GetAll()
        {
            throw new NotImplementedException();
        }

        public Prospect Update(Prospect prospect)
        {
            throw new NotImplementedException();
        }
    }
}
