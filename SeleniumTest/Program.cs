﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com");
            Thread.Sleep(2000);

            IWebElement ele = driver.FindElement(By.Name("q"));
            ele.SendKeys("javatpoint tutorials");
            Thread.Sleep(2000);

            IWebElement ele1 = driver.FindElement(By.Name("btnK"));
            ele1.Click();
            Thread.Sleep(3000);

            driver.Close();
        }
    }
}
