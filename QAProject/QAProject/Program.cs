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
            //SiteTest.SiteReset();

            //Web Driver
            IWebDriver driver = new ChromeDriver(@"C:\Selenium");

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

            //Test #3: Check that tweet can be sent
            //Console.WriteLine("Test #3: Check that tweet can be sent");
            //Boolean blnTest03;
            //blnTest03 = SiteTest.Test3(driver);
            //TestResult(blnTest03);

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
