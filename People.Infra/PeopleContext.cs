using Microsoft.EntityFrameworkCore;
using People.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People.Infra
{
    public class PeopleContext : DbContext
    {
        public DbSet<Prospect> Prospects {  get; set; }
    }
}
