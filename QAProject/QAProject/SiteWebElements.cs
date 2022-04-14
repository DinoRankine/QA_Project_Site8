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
    class SiteWebElements
    {
        //--------------------WEB ELEMENTS FROM REGISTRATION PAGE---------------------
        public static IWebElement TxtFirstName(IWebDriver driver)
        {
            IWebElement txtFirstName = driver.FindElement(By.Id("firstname"));
            return txtFirstName;
        }
        public static IWebElement TxtLastName(IWebDriver driver)
        {
            IWebElement txtLastName = driver.FindElement(By.Id("lastname"));
            return txtLastName;
        }
        public static IWebElement TxtEmail(IWebDriver driver)
        {
            IWebElement txtEmail = driver.FindElement(By.Id("email"));
            return txtEmail;
        }
        public static IWebElement TxtScreen(IWebDriver driver)
        {
            IWebElement txtScreen = driver.FindElement(By.Id("username"));
            return txtScreen;
        }
        public static IWebElement TxtPass(IWebDriver driver)
        {
            IWebElement txtPass = driver.FindElement(By.Id("password"));
            return txtPass;
        }
        public static IWebElement TxtPassConfirm(IWebDriver driver)
        {
            IWebElement txtPassConfirm = driver.FindElement(By.Id("confirm"));
            return txtPassConfirm;
        }
        public static IWebElement TxtPhone(IWebDriver driver)
        {
            IWebElement txtPhone = driver.FindElement(By.Id("phone"));
            return txtPhone;
        }
        public static IWebElement TxtAddress(IWebDriver driver)
        {
            IWebElement txtAddress = driver.FindElement(By.Id("address"));
            return txtAddress;
        }
        public static IWebElement DdlProvince(IWebDriver driver)
        {
            IWebElement ddlProvince = driver.FindElement(By.Id("province"));
            return ddlProvince;
        }
        public static IWebElement TxtPostal(IWebDriver driver)
        {
            IWebElement txtPostal = driver.FindElement(By.Id("postalCode"));
            return txtPostal;
        }
        public static IWebElement TxtURL(IWebDriver driver)
        {
            IWebElement txtURL = driver.FindElement(By.Id("url"));
            return txtURL;
        }
        public static IWebElement TxtDesc(IWebDriver driver)
        {
            IWebElement txtDesc = driver.FindElement(By.Id("desc"));
            return txtDesc;
        }
        public static IWebElement TxtLocation(IWebDriver driver)
        {
            IWebElement txtLocation = driver.FindElement(By.Id("location"));
            return txtLocation;
        }
        public static IWebElement BtnRegister(IWebDriver driver)
        {
            IWebElement btnRegister = driver.FindElement(By.Id("button"));
            return btnRegister;
        }

        //--------------------WEB ELEMENTS FROM MAIN LOGIN PAGE---------------------


        //Screen name text box on main login page
        public static IWebElement TxtScreenName(IWebDriver driver)
        {
            IWebElement txtScreenName = driver.FindElement(By.Id("username"));
            return txtScreenName;
        }

        //Password text box on main login page
        public static IWebElement TxtPassword(IWebDriver driver)
        {
            IWebElement txtPassword = driver.FindElement(By.Id("password"));
            return txtPassword;
        }

        //Login button on main login page
        public static IWebElement BtnLogin (IWebDriver driver)
        {
            IWebElement btnLogin = driver.FindElement(By.Id("button"));
            return btnLogin;
        }

        //sign up link "Click Here" on main login page
        public static IWebElement LinkSignUp (IWebDriver driver)
        {
            IWebElement linkSignUp = driver.FindElement(By.LinkText("Click Here"));
            return linkSignUp;
        }

        //contact us button in top navigation bar on main login page
        public static IWebElement BtnContact (IWebDriver driver)
        {
            IWebElement btnContact = driver.FindElement(By.LinkText("Contact Us"));
            return btnContact;
        }

        //--------------------WEB ELEMENTS FROM HOME PAGE ONCE LOGGED IN---------------------

        //tweet text space on home page
        public static IWebElement TxtTweet (IWebDriver driver)
        {
            IWebElement txtTweet = driver.FindElement(By.Id("myTweet"));
            return txtTweet;
        }

        //"Send" button to publish your tweet, on the home page
        public static IWebElement BtnSendTweet (IWebDriver driver)
        {
            IWebElement btnSendTweet = driver.FindElement(By.Id("//input[@id='button']"));
            return btnSendTweet;
        }

        //"Messages" link on top nav bar on home page
        public static IWebElement BtnMessages (IWebDriver driver)
        {
            IWebElement btnMessages  = driver.FindElement(By.LinkText("Messages"));
            return btnMessages;
        }

        //"Notifications" link on top nav bar on home page
        public static IWebElement BtnNotify(IWebDriver driver)
        {
            IWebElement btnNotify = driver.FindElement(By.LinkText("Notifications"));
            return btnNotify;
        }


        //"Search" text box on top nav bar on home page
        public static IWebElement SearchTxtBox (IWebDriver driver)
        {
            IWebElement searchTxtBox = driver.FindElement(By.Id("search"));
            return searchTxtBox;
        }

        //"Search" button on top nav bar on home page
        public static IWebElement BtnSearch(IWebDriver driver)
        {
            IWebElement btnSearch = driver.FindElement(By.ClassName("btn btn-outline-success my-2 my-sm-0"));
            return btnSearch;
        }

        //Dropdown menu when clicking on profile picture on top nav bar on home page
        public static IWebElement DrpDownLogoutEdit (IWebDriver driver)
        {
            IWebElement drpdownLogoutEdit = driver.FindElement(By.Id("dropdown01"));
            return drpdownLogoutEdit;
        }

        //Logout button
        public static IWebElement BtnLogout(IWebDriver driver)
        {
            IWebElement btnLogout = driver.FindElement(By.LinkText("Logout"));
            return btnLogout;
        }

        //Follow button under "Who to Troll?"
        public static IWebElement BtnFollow(IWebDriver driver)
        {
            IWebElement btnFollow = driver.FindElement(By.ClassName("followbutton"));
            return btnFollow;
        }

        //Moments button
        public static IWebElement BtnMoments(IWebDriver driver)
        {
            IWebElement btnMoments = driver.FindElement(By.LinkText("Moments"));
            return btnMoments;
        }

        //Index page link
        public static IWebElement BtnIndex(IWebDriver driver)
        {
            IWebElement btnIndex = driver.FindElement(By.LinkText("Home"));
            return btnIndex;
        }
    }
}
