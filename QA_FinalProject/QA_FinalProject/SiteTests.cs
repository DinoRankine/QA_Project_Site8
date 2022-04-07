using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace QA_FinalProject
{
    class SiteTests
    {
        public static Boolean Test1(IWebDriver driver)
        {

        }

        static void fillForm(IWebDriver driver)
        {
            //Load the Sign Up form page
            driver.Url = "http://47.55.247.242/site8/signup.php";

            //First Name

            //Last Name

            //Email

            //Screen Name

            //Password

            //Confirm password

            //Phone

            //Address

            //Province

            //Postal Code

            //URL

            //Description

            //Location

            //Click Register button
            IWebElement btnRegister = driver.FindElement(By.Id("button"));
            btnRegister.Click();
        }
    }
}
