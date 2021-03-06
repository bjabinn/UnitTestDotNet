using System.Threading.Tasks;
// <copyright file="GenderAPIClientTest.cs">Copyright ©  2019</copyright>

using System;
using ConsoleApp2NetFramework;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp2NetFramework.Tests
{
    [TestClass]
    [PexClass(typeof(GenderAPIClient))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class GenderAPIClientTest
    {

        [PexMethod]
        public Task<string> GetGreetingByName([PexAssumeUnderTest]GenderAPIClient target, string name)
        {
            Task<string> result = target.GetGreetingByName(name);
            return result;
            // TODO: add assertions to method GenderAPIClientTest.GetGreetingByName(GenderAPIClient, String)
        }
    }
}
