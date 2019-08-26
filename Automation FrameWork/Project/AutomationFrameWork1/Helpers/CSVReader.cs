
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameWork1.Helpers
{

    [TestClass]
    public class CSVReader
    {

        public TestContext testcontext;

        public TestContext TestContext
        {
            get { return testcontext; }
            set { testcontext = value; }

        }


        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"C:\Users\RUSHIT  PATEL\source\repos\AutomationFrameWork1\AutomationFrameWork1\Data\CSVTEST.csv", "CSVTEST#csv", DataAccessMethod.Sequential)]
        public void CSVTest2()
        {

            Console.WriteLine($" The Username is :{TestContext.DataRow["UserName"].ToString()} And The Password Is: {TestContext.DataRow["Password"].ToString()}");
        }

        // string Interpolation
        // string text = $" The Number {number} is {CheckIfEven(int number)}.";





        // Reading Data By Line From text File

        [TestMethod]
        public void CSVTest1()

        {

            int counter = 0;
            string line;

            // Read the file and display it line by line.

            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\RUSHIT  PATEL\source\repos\AutomationFrameWork1\AutomationFrameWork1\Data\CSVTEST.csv");

            while ((line = file.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
                counter++;
            }

            file.Close();
            Console.WriteLine("There were {0} lines.", counter);


        }




    }
}
