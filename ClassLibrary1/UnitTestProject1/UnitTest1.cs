using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using ClassLibrary1;


namespace UnitTestProject1
{
    [TestFixture]
    public class Taravian
    {
        IWebDriver chrome = new ChromeDriver(@"F:\selen");
        exhelp excelvalue = new exhelp();

        //[Test, Order(5)]
        [Test]
        public void signupT()
        {
            for (int i=1;i<1000;i++)
            {
                chrome.Url = "https://tournament2019.travian.com/";
                //System.Threading.Thread.Sleep(1 * 1000);
                chrome.FindElement(By.Name("email")).SendKeys(excelvalue.ExcelSetup(i, 1));
                chrome.FindElement(By.Name("email")).SendKeys(Keys.Enter);
                System.Threading.Thread.Sleep(1 * 1000);
                chrome.FindElement(By.XPath("/html/body/div[5]/div[3]/a")).Click();
                System.Threading.Thread.Sleep(1 * 1000);

            }
            
        }
    }
}
