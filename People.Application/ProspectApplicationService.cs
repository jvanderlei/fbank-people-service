using People.Domain.Entities;
using People.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People.Application
{
    public class ProspectApplicationService
    {
        private IProspectRepository _prospectRepository;

        public ProspectApplicationService(IProspectRepository prospectRepository)
        {
            _prospectRepository = prospectRepository;
        }

        public Prospect create(Prospect prospect)
        {
            return _prospectRepository.Create(prospect);
        }


    }
}
