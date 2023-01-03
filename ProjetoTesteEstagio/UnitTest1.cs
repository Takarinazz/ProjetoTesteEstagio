using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace TesteGooglePage
{
    [TestClass]
    public class AutTestGoogle
    {
        [TestMethod]
        public void ShouldSearchWithEnter()
        {

            WebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.google.com.br");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//input[@name=\"q\"]")).SendKeys("selenium");
            driver.FindElement(By.XPath("//input[@name=\"q\"]")).SendKeys(Keys.Enter);
            Assert.IsNotNull(driver.FindElement(By.XPath("//div[contains(text(),'resultados')]")));
            driver.Close();
        }
        [TestMethod]
        public void ShouldSearchWithClick()
        {

            WebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.google.com.br");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//input[@name=\"q\"]")).SendKeys("selenium");
            var elementClick = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[4]/center/input[1]"));
            elementClick.Click();
            Assert.IsNotNull(driver.FindElement(By.XPath("//div[contains(text(),'resultados')]")));

        }

        [TestMethod]
        public void ShouldSearchWithClickInLuckButton()
        {

            WebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.google.com.br");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//input[@name=\"q\"]")).SendKeys("selenium");
            var elementClick = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[4]/center/input[2]"));
            elementClick.Click();
            driver.Close();
        }

        [TestMethod]
        public void ShouldStayGooglePageWhenBlankString()
        {

            WebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.google.com.br");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//input[@name=\"q\"]")).SendKeys("");
            Actions action = new Actions(driver);
            IWebElement elementClick = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[4]/center/input[1]"));
            driver.FindElement(By.XPath("//input[@name=\"q\"]")).SendKeys(Keys.Enter);
            driver.Close();
        }
    }
}
