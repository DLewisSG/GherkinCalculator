using System;
using BDDApp;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace CalculatorBDDTests
{
   
    [Binding]
    public class CalculatorFeatureSteps
    {
        private Calculator _calulator;
        private int _result;
       [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
           _calulator = new Calculator();
        }
        
        [Given(@"I enter (.*) and (.*) into the calculator")]
        public void GivenIEnterAndIntoTheCalculator(int num1, int num2)
        {
            _calulator.Num1 = num1;
            _calulator.Num2 = num2;
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
           _result = _calulator.Add();
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int expResult)
        {
           Assert.That(_result, Is.EqualTo(expResult));
        }
    }
}
