using People.Domain.Exceptions;
using System.Text.RegularExpressions;

namespace People.Domain.ValueObjects
{
    public class Address
    {
        public string StreetName { get; private set; }
        public string StreetType { get; private set; }
        public string StreetNumber { get; private set; }
        public string Apartment { get; private set; }
        public string Neighborhood { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string Country { get; private set; }
        private string _zipCode;
        public string ZipCode
        {
            get { return _zipCode; }
            private set

            {
                if (!Regex.IsMatch(value, AddressConstants.ZipValidateRegex))
                {
                    throw new InvalidZipCodeException("Zip code doesn't appears to be right");
                }
                _zipCode = value;
            }
        }

        public Address(string streetName, string streetType, string streetNumber, string apartment, string neighborhood, string city, string state, string country, string zipCode)
        {
            StreetName = streetName;
            StreetType = streetType;
            StreetNumber = streetNumber;
            Apartment = apartment;
            Neighborhood = neighborhood;
            City = city;
            State = state;
            Country = country;
            ZipCode = zipCode;
        }
    }

    static class AddressConstants
    {
        public const string ZipValidateRegex = "\\d{5}-\\d{3}";
    }
}
