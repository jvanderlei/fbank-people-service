using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People.Domain.ValueObjects
{
    public class PersonInfo
    {
        public Name PersonName { get; set; }
        public DateTime PersonDateOfBirth { get; set; }
        public string PersonEmail { get; set; }
        public string PersonNationality { get; set; }
        public string PersonPhoneNumber { get; set; }

        public class Name
        {
            public string FirstName {  get; set; }
            public string? MiddleName { get; set; }
            public string LastName { get; set; }
            public string Honorific {  get; set; }
        }
    }
}
