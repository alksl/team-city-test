using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CILabbTestProject
{
    [TestFixture]
    class HelloWorldTest
    {
        [Test]
        public void say_hello_test()
        {
            var hello = new HelloWorld();
            Assert.AreEqual("Hello World!", hello.SayHello());
        }
    }
}
