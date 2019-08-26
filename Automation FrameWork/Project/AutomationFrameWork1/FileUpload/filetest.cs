using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationFrameWork1.FileUpload
{   
    
    public class Filetest : IDisposable
    {
        public IWebDriver driver;





        public void InitalizeDriver(string browser)
        {
            switch (browser)
            {
                case "Chrome":
                    driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                    break;
                case "Firefox":
                    driver = new FirefoxDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                    break;
                case "IE":
                    driver = new InternetExplorerDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                    break;
                default:
                    driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                    break;
            }
        }







        [Test]
        public void Test ()
        {
            InitalizeDriver("Chrome");
            driver.Navigate().GoToUrl("https://www.pdfmerge.com/");
            driver.Manage().Window.Maximize();
            IWebElement Button = driver.FindElement(By.CssSelector("#fileUploads>div:nth-child(1)>input"));
            Button.Click();


            var processinfo = new ProcessStartInfo()
            {
                FileName = @"D:\files\FileUpload.exe",
                Arguments = @"D:\files\textfile.txt"
            };


            using (var process = Process.Start(processinfo))
            {
                process.WaitForExit();
            }

            Thread.Sleep(5000);

        }




        /*
            [Test]
            public void FileUploadTest()
            {
                ProcessStartInfo processinfo = new ProcessStartInfo();
                processinfo.FileName = @"Path To .exe File";
                processinfo.Arguments = @"Path To The File You Want To Upload";


                Process process = Process.Start(processinfo);
                process.WaitForExit();
                process.Close();

                Thread.Sleep(5000);

            }

    */


        // Using With FrameWork

        // Make Sure You Copy To OutPut Directory : Copy Always For All
        // Provide ChromeDriver And other exe




        //[Test]
        //[DeploymentItem("Resources")]
        //public void FileUploadTest3()
        //{
        //    var processinfo = new ProcessStartInfo()
        //    {
        //        FileName = "fileupload.exe",
        //        Arguments = "\"" + Directory.GetCurrentDirectory() + @"\Test.xlsx" + "\""
        //    };

        //    using (var process = Process.Start(processinfo))
        //    {
        //        process.WaitForExit();
        //    }


        //    Thread.Sleep(5000);

        //}





        public void Dispose()
        {
            driver.Quit();
        }



    }
}
