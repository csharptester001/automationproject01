Feature: SpecFlowFeature1
	Simple calculator for adding two numbers

@mytag
Scenario: Valid Sign in
	Given I navigate to the website
	And I click login button
	And I enter my Username
	And I enter my Password
	And I click Login
	Then I should be able to login
