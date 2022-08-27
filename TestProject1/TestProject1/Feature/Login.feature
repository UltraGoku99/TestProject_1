Feature: Login
	Simple Login Functionality

@tag1
Scenario: To check Login is working correct
	Given User is on homepage
	When User enters username
	And User enters Password
	And User click on Login Button
	Then User should be able to see demo site
