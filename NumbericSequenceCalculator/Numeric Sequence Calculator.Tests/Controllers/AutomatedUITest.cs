using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WatiN.Core;

namespace Numeric_Sequence_Calculator.Tests.Controllers
{
    [TestClass]
    public class AutomatedUITest
    {
        private string WebsiteURL = "http://localhost/NumericSequenceCalculator";

        [TestMethod]
        public void UIEnter123AndSubmit()
        {
            using (var browser = new IE(WebsiteURL))
            {
                browser.TextField(Find.ById("txtMagicNumber")).TypeText("123");
                browser.Button(Find.ById("calculateSequenceBtn")).Click();
                Assert.IsTrue(browser.ContainsText("All Numbers up to and including: 123"));
            }
        }

        [TestMethod]
        public void UITestNumericValidation()
        {
            using (var browser = new IE(WebsiteURL))
            {
                browser.TextField(Find.ById("txtMagicNumber")).TypeText("GGG");
                browser.Button(Find.ById("calculateSequenceBtn")).Click();
                Assert.IsTrue(browser.ContainsText("The field Number must be a number"));
            }
        }

        [TestMethod]
        public void UIEnter12AndCheckAllResults()
        {
            using (var browser = new IE(WebsiteURL))
            {
                browser.TextField(Find.ById("txtMagicNumber")).TypeText("12");
                browser.Button(Find.ById("calculateSequenceBtn")).Click();
                var item = browser.Div(Find.ById("allNumbersDiv")).Text;
                var expectedAllNumbersValue = "1,2,3,4,5,6,7,8,9,10,11,12";
                Assert.AreEqual(item,expectedAllNumbersValue);
            }
        }
        [TestMethod]
        public void UIEnter12AndCheckEvenResults()
        {
            using (var browser = new IE(WebsiteURL))
            {
                browser.TextField(Find.ById("txtMagicNumber")).TypeText("12");
                browser.Button(Find.ById("calculateSequenceBtn")).Click();
                var item = browser.Div(Find.ById("allNumbersEvenDiv")).Text;
                var expectedAllNumbersValue = "2,4,6,8,10,12";
                Assert.AreEqual(item, expectedAllNumbersValue);
            }
        }
        [TestMethod]
        public void UIEnter12AndCheckOddResults()
        {
            using (var browser = new IE(WebsiteURL))
            {
                browser.TextField(Find.ById("txtMagicNumber")).TypeText("12");
                browser.Button(Find.ById("calculateSequenceBtn")).Click();
                var item = browser.Div(Find.ById("allNumbersOddDiv")).Text;
                var expectedAllNumbersValue = "1,3,5,7,9,11";
                Assert.AreEqual(item, expectedAllNumbersValue);
            }
        }
        [TestMethod]
        public void UIEnter12AndCheckConditionalResults()
        {
            using (var browser = new IE(WebsiteURL))
            {
                browser.TextField(Find.ById("txtMagicNumber")).TypeText("12");
                browser.Button(Find.ById("calculateSequenceBtn")).Click();
                var item = browser.Div(Find.ById("allNumbersConditionalDiv")).Text;
                var expectedAllNumbersValue = "1,2,C,4,E,C,7,8,C,E,11,C";
                Assert.AreEqual(item, expectedAllNumbersValue);
            }
        }
        [TestMethod]
        public void UIEnter12AndCheckFibonnaciResults()
        {
            using (var browser = new IE(WebsiteURL))
            {
                browser.TextField(Find.ById("txtMagicNumber")).TypeText("12");
                browser.Button(Find.ById("calculateSequenceBtn")).Click();
                var item = browser.Div(Find.ById("fibonnaciDiv")).Text;
                var expectedAllNumbersValue = "1,1,2,3,5,8";
                Assert.AreEqual(item, expectedAllNumbersValue);
            }
        }
    }
}
