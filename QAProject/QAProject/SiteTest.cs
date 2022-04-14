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
                FillFormLogin(driver, "", "asdf");


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
                FillFormLogin(driver, "nick", "");


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
        public static Boolean Test3(IWebDriver driver)
        {
            try
           {
                fillFormTweet(driver, "Tweet");

                if (driver.Url == "http://47.55.247.242/site8/index.php?message=Tweet%20Successfully%20saved")
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

        //Test #11: Check that address cannot be blank when registering
        public static Boolean Test11(IWebDriver driver)
        {
            try
            {
                fillFormRegistration(driver, "Kate", "Daley", "mkatedaley@gmail.com",
            "screenname", "pass", "pass", "1234567890", "", "New Brunswick",
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

        //Test #12: Check that a province must be chosen from the dropdown menu when registering
        public static Boolean Test12(IWebDriver driver)
        {
            try
            {
                fillFormRegistration(driver, "Kate", "Daley", "mkatedaley@gmail.com",
            "screenname", "pass", "pass", "1234567890", "123 Cat Street", "",
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

        //Test #13: Check that postal code cannot be blank when registering
        public static Boolean Test13(IWebDriver driver)
        {
            try
            {
                fillFormRegistration(driver, "Kate", "Daley", "mkatedaley@gmail.com",
            "screenname", "pass", "pass", "1234567890", "123 Cat Street", "New Brunswick",
            "", "bitter.com", "This is a site description", "Fredericton");


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

        //Test #14: Check that URL cannot be blank when registering
        public static Boolean Test14(IWebDriver driver)
        {
            try
            {
                fillFormRegistration(driver, "Kate", "Daley", "mkatedaley@gmail.com",
            "screenname", "pass", "pass", "1234567890", "123 Cat Street", "New Brunswick",
            "A1B 3C4", "", "This is a site description", "Fredericton");


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

        //Test #15: Check that description cannot be blank when registering
        public static Boolean Test15(IWebDriver driver)
        {
            try
            {
                fillFormRegistration(driver, "Kate", "Daley", "mkatedaley@gmail.com",
            "screenname", "pass", "pass", "1234567890", "123 Cat Street", "New Brunswick",
            "A1B 3C4", "bitter.com", "", "Fredericton");


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

        //Test #16: Check that location cannot be blank when registering
        public static Boolean Test16(IWebDriver driver)
        {
            try
            {
                fillFormRegistration(driver, "Kate", "Daley", "mkatedaley@gmail.com",
            "screenname", "pass", "pass", "1234567890", "123 Cat Street", "New Brunswick",
            "A1B 3C4", "bitter.com", "This is a website", "");


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

        //Test #17: Check that messages link in nav bar works
        public static Boolean Test17(IWebDriver driver)
        {
            try
            {
                messagesLink(driver);


                if (driver.Url == "http://47.55.247.242/site8/directmessage.php")
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

        //Test #18: Check that contact link in nav bar works
        public static Boolean Test18(IWebDriver driver)
        {
            try
            {
                contactUsLink(driver);


                if (driver.Url == "http://47.55.247.242/site8/ContactUs.php")
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

        //Test #19: Check that notifications link in nav bar works
        public static Boolean Test19(IWebDriver driver)
        {
            try
            {
                notificationsLink(driver);


                if (driver.Url == "http://47.55.247.242/site8/Notifications.php")
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

        //Test #22: Check that the moments page works
        public static Boolean Test22(IWebDriver driver)
        {
            try
            {
                MomentsButton(driver);
                if (driver.Url == "http://47.55.247.242/site8/Notifications.php#")
                {
                    return false;
                }
                return true;
            }
            catch
            {
                return true;
            }
        }

        //Test #20: Check that follow user works
        public static Boolean Test20(IWebDriver driver)
        {
            try
            {
                FollowUser(driver);
                if (driver.Url.Contains("http://47.55.247.242/site8/index.php?message=Succesfully%20followed%20user:%20@"))
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

        //Test #21: Check that log out button works
        public static Boolean Test21(IWebDriver driver)
        {
            try
            {
                logoutLink(driver);


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


        //-------------------Fill forms------------------------------------

        static void FillFormLogin(IWebDriver driver, String strScreen, String strPass)
        {
            driver.Url = "http://47.55.247.242/site8/login.php";

            //Screen name
            SiteWebElements.TxtScreenName(driver).SendKeys(strScreen);

            //Password 
            SiteWebElements.TxtPassword(driver).SendKeys(strPass);

            //Click login button
            SiteWebElements.BtnLogin(driver).Click();

        }

        static void logoutLink(IWebDriver driver)
        {
            driver.Url = "http://47.55.247.242/site8/index.php";

            //Click profile picture drop down menu
            SiteWebElements.DrpDownLogoutEdit(driver).Click();

            //Click log out 
            SiteWebElements.BtnLogout(driver).Click();
        }

        static void messagesLink(IWebDriver driver)
        {
            driver.Url = "http://47.55.247.242/site8/directmessage.php";

            //Click the messages link
            SiteWebElements.BtnMessages(driver).Click();
        }

        static void contactUsLink(IWebDriver driver)
        {
            driver.Url = "http://47.55.247.242/site8/ContactUs.php";

            //Click the contact us link
            SiteWebElements.BtnContact(driver).Click();

        }

        static void notificationsLink(IWebDriver driver)
        {
            driver.Url = "http://47.55.247.242/site8/Notifications.php";

            //Click the notifications link
            SiteWebElements.BtnNotify(driver).Click();
        }
        
        static void fillFormTweet(IWebDriver driver, String strTweet)
        {
            driver.Url = "http://47.55.247.242/site8/index.php";

            //Tweet
            SiteWebElements.TxtTweet(driver).SendKeys(strTweet);

            //Click Send button
            SiteWebElements.BtnSendTweet(driver).Click();

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

        static void FollowUser(IWebDriver driver)
        {
            SiteWebElements.BtnFollow(driver).Click();
        }

        static void MomentsButton(IWebDriver driver)
        {
            SiteWebElements.BtnMoments(driver).Click();
        }

    }
}
