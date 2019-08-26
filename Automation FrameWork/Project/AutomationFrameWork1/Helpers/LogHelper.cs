using AutomationFrameWork1.Base;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;
using AutomationFrameWork1.Settings;
using OpenQA.Selenium.Chrome;

namespace AutomationFrameWork1.Helpers
{
    public class LogHelper
    {
        

        public  string logFileName = string.Format("{0:yyyymmddhhmmss}", DateTime.Now);
        public StreamWriter streamw = null;

        public  void CreateLogFile()
        {
            string dir = @"D:\Test1\";
            if (Directory.Exists(dir))
            {

                streamw = File.AppendText(dir + logFileName + ".log");
            }
            else
            {
                Directory.CreateDirectory(dir);
                streamw = File.AppendText(dir + logFileName + ".log");

            }

        }


        public void Write(string logMessage)
        {

            streamw.Write("{0}  {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            streamw.WriteLine("  {0}", logMessage);
            streamw.Flush();

        }



     


        [Test]
        public void logfileTest()
        {
            CreateLogFile();
            Thread.Sleep(5000);

            Write("This Is LogFile Test");
        }




    }
}
