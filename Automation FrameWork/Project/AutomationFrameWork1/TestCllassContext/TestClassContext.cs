using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameWork1.TestCllassContext
{ 
           [TestClass]
        public class TestClassContext
        { 

        public TestContext testcontext;

        public TestContext TestContext
        {
            get { return testcontext; }
            set { testcontext = value; }

        }


        [TestMethod]
        public void TestCase1()
        {

            Console.WriteLine(" Test Name : {0}", TestContext.TestName);

        }

        [TestMethod]
        public void TestCase2()
        {

            Console.WriteLine(" Test Name : {0}", TestContext.TestName);

        }

        [TestCleanup]
        public void AfterTest()
        {

            Console.WriteLine(" Test Name : {0}", TestContext.CurrentTestOutcome);

        }



    }

}

