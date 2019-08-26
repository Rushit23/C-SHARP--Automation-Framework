using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameWork1.ExcelRead
{
    public class ExcelReader
    {
        // public object TestReadExcel(string xlPath, string sheetName, int row, int column)

        // public string TestReadExcel(string xlPath, string sheetName, int row, int column)


        public object TestReadExcel(string xlPath, string sheetName, int row, int column)

        {

            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            using (var stream = File.Open(xlPath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    DataTable tabel = reader.AsDataSet().Tables[sheetName];

                    return tabel.Rows[row][column].ToString();
                    reader.Close();
                    stream.Close();

                }

            }



        }




        // Counting The Total Number Of Rows

        public int GetRowCount(string xlPath, string sheetName)
        {

            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            using (var stream = File.Open(xlPath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    DataTable tabel = reader.AsDataSet().Tables[sheetName];

                    return tabel.Rows.Count;

                    reader.Close();
                    stream.Close();

                }

            }

        }










    }

}
