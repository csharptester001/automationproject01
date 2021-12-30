Feature: SpecFlowFeature1
	In order to use the benefit on the website
	I will need to first sign up
@mytag

Scenario: Valid Sign up
	Given I navigate to the website
	And I click Sign Up
	And I enter my Username
	And I enter my Password
	When I cick on Sign up
	Then I should be able to register successfully
