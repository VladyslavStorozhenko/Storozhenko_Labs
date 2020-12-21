using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;

namespace SeleniumHomework
{
    class SeleniumH
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("C:\\Program Files (x86)\\Google\\Chrome\\Application");
            driver.Url = "https://www.epam.com/";
        }

        [TestCase("//*[@id=\"wrapper\"]/div[2]/div[1]/header/div/nav/ul/li[5]/span[1]/a", "https://www.epam.com/about")]

        public void MenuTest(string xpath, string site)
        {
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath(xpath)).Click();
            Assert.AreEqual(driver.Url, site);
        }

        [TestCase("//*[@id=\"wrapper\"]/div[2]/div[1]/header/div/div/button",
            "//*[@id=\"wrapper\"]/div[2]/div[1]/header/div/div/nav/ul/li[1]",
            "//*[@id=\"wrapper\"]/div[2]/div[1]/header/div/div/nav/ul/li[1]/ul/li[2]/a", 
            "https://www.epam.com/services/consult-and-design")]
        [TestCase("//*[@id=\"wrapper\"]/div[2]/div[1]/header/div/div/button",
            "//*[@id=\"wrapper\"]/div[2]/div[1]/header/div/div/nav/ul/li[3]",
            "//*[@id=\"wrapper\"]/div[2]/div[1]/header/div/div/nav/ul/li[3]/ul/li[1]/a",
            "https://www.epam.com/our-work/financial-services")]
        [TestCase("//*[@id=\"wrapper\"]/div[2]/div[1]/header/div/div/button",
            "//*[@id=\"wrapper\"]/div[2]/div[1]/header/div/div/nav/ul/li[5]",
            "//*[@id=\"wrapper\"]/div[2]/div[1]/header/div/div/nav/ul/li[5]/ul/li[2]/a",
            "https://www.epam.com/about/newsroom")]
        [TestCase("//*[@id=\"wrapper\"]/div[2]/div[1]/header/div/div/button",
            "//*[@id=\"wrapper\"]/div[2]/div[1]/header/div/div/nav/ul/li[6]",
            "//*[@id=\"wrapper\"]/div[2]/div[1]/header/div/div/nav/ul/li[6]/ul/li[3]/a",
            "https://www.epam.com/careers/epam-without-borders")]

        public void MenuDropdownTest(string xpath1, string xpath2, string xpath3, string site)
        {
            driver.FindElement(By.XPath(xpath1)).Click();
            driver.FindElement(By.XPath(xpath2)).Click();
            driver.FindElement(By.XPath(xpath3)).Click();
            Assert.AreEqual(site, driver.Url);
        }


        [TestCase("//*[@id=\"wrapper\"]/div[2]/div[1]/header/div/ul/li[3]/div/button",
            "//*[@id=\"new_form_search\"]",
            "//*[@id=\"wrapper\"]/div[2]/div[1]/header/div/ul/li[3]/div/div/form/button", "IASA",
            "https://www.epam.com/search?q=IASA")]
        public void SearchBarTest(string xpath1, string xpath2, string xpath3, string word, string site)
        {
            driver.FindElement(By.XPath(xpath1)).Click();
            driver.FindElement(By.XPath(xpath2)).SendKeys(word);
            driver.FindElement(By.XPath(xpath3)).Click();
            Assert.AreEqual(site, driver.Url);
        }

        [TestCase("//*[@id=\"wrapper\"]/div[3]/div[1]/footer/div/div[2]/ul[1]/li[3]/a",
            "https://www.epam.com/privacy-policy")]
        [TestCase("//*[@id=\"wrapper\"]/div[3]/div[1]/footer/div/div[2]/ul[1]/li[4]/a",
            "https://www.epam.com/cookie-policy")]
        public void ButtonAtTheEndOfPageTest(string xpath1, string site)
        {
            var element = driver.FindElement(By.XPath(xpath1));
            Actions action = new Actions(driver);
            action.MoveToElement(element);
            action.Perform();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div/div/div[2]/button/span")).Click();
            element.Click();
            Assert.AreEqual(site, driver.Url);
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
