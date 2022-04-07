using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace QA_FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Web Driver
            IWebDriver driver = new ChromeDriver(@"C:\Selenium");

            //Test #1: Sign Up Page... Check that first name cannot be blank
            Console.WriteLine("Test #1: Check that first name cannot be blank while signing up for an account");
            Boolean blnTest01;
            blnTest01 = SiteTests.Test1(driver);
            TestResult(blnTest01);


            //Test #2

            //Test #3

            //Test #4

            //Test #5

            //Test #6

            //Test #7

            //Test #8

            //Test #9

            //Test #10

            //Test #11

            //Test #12

            //Test #13

            //Test #14

            //Test #15

            
        }

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
