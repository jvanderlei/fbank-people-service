using People.Domain.ValueObjects;

namespace People.Domain.Entities
{
    public class Person(Guid personId, PersonInfo personInfo, Address personAddress, ICollection<PersonalDocument> personalDocumentsList)
    {
        private Guid PersonId { get;  set; } = personId;
        public PersonInfo PersonInfo { get; protected set; } = personInfo;
        public Address PersonAddress { get; protected set; } = personAddress;
        public virtual ICollection<PersonalDocument> PersonalDocumentsList { get; protected set; } = personalDocumentsList;
    }
}