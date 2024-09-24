using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;

namespace SeleniumConceptUnitTestProject
{
    public class Demo4Advance
    {
        [Test]
        public void ValidDocUploadTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://www.ilovepdf.com/pdf_to_word";

            driver.FindElement(By.XPath("//input[@type='file']")).SendKeys(@"C:\Users\6125716\Downloads\SPbinder PDF - 2023 (F) - ABC_Sp_LIVEClient20_33524732_v03.pdf");
            driver.FindElement(By.XPath(""));
        }
        [Test]
        public void Demo3ActionsTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://futureskillsprime.in/";


            Actions actions = new Actions(driver);
            actions.MoveToElement(driver.FindElement(By.XPath("//span[text()='Explore']"))).Perform();

            //mouse over on FutureSkills Prime
            actions.MoveToElement(driver.FindElement(By.XPath("//a[text()='FutureSkills Prime']"))).Perform();

            driver.FindElement(By.XPath("//a[text()='About Us']")).Click();

        }
        [Test]
        public void Demo6JS()
        {

            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized");
            options.AddArguments("--disable-notifications");

            IWebDriver driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://www.malaysiaairlines.com/us/en/home.html";

            driver.FindElement(By.XPath("//span[text()='Accept all cookies']")).Click();

            //approach 1 - not working
            //driver.FindElement(By.XPath("//input[@name='dateDeparture']")).SendKeys("01 Oct 2024");

            //approach 2 - automate the date calendar

            //approach 3- javascript
            driver.ExecuteJavaScript("document.querySelector(\"input[name='dateDeparture']\").value='01 Oct 2024'");

            driver.ExecuteJavaScript("document.querySelector(\"input[name='dateReturn']\").value='11 Oct 2024'");
         
        }
    }
}