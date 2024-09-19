using People.Domain.Exceptions;
using People.Domain.ValueObjects;
using System;
using Xunit;

namespace People.Tests.Domain.ValueObjects
{
    public class AddressTest
    {
        [Fact]
        public void Constructor_ValidValues_ReturnEqual()
        {
            //Arrange
            string StreetName = "Times Square";
            string StreetType = "Av";
            string StreetNumber = "1";
            string Apartment = string.Empty;
            string Neighborhood = "Manhattan";
            string City = "New York City";
            string State = "New York";
            string Country = "United States of America";
            string ZipCode = "10036-000";

            ///Act
            Address ad = new(StreetName, StreetType, StreetNumber, Apartment, Neighborhood, City, State, Country, ZipCode);

            //Assert
            Assert.Equal(ad.StreetName, StreetName);
            Assert.Equal(ad.StreetType, StreetType);
            Assert.Equal(ad.StreetNumber, StreetNumber);
            Assert.Equal(ad.Apartment, Apartment);
            Assert.Equal(ad.Neighborhood, Neighborhood);
            Assert.Equal(ad.City, City);
            Assert.Equal(ad.State, State);
            Assert.Equal(ad.Country, Country);
            Assert.Equal(ad.ZipCode, ZipCode);
        }

        [Fact]
        public void Constructor_InvalidZipCode_ShouldReturnError()
        {
            //Arrange
            string StreetName = "Times Square";
            string StreetType = "Av";
            string StreetNumber = "1";
            string Apartment = string.Empty;
            string Neighborhood = "Manhattan";
            string City = "New York City";
            string State = "New York";
            string Country = "United States of America";
            string ZipCode = "asxffa";

            //Act



            //Assert
            Assert.Throws<InvalidZipCodeException>(() => new Address(StreetName, StreetType, StreetNumber, Apartment, Neighborhood, City, State, Country, ZipCode));
        }
    }


}
