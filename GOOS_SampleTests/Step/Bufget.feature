﻿@web
Feature: Bufget
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Scenario: Add a budget successfully
        Given go to adding budget page
        When I add a buget 2000 for "2017-10"
        Then it should display "added successfull"