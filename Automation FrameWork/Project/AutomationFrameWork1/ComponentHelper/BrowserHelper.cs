using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationFrameWork1.ComponentHelper
{
    public class BrowserHelper
    {




        public static void BrowserMaximize(IWebDriver driver)
        {
           driver.Manage().Window.Maximize();
            
        }





        public static void GoBack(IWebDriver driver)
        {
            driver.Navigate().Back();

        }






        public static void Forward(IWebDriver driver)
        {
            driver.Navigate().Forward();
        }







        public static void RefreshPage(IWebDriver driver)
        {
          driver.Navigate().Refresh();
        }









        public static void SwitchToWindow(IWebDriver driver, int index = 0 )
        {
            Thread.Sleep(1000);
            ReadOnlyCollection<string> windows = driver.WindowHandles;

            if ((windows.Count - 1) < index)
            {
                throw new NoSuchWindowException("Invalid Browser Window Index" + index);
            }

            
            driver.SwitchTo().Window(windows[index]);
            Thread.Sleep(1000);
            BrowserMaximize(driver);

        }










        public static void SwitchToParent(IWebDriver driver)
        {
            var windowids = driver.WindowHandles;


            for (int i = windowids.Count - 1; i > 0;)
            {
                driver.Close();
                i = i - 1;
                Thread.Sleep(2000);
                driver.SwitchTo().Window(windowids[i]);
            }

            driver.SwitchTo().Window(windowids[0]);

        }






       

   

        public static void SwitchToFrame(IWebDriver driver, By locatot)
        {
            driver.SwitchTo().Frame(driver.FindElement(locatot));
        }








    }
}
