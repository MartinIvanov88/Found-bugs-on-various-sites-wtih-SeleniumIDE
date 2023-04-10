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
public class OrderwithoutsizeselectionTest {
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
  public void orderwithoutsizeselection() {
    driver.Navigate().GoToUrl("https://www.exza.bg/");
    driver.Manage().Window.Size = new System.Drawing.Size(1552, 840);
    driver.FindElement(By.XPath("(//a[contains(text(),\'Връхни дрехи\')])[2]")).Click();
    driver.FindElement(By.XPath("//img[@alt=\'Парка с огромен  пух \']")).Click();
    driver.FindElement(By.XPath("//a[contains(text(),\'Добави в количката\')]")).Click();
    Assert.That(driver.FindElement(By.CssSelector(".sc-col_item_title > .title")).Text, Is.EqualTo("ПАРКА С ОГРОМЕН ПУХ , ЦВЯТ: , РАЗМЕР:"));
    driver.Close();
  }
}