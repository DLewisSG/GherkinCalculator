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
	And I enter <input1> and <input2> into the calculator
	When I press subtract
	Then the result should be <result>

	Examples: 
	|input1|input2|result|
	|1     |1     |0     |
	|0     |1     |-1    |
	|100   |-1    |101   |

		@mytag
Scenario: Multiply two numbers
	Given I have a calculator
	And I enter <input1> and <input2> into the calculator
	When I press multiply
	Then the result should be <result>

	Examples: 
	|input1|input2|result|
	|1     |1     |1     |
	|2     |3     |6     |
	|9     |9     |81    |
	|5     |-17   |-85   |

			@mytag
Scenario: Divide two numbers
	Given I have a calculator
	And I enter <input1> and <input2> into the calculator
	When I press divide
	Then the result should be <result>

	Examples: 
	|input1|input2|result|
	|1     |1     |1     |
	|8     |2     |4     |
	|10    |5     |2     |
	|36    |6     |6     |

	@mytag
	Scenario: Get sum of numbers divisible by 2
	Given I have a calculator
	And I enter the numbers below to a list
	| nums |
	|1     |
	|2     |
	|3     |
	|4     |
	|5     |
	When I add all the even numbers in the list
	Then the result should be 6

		@mytag
	Scenario: Divide by 0
	Given I have a calculator
	And I enter the <input1> into the calculator
	Then a DivideByZero Exception should be thrown with the exception message "Cannot Divide By Zero" when I press divide
	Examples: 
	| input1 |
	|1       |
	|6       |

