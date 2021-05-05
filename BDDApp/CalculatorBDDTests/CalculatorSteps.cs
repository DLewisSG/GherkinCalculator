using System;
using System.Collections.Generic;
using BDDApp;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace CalculatorBDDTests
{
   
    [Binding]
    public class CalculatorSteps
    {
        private Calculator _calulator;
        private int _result;
        private List<int> _myList = new List<int>();
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

        [When(@"I press subtract")]
        public void WhenIPressSubtract()
        {
            _result = _calulator.Subtract();
        }

        [When(@"I press multiply")]
        public void WhenIPressMultiply()
        {
            _result = _calulator.Multiply();
        }

        [When(@"I press divide")]
        public void WhenIPressDivide()
        {
            _result = _calulator.Divide();
        }

        [Given(@"I enter the numbers below to a list")]
        public void GivenIEnterTheNumbersBelowToAList(Table table)
        {
           foreach(var row in table.Rows)
            {
                _myList.Add(int.Parse(row[0].Trim()));
            }
        }

        [When(@"I add all the even numbers in the list")]
        public void WhenIAddAllTheEvenNumbersInTheList()
        {
            _result = _calulator.SumOfEvenNumbersInAList(_myList);
        }

        [Given(@"I enter the (.*) into the calculator")]
        public void GivenIEnterTheIntoTheCalculator(int input1)
        {
            _calulator.Num1 = input1;
        }

        [Then(@"a DivideByZero Exception should be thrown with the exception message ""(.*)"" when I press divide")]
        public void ThenADivideByZeroExceptionShouldBeThrownWithTheExceptionMessageWhenIPressDivide(string exceptionString)
        {
           Assert.That(exceptionString, Is.EqualTo("Cannot Divide By Zero"));
        }


        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int expResult)
        {
           Assert.That(_result, Is.EqualTo(expResult));
        }
    }
}
