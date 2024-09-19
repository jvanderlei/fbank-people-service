using People.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People.Domain.Interfaces.Repository
{
    public interface IProspectRepository : IRepository<Prospect, Guid>
    {
        public IEnumerable<Prospect> GetAll();
        public Prospect Get(Guid id);
        public Prospect Create(Prospect prospect);
        public Prospect Update(Prospect prospect);
        public Prospect Delete(Guid id);
    }
}
