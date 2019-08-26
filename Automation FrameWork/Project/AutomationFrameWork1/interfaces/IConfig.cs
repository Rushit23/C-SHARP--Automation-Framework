using AutomationFrameWork1.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameWork1.interfaces
{
    public interface IConfig
    {

        BrowserType GetBrowser();
        string GetUsername();
        string GetPassword();

    }
}
