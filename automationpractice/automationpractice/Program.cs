using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace automationpractice
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

         
         //  IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
         //   string title = (string)js.ExecuteScript("popup.js");

            driver.Url = "https://accounts.google.com/ServiceLogin/identifier?hl=en-GB&flowName=GlifWebSignIn&flowEntry=AddSession";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //email id
            driver.FindElement(By.Id("identifierId")).SendKeys("ajay13596@gmail.com" + Keys.Enter);
            //driver.FindElement(By.Id("identifierNext")).Click();
            Thread.Sleep(2000);

            //password
            //enter your password here
            driver.FindElement(By.XPath("//input[@type='password']")).SendKeys("password" + Keys.Enter);
            Thread.Sleep(2000);
            //security page for menu options
            driver.FindElement(By.XPath("//div[@id='gbwa']//div[@class='gb_Nc']//a[@class='gb_b']")).Click();
            //selecting email
       //     driver.FindElement(By.XPath("//a[@id='gb23']")).Click();
            driver.FindElement(By.XPath(" //a[@id='gb23']//span[@class='gb_2']")).Click();
           
            //waiting for redirected to email
            Thread.Sleep(1000);
            //compose button
           // driver.FindElement(By.Id(" //div[@class='z0']")).Click();

            //compose button
             driver.FindElement(By.XPath("//div[@class='T-I J-J5-Ji T-I-KE L3']")).Click();
            Thread.Sleep(1000);

            //recipient address
            driver.FindElement(By.XPath(" //textarea[@id=':os']")).SendKeys("ajay13596@gmail.com" + Keys.Tab); Thread.Sleep(1000);
            //heading of mail
            driver.FindElement(By.XPath(" //input[@id=':oa']")).SendKeys("sample heading for mail" + Keys.Tab); Thread.Sleep(1000);
            //mesage body

            driver.FindElement(By.XPath("//div[@id=':pe']")).SendKeys("sample body for mail\n hello world!!" + Keys.Tab); Thread.Sleep(1000);
            //send button
            driver.FindElement(By.XPath("//div[@id=':o0']")).Click();

        }
        //IWebDriver driver = new ChromeDriver();
        //driver.Url = "http://sangam.ggktech.com";
        //driver.Manage().Window.Maximize();
        //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        //driver.FindElement(By.Id("identifierId")).SendKeys("amith.nomula@ggktech.com" + Keys.Enter);
        ////driver.FindElement(By.Id("identifierNext")).Click();
        //Thread.Sleep(2000);
        //driver.FindElement(By.XPath("//input[@type='password']")).SendKeys("Amith@123" + Keys.Enter);
        //Thread.Sleep(2000);
        //driver.FindElement(By.XPath("//div[@class='unit status pending active']//div[@class='unit']//b")).Click();
        //// driver.FindElement(By.Id("identifierNext")).Click();
        //Thread.Sleep(2000);
        //driver.FindElement(By.XPath("//button[@title='Auto Fill']")).Click();
        //Thread.Sleep(2000);Kishore123
        //driver.FindElement(By.XPath("//input[@id='defaultTaskTypes']")).SendKeys("training" + Keys.Tab);
        //driver.FindElement(By.XPath("//input[@id='defaultTaskTypes']")).SendKeys("Advanced C#/.Net Training" + Keys.Tab);
        //driver.FindElement(By.XPath("//button[@class='btn btn-success margin-left-right-10 margin-bottom-20']")).Click();

    }
}
