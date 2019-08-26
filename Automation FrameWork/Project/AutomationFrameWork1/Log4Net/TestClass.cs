using AutomationFrameWork1.Helpers;
using AutomationFrameWork1.Pages;
using log4net;
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

namespace AutomationFrameWork1.Log4Net
{
   public class TestClass : IDisposable
    {

        public IWebDriver driver;
        private static readonly ILog Logger = Log4NetHelper.GetXmlLogger(typeof(TestClass));

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











        [Test, Category("Log4")]
        public void VerifyFacebookLogin()
        {




            InitalizeDriver("Chrome");
            NavigateToFaceBook();

            string title = driver.Title;
            Thread.Sleep(2000);


            Facebook fb = new Facebook(driver);
            fb.FaceBookLogin("UserName", "Password");
            Thread.Sleep(1000);

            Assert.AreEqual("Facebook - Log In or Sign Up", title);

        }












        [Test,Category("Log4")]
        public void VerifyFacebookLogin2()
        {


            try
            {
                InitalizeDriver("Chrome");
                NavigateToFaceBook();

                string title = driver.Title;
                Thread.Sleep(2000);


                Facebook fb = new Facebook(driver);
                fb.FaceBookLogin("UserName", "Password");
                Thread.Sleep(1000);

                Assert.AreEqual("Facebook - Log Innn  or Sign Up", title);
            }

            catch (Exception exception)
            {
                Logger.Error(exception.StackTrace);
                ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("Test.png", ScreenshotImageFormat.Png);
                throw;
            }

     

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
