namespace People.Domain.ValueObjects
{
    public class PersonalDocument(string Name, string Value, string URL)
    {
        public string Name { get; } = Name;
        public string Value { get; } = Value;
        public string URL { get; } = URL;
    }
}