

namespace People.Domain.Entities
{
    public class Prospect(Person person)
    {
        public Person Person { get; set; } = person;

        public static Prospect Create(Person person) 
        {
            return new Prospect(person);
        }

        public void Approve()
        {

        }

        public void Deny() 
        { 

        }
    }
}
