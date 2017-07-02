Feature: BudgetController
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers


Scenario: Add a budget to db
        When add budget
        | Amount | Month   |
        | 2000   | 2017-02 |
        Then should have a message for adding successfully
        And should exist a budget record in budget table
        | Amount | YearMonth |
        | 2000   | 2017-02   |
