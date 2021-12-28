using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    class Education
    {
        public static IWebElement EducationTab => Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
        public static IWebElement AddNewEdu => Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));


        public static IWebElement University => Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));
        public static IWebElement Country => Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));

        public static IWebElement CountryOpt => Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option[11]"));
        public static IWebElement Title => Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));

        public static IWebElement TitlteOPt => Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select/option[7]"));
        public static IWebElement Degree => Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));
        public static IWebElement GradYear => Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select"));
        public static IWebElement GradYearOpt => Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option[13]"));
        public static IWebElement AddButton => Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));



        public static void AddNewEduStep()
        {
            //Driver.NavigateUrl();
            EducationTab.Click();
            AddNewEdu.Click();

            University.SendKeys("ACC");
            Country.Click();
            CountryOpt.Click();
            Title.Click();
            TitlteOPt.Click();
            Degree.SendKeys("Electronics");
            GradYear.Click();
            GradYearOpt.Click();
            AddButton.Click();
        }
        public static void UpdateEduStep()
        {
            EducationTab.Click();
            AddNewEdu.Click();

            University.SendKeys("Sydney");
            Country.Click();
            CountryOpt.Click();
            Title.Click();
            TitlteOPt.Click();
            Degree.SendKeys("Mechanical");
            GradYear.Click();
            GradYearOpt.Click();
            AddButton.Click();

        }
        public static void DeleteEdustep()
        {
            Console.WriteLine("Deleted");
        }
    }
}
