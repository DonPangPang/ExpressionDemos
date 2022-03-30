using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.ConsoleApp1
{
    public class TestClass : ITestInterface
    {
        public void TestMethod()
        {
            Console.WriteLine("TestClass.TestMethod");
        }
    }
}
