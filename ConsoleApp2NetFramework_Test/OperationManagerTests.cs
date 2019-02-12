using ConsoleApp2NetFramework;
using Moq;
using System;
using Xunit;

namespace ConsoleApp2NetFramework_Test
{
    public class OperationManagerTests : IDisposable
    {
        private MockRepository mockRepository;



        public OperationManagerTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);


        }

        public void Dispose()
        {
            this.mockRepository.VerifyAll();
        }

        private OperationManager CreateManager()
        {
            return new OperationManager();
        }

        [Fact]
        public void RealizaOperacion_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateManager();
            TipoOperacion operacion = TipoOperacion.Suma; //TODO
            double valor1 = 0.0;   //TODO
            double valor2 = 0.0;   //TODO

            // Act
            var result = unitUnderTest.RealizaOperacion(
                operacion,
                valor1,
                valor2);

            // Assert
            Assert.True(false);
        }
    }
}
