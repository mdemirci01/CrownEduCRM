using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CrownEduCRM.Tests
{
    public class SeleniumTest
    {
        private RemoteWebDriver driver;
        [SetUp]
        public void SetUp()
        {
            string driverDirectory = Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Environment.CurrentDirectory))), "Drivers");
            driver = new ChromeDriver(driverDirectory);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.apsiyon.com");
        }

        [Test]
        public void Test1()
        {
            var title = driver.Title;
            Assert.AreEqual("Apsiyon - Site Yönetim Yazılımı, Apartman Yönetim Programı", title);
        }

        [TearDown]
        public void Close()
        {
            driver.Quit();
        }
    }
}
