Feature: BudgetCreate
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Scenario: Add budget successfully
	Given go to adding budget
	When I add buget 2000 for  "2017-10"
	Then it should display msg "added successfully"