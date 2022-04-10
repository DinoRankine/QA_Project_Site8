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
            IWebElement btnContact = driver.FindElement(By.XPath("//a[@id='navbarsExampleDefault']/a[2]/img"));
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
            IWebElement btnSendTweet = driver.FindElement(By.XPath("//input[@id='button']"));
            return btnSendTweet;
        }

        //"Messages" link on top nav bar on home page
        public static IWebElement BtnMessages (IWebDriver driver)
        {
            IWebElement btnMessages  = driver.FindElement(By.LinkText("Messages"));
            return btnMessages;
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
    }
}
