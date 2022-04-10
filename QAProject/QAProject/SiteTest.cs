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

        //public static void SiteReset()
        //{
        //    string myConnectionString = "server=47.55.247.242;database=bitter-site8;uid=nick;pwd=asdf;";
        //    connection = new MySqlConnection(myConnectionString);
        //    MySqlCommand command = new MySqlCommand();
        //    command.Connection = connection;
        //    command.CommandText = "reset";
        //    command.CommandType = System.Data.CommandType.StoredProcedure;

        //    connection.Open();
        //    command.ExecuteNonQuery();
        //    connection.Close();
        //}

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

        //Fill forms

        static void fillFormLogin(IWebDriver driver, String strScreen, String strPass)
        {
            driver.Url = "http://47.55.247.242/site8/login.php";

            //Screen name
            IWebElement txtScreen = driver.FindElement(By.Id("username"));
            txtScreen.SendKeys(strScreen);

            //Password 
            IWebElement txtPass = driver.FindElement(By.Id("password"));
            txtPass.SendKeys(strPass);

            //Click login button
            IWebElement btnLogin = driver.FindElement(By.Id("button"));
            btnLogin.Click();
            
            


        }
        
        static void fillFormIndex(IWebDriver driver, String strTweet, String strSearch)
        {
            driver.Url = "http://47.55.247.242/site8/index.php";

            //Tweet
            IWebElement txtTweet = driver.FindElement(By.Id("mytweet"));
            txtTweet.SendKeys(strTweet);

            //Click Send button
            IWebElement btnSend = driver.FindElement(By.Id("button"));
            btnSend.Click();

            //Search
            IWebElement txtSearch = driver.FindElement(By.Id("search"));
            txtSearch.SendKeys(strSearch);

            
        }
        static void fillFormRegistration(IWebDriver driver, String strFirstName, String strLastName, String strEmail,
            String strScreen, String strPass, String strPassConfirm, String strPhone, String strAddress,
            String strProvince, String strPostal, String strURL, String strDesc, String strLocation)
        {
            //Load the registration page
            driver.Url = "http://47.55.247.242/site8/signup.php";

            //First name
            IWebElement txtFirstName = driver.FindElement(By.Id("firstname"));
            txtFirstName.SendKeys(strFirstName);

            //Last name
            IWebElement txtLastName = driver.FindElement(By.Id("lastname"));
            txtLastName.SendKeys(strLastName);

            //Email
            IWebElement txtEmail = driver.FindElement(By.Id("email"));
            txtEmail.SendKeys(strEmail);

            //Screen name
            IWebElement txtScreen = driver.FindElement(By.Id("username"));
            txtScreen.SendKeys(strScreen);

            //Password 
            IWebElement txtPass = driver.FindElement(By.Id("password"));
            txtPass.SendKeys(strPass);

            //Confirm
            IWebElement txtPassConfirm = driver.FindElement(By.Id("confirm"));
            txtPassConfirm.SendKeys(strPassConfirm);

            //Phone
            IWebElement txtPhone = driver.FindElement(By.Id("phone"));
            txtPhone.SendKeys(strPhone);

            //Address
            IWebElement txtAddress = driver.FindElement(By.Id("address"));
            txtAddress.SendKeys(strAddress);

            //Province
            IWebElement ddlProvince = driver.FindElement(By.Id("province"));
            ddlProvince.SendKeys(strProvince);

            //Postal Code
            IWebElement txtPostal = driver.FindElement(By.Id("postalCode"));
            txtPostal.SendKeys(strPostal);

            //URL
            IWebElement txtURL = driver.FindElement(By.Id("url"));
            txtURL.SendKeys(strURL);

            //Description
            IWebElement txtDesc = driver.FindElement(By.Id("desc"));
            txtDesc.SendKeys(strDesc);

            //Location
            IWebElement txtLocation = driver.FindElement(By.Id("location"));
            txtLocation.SendKeys(strLocation);

            //Click register button
            IWebElement btnRegister = driver.FindElement(By.Id("button"));
            btnRegister.Click();

        }



    }
}
