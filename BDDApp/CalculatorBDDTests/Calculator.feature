Feature: CalculatorFeature
	Simple calculator for adding two numbers
	In order to avoid silly mistakes
	As a maths idiot
	I want to be able to do simple calculations

@mytag
Scenario: Add two numbers
	Given I have a calculator
	And I enter 5 and 2 into the calculator
	When I press add
	Then the result should be 7

	@mytag
Scenario: Subtract two numbers
	Given I have a calculator
	And I enter 5 and 2 into the calculator
	When I press subtract
	Then the result should be 3