﻿using FirstProject.Pages;
using FirstProject.Pages.Admin;
using FirstProject.Pages.Contractor;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace FirstProject.Steps.Contractor.ClaimsTests
{
    [Binding]
    class CreateAndAssertClaims:BaseSteps
    {
        string invalid_values = GenerateRandomData.GenerateRandomSpecChar(5);
        string invalid_val = GenerateRandomData.GenerateRandomSpecChar(5);
        string acc_num_claim = GenerateRandomData.GenerateRandomNumber(3) + "-" + GenerateRandomData.GenerateRandomNumber(13) + "-" + GenerateRandomData.GenerateRandomNumber(2);
        string acc_num_claim2 = GenerateRandomData.GenerateRandomNumber(3) + "-" + GenerateRandomData.GenerateRandomNumber(13) + "-" + GenerateRandomData.GenerateRandomNumber(2);
        string number = GenerateRandomData.GenerateRandomNumber(4);
        string uniqua = GenerateRandomData.GenerateRandomNumberNoZero(1) + GenerateRandomData.GenerateRandomNumber(4);
        string monthly_claim = GenerateRandomData.GenerateRandomNumberNoZero(1) + GenerateRandomData.GenerateRandomNumber(4);
        string bicycle = GenerateRandomData.GenerateRandomNumberNoZero(1) + GenerateRandomData.GenerateRandomNumber(4);

//User logs in as a contractor and navigate on create claim page

        [Given(@"User logs in as contractor 1")]
        public void GivenUserNavigatesToInvoiceValidatorWebApp()
        {
            Driver.Navigate().GoToUrl("http://intnstest:50080");
            Precondition homePage = new Precondition(Driver);
            Claims contrHomePage = new Claims(Driver);
            Assert.That(homePage.IsSignInDisplayed(), Is.True, "Sign in page is not displayed.");
            homePage.UsernameInputField().SendKeys("IQService.contractor2");
            homePage.PasswordInputField().SendKeys("87108884-1cac-4b8d-a80e-692425c5f294");
            homePage.SignInButton().Click();
            Assert.That(contrHomePage.IsCreatePageDisplayed(), Is.True, "Home page is not displayed.");
            contrHomePage.ConAccNumberToPay().Clear();
            contrHomePage.CreateClaimButtonContr().Click();
        }

//When contractor select accounting period, enters valid values in accounting number to pay field
//and clicks on save button, new claim should be created.

        [When(@"Contractor select accounting period and enter valid values 1")]
        public void ContractorSelectAccPeriodAndEnterValidValues()
        {
            Claims createClaim1 = new Claims(Driver);
            createClaim1.RandomContAccountingPeriod();
            createClaim1.ConAccNumberToPay().Clear();
            createClaim1.ConAccNumberToPay().SendKeys(acc_num_claim);
            createClaim1.MonthlyClaimContr().Clear();
            createClaim1.MonthlyClaimContr().SendKeys(monthly_claim);
            createClaim1.UniquaContr().Clear();
            createClaim1.UniquaContr().SendKeys(uniqua);
            createClaim1.BicycleContr().Clear();
            createClaim1.BicycleContr().SendKeys(bicycle);
            createClaim1.CreateClaimButtonContr().Click();
        }
        [Then(@"Contractor is redirected to Claim list and new claim is visible in the table")]
        public void ContractorIsRedirectedToClaimListAndNewClaimIsVisibleInTheTable()
        {
            Claims createClaim2 = new Claims(Driver);
            Assert.That(createClaim2.IsListOfClaimsDisplayed(), Is.True, "List with claims is not displayed.");
            Assert.AreEqual(acc_num_claim, createClaim2.TableClaims().FindElement(By.XPath("//td[4][contains(string(), '" + acc_num_claim + "')]")).Text);
        }

//New claim should be in the list.     

        [When(@"Conrtactor logs out and admin logs in and navigates on contractors claim list")]
        public void ContractorLogsOutAdminLogsIn()
        {
            Claims createClaim = new Claims(Driver);
            createClaim.LogOutButtonContractor().Click();
            Precondition homePage = new Precondition(Driver);
            Assert.That(homePage.IsSignInDisplayed(), Is.True, "Sign in page is not displayed.");

            homePage.UsernameInputField().SendKeys("IQService.admin2");
            homePage.PasswordInputField().SendKeys("87108884-1cac-4b8d-a80e-692425c5f294");
            homePage.SignInButton().Click();

            ContractorClaims claim_categories2 = new ContractorClaims(Driver);
            claim_categories2.ContractorClaimsButton().Click();
            claim_categories2.ContractorClaimsListButton().Click();
            Assert.That(claim_categories2.IsContractorClaimsListDisplayed(), Is.True, "Contractor claims list is not displayed.");

        }

//Admin should be able to search and filter 

        [When(@"Filter and Search by username of contractor and by accounting number to pay for new claim")]
        public void SearchNewCreatedClaim()
        {
            ContractorClaims claim_categories2 = new ContractorClaims(Driver);

            claim_categories2.FilterSearchButton().Click();
            SelectElement searchCrit = new SelectElement(claim_categories2.SearchCriteria());

            LanguageContractor contrLang = new LanguageContractor(Driver);       
                searchCrit.SelectByValue("Account number to pay");            
            claim_categories2.SearchInput().SendKeys(acc_num_claim);
            claim_categories2.SearchSubmitButton().Click();
            Assert.AreEqual(acc_num_claim, claim_categories2.TableContractorClaims().FindElement(By.XPath("//td[5][contains(string(), '" + acc_num_claim + "')]")).Text);
                  claim_categories2.FilterSearchButton().Click();
        
            if (contrLang.LanguageDropDown().Text.Contains("EN"))
            {
                SelectElement accPerFrom = new SelectElement(claim_categories2.AccountingPeriodFrom());
                accPerFrom.SelectByValue("January 1990");
                SelectElement accPerTo = new SelectElement(claim_categories2.AccountingPeriodTo());
                accPerTo.SelectByValue("December 2100");
            }
            else
            {
                SelectElement accPerFrom = new SelectElement(claim_categories2.AccountingPeriodFrom());
                accPerFrom.SelectByValue("januar 1990");
                SelectElement accPerTo = new SelectElement(claim_categories2.AccountingPeriodTo());
                accPerTo.SelectByValue("decembar 2100");

            }
            claim_categories2.UsernameFilterInput().SendKeys("IQService.contractor2");
            claim_categories2.TotalFrom().SendKeys("0");
            claim_categories2.TotalTo().SendKeys("50000");
            claim_categories2.FilterSubmitButton().Click();
           

        }
        [Then(@"New searched claim by filter contractor is showed")]
        public void NewClaimIsDisplayedInTable()
        {
            ContractorClaims claim_categories2 = new ContractorClaims(Driver);
            Assert.AreEqual("IQService.contractor2", claim_categories2.TableContractorClaims().FindElement(By.XPath("//td[2][contains(string(), '" + "IQService.contractor2" + "')]")).Text);
            claim_categories2.TableContractorClaims().FindElement(By.XPath("//tr[contains(string(), '" + "IQService.contractor2" + "')]//td[7]//a")).Click();
            Assert.That(claim_categories2.IsDetailsPageDisplayed(), Is.True, "Details about contractor claim is not displayed.");

        }
    }
}
