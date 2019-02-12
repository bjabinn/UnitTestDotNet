using ConsoleApp2NetFramework;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace ConsoleApp2NetFramework_Test
{
    public class GenderAPIClientTests : IDisposable
    {
        private MockRepository mockRepository;



        public GenderAPIClientTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);


        }

        public void Dispose()
        {
            this.mockRepository.VerifyAll();
        }

        private GenderAPIClient CreateGenderAPIClient()
        {
            return new GenderAPIClient();
        }

        [Fact]
        public async Task GetGreetingByName_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateGenderAPIClient();
            string name = "TODO";

            // Act
            var result = await unitUnderTest.GetGreetingByName(
                name);

            // Assert
            Assert.True(false);
        }
    }
}
