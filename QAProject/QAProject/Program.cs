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
    class Program
    {
        static void Main(string[] args)
        {
            // Reset site
            SiteTest.SiteReset();

            //Web Driver
            IWebDriver driver = new ChromeDriver(@"C:\Selenium");

            //------------------------REGISTRATION TESTS--------------------------

            //Test #4: Check that first name cannot be blank when registering
            Console.WriteLine("Test #4: Check that first name cannot be blank when registering");
            Boolean blnTest04;
            blnTest04 = SiteTest.Test4(driver);
            TestResult(blnTest04);

            //Test #5: Check that last name cannot be blank when registering
            Console.WriteLine("Test #5: Check that last name cannot be blank when registering");
            Boolean blnTest05;
            blnTest05 = SiteTest.Test5(driver);
            TestResult(blnTest05);

            //Test #6: Check that email cannot be blank when registering
            Console.WriteLine("Test #6: Check that email cannot be blank when registering");
            Boolean blnTest06;
            blnTest06 = SiteTest.Test6(driver);
            TestResult(blnTest06);

            //Test #7: Check that screen name cannot be blank when registering
            Console.WriteLine("Test #7: Check that screen name cannot be blank when registering");
            Boolean blnTest07;
            blnTest07 = SiteTest.Test7(driver);
            TestResult(blnTest07);

            //Test #8: Check that password cannot be blank when registering
            Console.WriteLine("Test #8: Check that password cannot be blank when registering");
            Boolean blnTest08;
            blnTest08 = SiteTest.Test8(driver);
            TestResult(blnTest08);

            //Test #9: Check that confirm password cannot be blank when registering
            Console.WriteLine("Test #9: Check that confirm password cannot be blank when registering");
            Boolean blnTest09;
            blnTest09 = SiteTest.Test9(driver);
            TestResult(blnTest09);

            //Test #10: Check that phone number cannot be blank when registering
            Console.WriteLine("Test #10: Check that phone number cannot be blank when registering");
            Boolean blnTest10;
            blnTest10 = SiteTest.Test10(driver);
            TestResult(blnTest10);

            //Test #11: Check that address cannot be blank when registering
            Console.WriteLine("Test #11: Check that address cannot be blank when registering");
            Boolean blnTest11;
            blnTest11 = SiteTest.Test11(driver);
            TestResult(blnTest11);

            //Test #12: Check that province cannot be blank when registering
            Console.WriteLine("Test #12: Check that a province must be chosen from the dropdown menu when registering");
            Boolean blnTest12;
            blnTest12 = SiteTest.Test12(driver);
            TestResult(blnTest12);

            //Test #13: Check that postal code cannot be blank when registering
            Console.WriteLine("Test #13: Check that postal code cannot be blank when registering");
            Boolean blnTest13;
            blnTest13 = SiteTest.Test13(driver);
            TestResult(blnTest13);

            //Test #14: Check that URL cannot be blank when registering
            Console.WriteLine("Test #14: Check that URL cannot be blank when registering");
            Boolean blnTest14;
            blnTest14 = SiteTest.Test14(driver);
            TestResult(blnTest14);

            //Test #15: Check that description cannot be blank when registering
            Console.WriteLine("Test #15: Check that description cannot be blank when registering");
            Boolean blnTest15;
            blnTest15 = SiteTest.Test15(driver);
            TestResult(blnTest15);

            //Test #16: Check that location cannot be blank when registering
            Console.WriteLine("Test #16: Check that location cannot be blank when registering");
            Boolean blnTest16;
            blnTest16 = SiteTest.Test16(driver);
            TestResult(blnTest16);

            //------------------------LOGIN TESTS--------------------------

            //Test #1: Check that screen name cannot be blank when logging in
            Console.WriteLine("Test #1: Check that screen name cannot be blank when logging in");
            Boolean blnTest01;
            blnTest01 = SiteTest.Test1(driver);
            TestResult(blnTest01);

            //Test #2: Check that password cannot be blank when logging in
            Console.WriteLine("Test #2: Check that password cannt be blank when logging in");
            Boolean blnTest02;
            blnTest02 = SiteTest.Test2(driver);
            TestResult(blnTest02);

            //Test #24: Test login works correctly
            Console.WriteLine("Test #24: Test login works correctly");
            Boolean blnTest24;
            blnTest24 = SiteTest.Test24(driver);
            TestResult(blnTest24);

            //------------------------SITE FUNCTION TESTS--------------------------

            //Test #3: Check that tweet can be sent
            Console.WriteLine("Test #3: Check that tweet can be sent");
            Boolean blnTest03;
            blnTest03 = SiteTest.Test3(driver);
            TestResult(blnTest03);

            //Test #18: Check that the contact us link in nav bar works
            Console.WriteLine("Test #18: Check that contact us link in nav bar works");
            Boolean blnTest18;
            blnTest18 = SiteTest.Test18(driver);
            TestResult(blnTest18);

            //Test #17: Check that messages link in nav bar works
            Console.WriteLine("Test #17: Check that messages link in nav bar works");
            Boolean blnTest17;
            blnTest17 = SiteTest.Test17(driver);
            TestResult(blnTest17);

            //Test #19: Check that notifications link in nav bar works
            Console.WriteLine("Test #19: Check that notifications link in nav bar works");
            Boolean blnTest19;
            blnTest19 = SiteTest.Test19(driver);
            TestResult(blnTest19);

            //Test #22: Check that the moments page works
            Console.WriteLine("Test #22: Check that the moments page works");
            Boolean blnTest22;
            blnTest22 = SiteTest.Test22(driver);
            TestResult(blnTest22);

            //Test #23: Check that the index page link works
            Console.WriteLine("Test #23: Check that the index page link works");
            Boolean blnTest23;
            blnTest23 = SiteTest.Test23(driver);
            TestResult(blnTest23);

            //Test #20: Check that follow user works
            Console.WriteLine("Test #20: Follow User");
            Boolean blnTest20;
            blnTest20 = SiteTest.Test20(driver);
            TestResult(blnTest20);

            //Test #25: Test profile picture button
            Console.WriteLine("Test #25: Test profile picture button");
            Boolean blnTest25;
            blnTest25 = SiteTest.Test25(driver);
            TestResult(blnTest25);

            //Test #21: Check that log out button works
            Console.WriteLine("Test #21: Check that log out button works");
            Boolean blnTest21;
            blnTest21 = SiteTest.Test21(driver);
            TestResult(blnTest21);

            //Test #26: Check that you can register with special characters as first name
            Console.WriteLine("Test #26: Check that you can register with special characters as first name");
            Boolean blnTest26;
            blnTest26 = SiteTest.Test26(driver);
            TestResult(blnTest26);

            //Test #27: Check that you can register with email in wrong format
            Console.WriteLine("Test #27: Check that you can register with email in wrong format");
            Boolean blnTest27;
            blnTest27 = SiteTest.Test27(driver);
            TestResult(blnTest27);

            //Test #28: Check that you can register with special characters as postal code
            Console.WriteLine("Test #28: Check that you can register with special characters as postal code");
            Boolean blnTest28;
            blnTest28 = SiteTest.Test28(driver);
            TestResult(blnTest28);

            // Pause then quit
            Thread.Sleep(9000);
            driver.Quit();
        }

        // Send pass or fail to the console
        static void TestResult(Boolean blnResult)
        {
            if (blnResult)
            {
                Console.WriteLine("Passed!");
            }
            else
            {
                Console.WriteLine("Failed!");
            }
        }
    }
}
