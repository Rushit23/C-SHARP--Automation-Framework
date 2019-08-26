using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;

namespace AutomationFrameWork1.Base
{
    public abstract class BasePage
    {
        public BasePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }


    }
}
