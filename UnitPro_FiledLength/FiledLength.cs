using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitPro_FiledLength
{
    [TestClass]
    public class FiledLength
    {
        private IWebDriver _driver;
        private By _username = By.Id("username");
        private By _password = By.Id("password");
        private By _login = By.Id("login");
        [TestInitialize]
        public void DriverInit()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://adactinhotelapp.com/");
            _driver.Manage().Window.Maximize();
        }
        [TestCleanup]
        public void DriverCleanup()
        {
            if(_driver!=null)
            {
                _driver.Quit();
                _driver = null;
            }
        }
        [TestMethod]
        public void TC_LoginPageFiledLength()
        {
            string _user= "nagalakshmin";
            string _pwd= "l@kshmin";
            _driver.FindElement(_username).SendKeys(_user);
            _driver.FindElement(_password).SendKeys(_pwd);
            _driver.FindElement(_login).Click();
        }
    }
}
