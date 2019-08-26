using AutomationFrameWork1.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutomationFrameWork1.ExcelRead;
using AutomationFrameWork1.Helpers;
using AutomationFrameWork1.ComponentHelper;

namespace AutomationFrameWork1
{
    [Parallelizable]
    public class FacebookTest : IDisposable
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
        public void VerifyFacebookLogin()
        {
            InitalizeDriver("Chrome");
            NavigateToFaceBook();

            string title = Rannddoom.gettitlle(driver);
            Thread.Sleep(2000);


            Facebook fb = new Facebook(driver);
            fb.FaceBookLogin("UserName","Password");
            Thread.Sleep(1000);

            Assert.AreEqual("Facebook - Log In or Sign Up", title);
            
        }








        [Test]
        public void FacebookLoginTestWIthExcelFIle()
        {
            InitalizeDriver("Chrome");
            NavigateToFaceBook();

            Thread.Sleep(4000);
            Facebook FBook = new Facebook(driver);
            ExcelReader Exr = new ExcelReader();
            string xlPath = @"C:\Users\RUSHIT  PATEL\Downloads\FacebookTest.xlsx";
            string username = Exr.TestReadExcel(xlPath, "Sheet1", 0, 0).ToString();
            string password = Exr.TestReadExcel(xlPath, "Sheet1", 0, 1).ToString();

            Thread.Sleep(5000);
            FBook.FaceBookLogin(username, password);
            Thread.Sleep(3000);

            IAlert alert = driver.SwitchTo().Alert();
            String text = alert.Text;



            Thread.Sleep(3000);
            Assert.AreEqual("The password you’ve entered is incorrect.", text);


        }






        /**********Helper Methods *******/



        public void NavigateToFaceBook()
        {
          //  driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            driver.Manage().Window.Maximize();
        }






        public void Dispose()
        {
            driver.Quit();
        }








    }
}
