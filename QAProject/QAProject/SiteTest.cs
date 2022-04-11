using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace QAProject
{
    class SiteTest
    {
        private static MySqlConnection connection;

        public static void SiteReset()
        {
            string myConnectionString = "server=47.55.247.242;database=bitter-site8;uid=site8;pwd=gP0Sdwf0Ga4Tij20;";
            connection = new MySqlConnection(myConnectionString);
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "reset";
            command.CommandType = System.Data.CommandType.StoredProcedure;

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        //Tests

        //Test #1: Check that screen name cannot be blank when logging in
        public static Boolean Test1(IWebDriver driver)
        {
            try
            {
                fillFormLogin(driver, "", "asdf");


                if (driver.Url != "http://47.55.247.242/site8/index.php")
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        //Test #2: Check that password cannot be blank when logging in
        public static Boolean Test2(IWebDriver driver)
        {
            try
            {
                fillFormLogin(driver, "nick", "");


                if (driver.Url != "http://47.55.247.242/site8/index.php")
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        //Test #3: Check that tweet can be sent
        //public static Boolean Test3(IWebDriver driver)
        //{
        //    try
        //    {

        //        if ()
        //        {

        //        }
        //    }
        //    catch
        //    {

        //    }
        //}

        //Test #4: Check that first name cannot be blank when registering
        public static Boolean Test4(IWebDriver driver)
        {
            try
            {
                fillFormRegistration(driver, "", "Daley", "mkatedaley@gmail.com",
            "screenname", "pass", "pass", "1234567890", "123 Street", "New Brunswick", 
            "A1B 2C3", "bitter.com", "This is a site description", "Fredericton");


                if (driver.Url == "http://47.55.247.242/site8/login.php")
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        //Test #5: Check that last name cannot be blank when registering
        public static Boolean Test5(IWebDriver driver)
        {
            try
            {
                fillFormRegistration(driver, "Kate", "", "mkatedaley@gmail.com",
            "screenname", "pass", "pass", "1234567890", "123 Street", "New Brunswick",
            "A1B 2C3", "bitter.com", "This is a site description", "Fredericton");


                if (driver.Url == "http://47.55.247.242/site8/login.php")
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        //Test #6: Check that email cannot be blank when registering
        public static Boolean Test6(IWebDriver driver)
        {
            try
            {
                fillFormRegistration(driver, "Kate", "Daley", "",
            "screenname", "pass", "pass", "1234567890", "123 Street", "New Brunswick",
            "A1B 2C3", "bitter.com", "This is a site description", "Fredericton");


                if (driver.Url == "http://47.55.247.242/site8/login.php")
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        //Test #7: Check that screen name cannot be blank when registering
        public static Boolean Test7(IWebDriver driver)
        {
            try
            {
                fillFormRegistration(driver, "Kate", "Daley", "mkatedaley@gmail.com",
            "", "pass", "pass", "1234567890", "123 Street", "New Brunswick",
            "A1B 2C3", "bitter.com", "This is a site description", "Fredericton");


                if (driver.Url == "http://47.55.247.242/site8/login.php")
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        //Test #8: Check that password cannot be blank when registering
        public static Boolean Test8(IWebDriver driver)
        {
            try
            {
                fillFormRegistration(driver, "Kate", "Daley", "mkatedaley@gmail.com",
            "screenname", "", "pass", "1234567890", "123 Street", "New Brunswick",
            "A1B 2C3", "bitter.com", "This is a site description", "Fredericton");


                if (driver.Url == "http://47.55.247.242/site8/login.php")
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        //Test #9: Check that confirm password cannot be blank when registering
        public static Boolean Test9(IWebDriver driver)
        {
            try
            {
                fillFormRegistration(driver, "Kate", "Daley", "mkatedaley@gmail.com",
            "screenname", "pass", "", "1234567890", "123 Street", "New Brunswick",
            "A1B 2C3", "bitter.com", "This is a site description", "Fredericton");


                if (driver.Url == "http://47.55.247.242/site8/login.php")
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        //Test #10: Check that phone number cannot be blank when registering
        public static Boolean Test10(IWebDriver driver)
        {
            try
            {
                fillFormRegistration(driver, "Kate", "Daley", "mkatedaley@gmail.com",
            "screenname", "pass", "pass", "", "123 Street", "New Brunswick",
            "A1B 2C3", "bitter.com", "This is a site description", "Fredericton");


                if (driver.Url == "http://47.55.247.242/site8/login.php")
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        //Test #11: Follow User
        //public static Boolean Test11(IWebDriver driver)
        //{
        //    try
        //    {
        //        fillFormLogin(driver, "nick", "");


        //        if (driver.Url != "http://47.55.247.242/site8/index.php")
        //        {
        //            return true;
        //        }
        //        return false;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

        //Fill forms
        static void fillFormLogin(IWebDriver driver, String strScreen, String strPass)
        {
            driver.Url = "http://47.55.247.242/site8/login.php";

            //Screen name
            SiteWebElements.TxtScreenName(driver).SendKeys(strScreen);

            //Password 
            SiteWebElements.TxtPassword(driver).SendKeys(strPass);

            //Click login button
            SiteWebElements.BtnLogin(driver).Click();

        }
        
        static void fillFormIndex(IWebDriver driver, String strTweet, String strSearch)
        {
            driver.Url = "http://47.55.247.242/site8/index.php";

            //Tweet
            SiteWebElements.TxtTweet(driver).SendKeys(strTweet);

            //Click Send button
            SiteWebElements.BtnSendTweet(driver).Click();

            //Search
            SiteWebElements.SearchTxtBox(driver).SendKeys(strSearch);

        }
        static void fillFormRegistration(IWebDriver driver, String strFirstName, String strLastName, String strEmail,
            String strScreen, String strPass, String strPassConfirm, String strPhone, String strAddress,
            String strProvince, String strPostal, String strURL, String strDesc, String strLocation)
        {
            //Load the registration page
            driver.Url = "http://47.55.247.242/site8/signup.php";

            //First name
            SiteWebElements.TxtFirstName(driver).SendKeys(strFirstName);

            //Last name
            SiteWebElements.TxtLastName(driver).SendKeys(strLastName);

            //Email
            SiteWebElements.TxtEmail(driver).SendKeys(strEmail);

            //Screen name
            SiteWebElements.TxtScreen(driver).SendKeys(strScreen);

            //Password 
            SiteWebElements.TxtPass(driver).SendKeys(strPass);

            //Confirm
            SiteWebElements.TxtPassConfirm(driver).SendKeys(strPassConfirm);

            //Phone
            SiteWebElements.TxtPhone(driver).SendKeys(strPhone);

            //Address
            SiteWebElements.TxtAddress(driver).SendKeys(strAddress);

            //Province
            SiteWebElements.DdlProvince(driver).SendKeys(strProvince);

            //Postal Code
            SiteWebElements.TxtPostal(driver).SendKeys(strPostal);

            //URL
            SiteWebElements.TxtURL(driver).SendKeys(strURL);

            //Description
            SiteWebElements.TxtDesc(driver).SendKeys(strDesc);

            //Location
            SiteWebElements.TxtLocation(driver).SendKeys(strLocation);

            //Click register button
            SiteWebElements.BtnRegister(driver).Click();

        }

        //static void FollowUser(IWebDriver driver)
        //{
        //    IWebElement btnRegister = driver.FindElement(By.Id("button"));
        //    btnRegister.Click();

        //}



    }
}
