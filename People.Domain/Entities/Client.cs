namespace People.Domain.Entities
{
    public class Client(Guid clientId, Person person, int level)
    {
        public Guid ClientId { get; set; } = clientId;
        public Person Person { get; set; } = person;
        public int Level { get; set; } = level;
    }
}
