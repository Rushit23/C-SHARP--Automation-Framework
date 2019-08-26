using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameWork1.ExcelRead
{
    public class TestExcelData
    {

        [Test]
        public void ReadExcelData()
        {
            ExcelReader Exr = new ExcelReader();
            
            string xlPath1 = @"C:\Users\RUSHIT  PATEL\source\repos\AutomationFrameWork1\AutomationFrameWork1\Data\FacebookTest.xlsx";

            Console.WriteLine(Exr.TestReadExcel(xlPath1, "Sheet1", 0, 0));
            Console.WriteLine(Exr.TestReadExcel(xlPath1, "Sheet1", 0, 1));

        }


        [Test]
        public void RowCountTest()
        {
            ExcelReader ExR = new ExcelReader();

            string xlPath = @"C:\Users\RUSHIT  PATEL\source\repos\AutomationFrameWork1\AutomationFrameWork1\Data\FacebookTest.xlsx";

            Console.WriteLine($"The Row Count : {ExR.GetRowCount(xlPath, "Sheet1")} ");

        }




    }
}
