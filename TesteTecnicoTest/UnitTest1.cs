using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TT.Infra.Domain.Entities;

namespace TesteTecnicoTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Action action = () => new Customer(1, "John", "John@gmail.com");
        }
    }
}
