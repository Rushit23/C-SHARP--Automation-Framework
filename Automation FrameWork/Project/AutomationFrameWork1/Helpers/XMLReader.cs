using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameWork1.Helpers
{
    [TestClass]
    public class XMLReader
    {


        public TestContext testcontext;

        public TestContext TestContext
        {
            get { return testcontext; }
            set { testcontext = value; }

        }

        // InPlace Of Table Name You Can Specify The TagName Which Contains The Data
        // .DataRow["UserName"] ==  TagName Of XML Which Has The Data
        // string Interpolation
        // string text = $" The Number {number} is {CheckIfEven(int number)}.";


        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"C:\Users\RUSHIT  PATEL\source\repos\AutomationFrameWork1\AutomationFrameWork1\Data\XMLFile.xml", "Row", DataAccessMethod.Sequential)]
        public void XMLTest1()
        {

            Console.WriteLine($" The Severity is :{TestContext.DataRow["Severity"].ToString()} And The HardWare Is: {TestContext.DataRow["HardWare"].ToString()}");
        }





        // Converting String To Other Type

        //[TestMethod]
        //[DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"C:\Users\RUSHIT  PATEL\source\repos\AutomationFrameWork1\AutomationFrameWork1\Data\XMLFile.xml", "Row", DataAccessMethod.Sequential)]
        // public void XMLTest2()
        // {

        //     Console.WriteLine($" The Username is :{Convert.ToChar(TestContext.DataRow["UserName"].ToString())} And The Password Is: {TestContext.DataRow["Password"].ToString()}");
        // }


    }



}
