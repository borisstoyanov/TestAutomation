﻿using AutomationUtilities.FieldIDs;
using AutomationUtilities.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationUtilities.PageObjects.Maintanance.ReferenceData.ISINCodes
{
    public class PO_ISINCodes_Create
    {
        public PO_ISINCodes_Create()
        {
            try
            {
                Util.WaitForElementPresentByXPath("//*[text()='Create']", 60);
            }
            catch (Exception e)
            {
                Test.verificationErrors.Append(e);
                Assert.Fail("The page displayed is not as the expected one.");

            }
            Util.WaitForElementVisibleByXPath("//input[@id='ISINCode_Code']", 15);
            SetInputField("ISINCode_Code", Test.extRef = "TA" + Util.GetRandomID());
        }


        public PO_ISINCodes_Create SetInputField(String field, String value)
        {
            Browser.Browser.Instance.FindElement(By.Id(field)).SendKeys(value);
            return this;
        }


        public PO_ISINCodes_Create SelectUnderlyingCurrency(String value)
        {
            new SelectElement(Browser.Browser.Instance.FindElement(By.Id("ISINCode_UnderlyingCurrency"))).SelectByText(value);
            return this;
        }

        public void Create()
        {
            Browser.Browser.ClickByXPath("//input[@id='Save']");
            Thread.Sleep(2000);
        }
    }
}
