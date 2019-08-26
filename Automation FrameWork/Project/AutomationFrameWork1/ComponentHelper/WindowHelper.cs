using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using AutomationFrameWork1.ComponentHelper;

namespace AutomationFrameWork1.ComponentHelper
{
    public class WindowHelper
    {



        public static string GetTitle(IWebDriver driver)
        {
            return driver.Title;
        }

     
    }
}
