namespace People.Domain.Exceptions
{

    [Serializable]
    public class InvalidZipCodeException : Exception
    {
        public InvalidZipCodeException() { }
        public InvalidZipCodeException(string message) : base(message) { }
        public InvalidZipCodeException(string message, Exception inner) : base(message, inner) { }
        protected InvalidZipCodeException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
