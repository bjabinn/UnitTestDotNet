// <copyright file="OperationManagerTest.cs">Copyright ©  2019</copyright>

using System;
using ConsoleApp2NetFramework;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp2NetFramework.Tests
{
    [TestClass]
    [PexClass(typeof(OperationManager))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class OperationManagerTest
    {

        [PexMethod]
        public double RealizaOperacion(
            [PexAssumeUnderTest]OperationManager target,
            TipoOperacion operacion,
            double valor1,
            double valor2
        )
        {
            double result = target.RealizaOperacion(operacion, valor1, valor2);
            return result;
            // TODO: add assertions to method OperationManagerTest.RealizaOperacion(OperationManager, TipoOperacion, Double, Double)
        }
    }
}
