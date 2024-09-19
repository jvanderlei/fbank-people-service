using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People.Domain.Entities
{
    public class Employee(Person person, string department, string role)
    {
        public Person Person { get; set; } = person;
        public string Department { get; set; } = department;
        public string Role { get; set; } = role;
    }
}
