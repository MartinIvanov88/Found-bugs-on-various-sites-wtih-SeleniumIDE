// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class DifferencedescriptionforfreeshippingTest {
  private IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  [SetUp]
  public void SetUp() {
    driver = new ChromeDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
  }
  [TearDown]
  protected void TearDown() {
    driver.Quit();
  }
  [Test]
  public void differencedescriptionforfreeshipping() {
    driver.Navigate().GoToUrl("https://www.exza.bg/");
    driver.Manage().Window.Size = new System.Drawing.Size(1552, 840);
    driver.FindElement(By.XPath("(//a[contains(text(),\'Аксесоари\')])[2]")).Click();
    driver.FindElement(By.XPath("//a[contains(text(),\'Лента за коса L6\')]")).Click();
    driver.FindElement(By.XPath("//a[contains(text(),\'Червена чанта с пери\')]")).Click();
    var elements = driver.FindElements(By.XPath("//p/img"));
    Assert.True(elements.Count > 0);
    driver.FindElement(By.XPath("//a[contains(text(),\'Бяла чанта с пери\')]")).Click();
    Assert.That(driver.FindElement(By.XPath("//li/span/span[2]")).Text, Is.EqualTo(" до офис на Еконт ( за поръчки над 50 лв )"));
    driver.Close();
  }
}
