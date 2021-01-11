using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class UntitledTestCase
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "https://www.google.com/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheUntitledTestCaseTest()
        {
            driver.Navigate().GoToUrl("https://demo.opencart.com/");
            driver.FindElement(By.XPath("//div[@id='top-links']/ul/li[2]/a/span")).Click();
            driver.FindElement(By.LinkText("Register")).Click();
            driver.FindElement(By.Id("input-firstname")).Click();
            driver.FindElement(By.Id("input-firstname")).Clear();
            driver.FindElement(By.Id("input-firstname")).SendKeys("Petar");
            driver.FindElement(By.Id("input-lastname")).Clear();
            driver.FindElement(By.Id("input-lastname")).SendKeys("Nenadic");
            driver.FindElement(By.Id("input-email")).Clear();
            driver.FindElement(By.Id("input-email")).SendKeys("nenadicp@gmail.com");
            driver.FindElement(By.Id("input-telephone")).Clear();
            driver.FindElement(By.Id("input-telephone")).SendKeys("234534534523");
            driver.FindElement(By.Id("input-password")).Click();
            driver.FindElement(By.Id("input-password")).Clear();
            driver.FindElement(By.Id("input-password")).SendKeys("12345rfv");
            driver.FindElement(By.Id("input-confirm")).Click();
            driver.FindElement(By.Id("input-confirm")).Clear();
            driver.FindElement(By.Id("input-confirm")).SendKeys("12345rfv");
            driver.FindElement(By.XPath("//div[@id='content']/form/fieldset[3]/div/div/label")).Click();
            driver.FindElement(By.Name("agree")).Click();
            driver.FindElement(By.XPath("//input[@value='Continue']")).Click();
            driver.FindElement(By.LinkText("Continue")).Click();
            driver.FindElement(By.LinkText("My Account")).Click();
            driver.FindElement(By.LinkText("Downloads")).Click();
            driver.FindElement(By.XPath("//div[@id='top-links']/ul/li[2]/a/i")).Click();
            driver.FindElement(By.LinkText("Logout")).Click();
            driver.FindElement(By.XPath("//div[@id='top-links']/ul/li[2]/a/i")).Click();
            driver.FindElement(By.LinkText("Login")).Click();
            driver.FindElement(By.XPath("//form[@action='https://demo.opencart.com/index.php?route=account/login']")).Click();
            driver.FindElement(By.Id("input-email")).Click();
            driver.FindElement(By.Id("input-email")).Clear();
            driver.FindElement(By.Id("input-email")).SendKeys("nenadicp@gmail.com");
            driver.FindElement(By.Id("input-password")).Click();
            driver.FindElement(By.Id("input-password")).Clear();
            driver.FindElement(By.Id("input-password")).SendKeys("12345rfv");
            driver.FindElement(By.XPath("//input[@value='Login']")).Click();
            driver.FindElement(By.LinkText("Edit Account")).Click();
            driver.FindElement(By.Id("input-lastname")).Click();
            driver.FindElement(By.Id("input-lastname")).Clear();
            driver.FindElement(By.Id("input-lastname")).SendKeys("Nenadić");
            driver.FindElement(By.XPath("//input[@value='Continue']")).Click();
            driver.FindElement(By.XPath("//div[@id='top-links']/ul/li[2]/a/i")).Click();
            driver.FindElement(By.LinkText("Logout")).Click();
            driver.FindElement(By.LinkText("My Account")).Click();
            driver.FindElement(By.LinkText("Login")).Click();
            driver.FindElement(By.Id("input-email")).Click();
            driver.FindElement(By.Id("input-email")).Clear();
            driver.FindElement(By.Id("input-email")).SendKeys("nenadicp@gmail.com");
            driver.FindElement(By.Id("input-password")).Click();
            driver.FindElement(By.Id("input-password")).Clear();
            driver.FindElement(By.Id("input-password")).SendKeys("12345rfv");
            driver.FindElement(By.XPath("//input[@value='Login']")).Click();
            driver.FindElement(By.XPath("(//button[@type='button'])[5]")).Click();
            driver.FindElement(By.LinkText("Mac (1)")).Click();
            driver.FindElement(By.XPath("(//button[@type='button'])[9]")).Click();
            driver.FindElement(By.XPath("(//button[@type='button'])[5]")).Click();
            driver.FindElement(By.LinkText("My Account")).Click();
            driver.FindElement(By.XPath("//body")).Click();
            driver.FindElement(By.XPath("(//button[@type='button'])[5]")).Click();
            driver.FindElement(By.XPath("//div[@id='content']/div[2]")).Click();
            driver.FindElement(By.XPath("//form[@id='form-currency']/div/button/i")).Click();
            driver.FindElement(By.XPath("//form[@id='form-currency']/div/button/i")).Click();
            driver.FindElement(By.XPath("//div[@id='top-links']/ul/li[4]/a/i")).Click();
            driver.FindElement(By.LinkText("Estimate Shipping & Taxes")).Click();
            driver.FindElement(By.Id("input-country")).Click();
            new SelectElement(driver.FindElement(By.Id("input-country"))).SelectByText("Croatia");
            driver.FindElement(By.Id("input-zone")).Click();
            new SelectElement(driver.FindElement(By.Id("input-zone"))).SelectByText("Grad Zagreb");
            driver.FindElement(By.Id("input-zone")).Click();
            driver.FindElement(By.Id("input-postcode")).Click();
            driver.FindElement(By.Id("input-postcode")).Clear();
            driver.FindElement(By.Id("input-postcode")).SendKeys("10000");
            driver.FindElement(By.Id("button-quote")).Click();
            driver.FindElement(By.XPath("//div[@id='modal-shipping']/div/div/div[2]/div/label")).Click();
            driver.FindElement(By.Id("button-shipping")).Click();
            driver.FindElement(By.XPath("//a[contains(text(),'Checkout')]")).Click();
            driver.FindElement(By.XPath("//div[@id='accordion']/div/div/h4")).Click();
            driver.FindElement(By.LinkText("Use Coupon Code")).Click();
            driver.FindElement(By.Id("input-coupon")).Click();
            driver.FindElement(By.Id("input-coupon")).Clear();
            driver.FindElement(By.Id("input-coupon")).SendKeys("1231GHSABOEVWE");
            driver.FindElement(By.Id("button-coupon")).Click();
            driver.FindElement(By.Id("input-coupon")).Click();
            driver.FindElement(By.Id("input-coupon")).Click();
            // ERROR: Caught exception [ERROR: Unsupported command [doubleClick | id=input-coupon | ]]
            driver.FindElement(By.Id("input-coupon")).Clear();
            driver.FindElement(By.Id("input-coupon")).SendKeys("");
            driver.FindElement(By.XPath("//div[@id='accordion']/div[3]/div/h4")).Click();
            driver.FindElement(By.LinkText("Use Gift Certificate")).Click();
            driver.FindElement(By.XPath("//div[@id='content']/div[2]")).Click();
            driver.FindElement(By.Id("input-voucher")).Click();
            driver.FindElement(By.Id("input-voucher")).Clear();
            driver.FindElement(By.Id("input-voucher")).SendKeys("231234JBIUBJB");
            driver.FindElement(By.Id("button-voucher")).Click();
            driver.FindElement(By.XPath("//a[contains(text(),'Checkout')]")).Click();
            driver.FindElement(By.Name("quantity[540107]")).Click();
            driver.FindElement(By.Name("quantity[540107]")).Clear();
            driver.FindElement(By.Name("quantity[540107]")).SendKeys("10");
            driver.FindElement(By.XPath("//div[@id='content']/form/div/table/tbody/tr/td[4]/div/span/button/i")).Click();
            driver.FindElement(By.XPath("(//button[@type='button'])[10]")).Click();
            driver.FindElement(By.LinkText("Laptops & Notebooks")).Click();
            driver.FindElement(By.XPath("//nav[@id='menu']/div[2]/ul")).Click();
            driver.FindElement(By.LinkText("Monitors (2)")).Click();
            driver.FindElement(By.XPath("(//button[@type='button'])[10]")).Click();
            driver.FindElement(By.XPath("(//button[@type='button'])[13]")).Click();
            driver.FindElement(By.Id("cart-total")).Click();
            driver.FindElement(By.XPath("//div[@id='cart']/ul/li[2]/div/p/a/strong")).Click();
            driver.FindElement(By.XPath("//div[@id='content']/form/div/table/tbody/tr/td[3]")).Click();
            driver.FindElement(By.XPath("//div[@id='top-links']/ul/li/a/i")).Click();
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
