using People.Domain.ValueObjects;
using System;
using Xunit;

namespace People.Tests.Domain.ValueObjects
{
    public class PersonalDocumentTests
    {
        [Fact]
        public void DocumentsConstructor_ValidValues_ReturnEqual()
        {
            //Arrange
            string documentName = "CPF";
            string documentValue = "122.969.210-00";
            string documentURL = "https://www.google.com/imgres?q=stock%20images&imgurl=https%3A%2F%2Fwww.adobe.com%2Fcreativecloud%2Fphotography%2Fdiscover%2Fmedia_131179edca5f92db203e2b78cb8a308605afbc958.png%3Fwidth%3D750%26format%3Dpng%26optimize%3Dmedium&imgrefurl=https%3A%2F%2Fwww.adobe.com%2Fcreativecloud%2Fphotography%2Fdiscover%2Fstock-photography.html&docid=5PN_H_g5vtjcDM&tbnid=nQBxEUMKw0ttUM&vet=12ahUKEwj6t9v5tKmIAxXErJUCHYtoJCUQM3oECGMQAA..i&w=750&h=500&hcb=2&ved=2ahUKEwj6t9v5tKmIAxXErJUCHYtoJCUQM3oECGMQAA";

            //Act
            PersonalDocument doc = new(documentName, documentValue, documentURL);

            //Assert
            Assert.Equal(documentName, doc.Name);
            Assert.Equal(documentValue, doc.Value);
            Assert.Equal(documentURL, doc.URL);

        }
    }
}