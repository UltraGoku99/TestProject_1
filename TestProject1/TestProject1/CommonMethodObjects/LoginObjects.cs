using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TestProject1.Utilities;
using log4net;

[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config")]

namespace TestProject1.CommonMethodObjects
{
    public class LoginObjects
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public void VerifyHome()
        {
            IWebElement home;
            bool displayHome;
            home = BaseClass.driver.FindElement(By.XPath("//span[.='Login']"));
            displayHome = home.Displayed;

            if (displayHome == true)
            {
                Console.WriteLine("Test Passed");
                log.Info("Application launched successfully");
            }

            else
            {
                Console.WriteLine("Test Failed");
                log.Info("Application Failed to launch");
            }

        }

        public void EnterUsername()
        {
            IWebElement username = BaseClass.driver.FindElement(By.XPath("//input[@name='UserName']"));
            username.SendKeys("admin");
        }

        public void EnterPassword()
        {
            IWebElement password = BaseClass.driver.FindElement(By.XPath("//input[@name='Password']"));
            password.SendKeys("admin");
        }

        public void Loginbtn()
        {
            IWebElement loginBtn = BaseClass.driver.FindElement(By.XPath("//input[@name='Login']"));
            loginBtn.Click();
        }

        public void VerifyDemoPage()
        {
            IWebElement demo;
            bool visible = true;
            demo = BaseClass.driver.FindElement(By.XPath("//p[.='This is a demo website, which act as a mock site for trying out different automation tools']"));
            visible = demo.Displayed;

            if (visible == true)
            {
                Console.WriteLine("Test Passed");
            }

            else
            {
                Console.WriteLine("Test Failed");
            }
        }

    }
}

