using AutomationFrameWork1.Base;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameWork1.Pages
{
    public class Facebook : BasePage
    {

        public Facebook(IWebDriver driver) : base(driver)
        {


        }

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement email { get; set; }

        [FindsBy(How = How.Id, Using = "pass")]
        public IWebElement password { get; set; }

        [FindsBy(How = How.Id, Using = "u_0_2")]
        public IWebElement Login { get; set; }





        public void FaceBookLogin(string UserName, string Password)
        {
            email.SendKeys(UserName);
            password.SendKeys(Password);
            Login.Submit();
           
        }




    }
}
