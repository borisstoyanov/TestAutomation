﻿using AutomationUtilities.PageObjects;
using AutomationUtilities.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmirAutomation.Tests.ChannelsTab
{
    [TestClass]
    public class TTradeRepositoryAccounts_Detail : Test
    {
        bool storeResults = false;

        [TestInitialize]
        public void SetUp()
        {
            Test.SetTestName(TestContext);
            Test.LoginAsSystemUser();
        }

        [TestCategory("System"), TestCategory("Maintenance"), TestCategory("Channels"), TestCategory("RegressionTesting"), TestMethod()]
        public void TradeRepositoryAccount_ViewTradeRepositoryAccounts()
        {
            storeResults = true;
            PO_TradeRepositoryAccountsPopUp referenceDatas = PO_Dashboard.GoToTradeRepositoryAccountsPopUp();
            referenceDatas.CreateNewTradeRepositoryAccounts()
                .Create();
            referenceDatas.VerifyTradeRepositoryAccountsCreated();
            referenceDatas.ViewTradeRepositoryAccountsDetails();
            Test.result = "Passed";
        }
        [TestCleanup]
        public void TearDown()
        {
            Test.TearDown(storeResults);
        }
    }
}
