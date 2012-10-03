@login
Feature: LI1 Log in to site
	As a valid LogIn user
	I want to be able to log in
	So I can access protected content

Scenario: User with valid credentials logs in
	Given I have a user with username "demo" and password "demo2012"
	And I am on the start page
	When I log in with the username "demo" and the password "demo2012"
	Then the start page should display "Hello, demo!"

Scenario: User with invalid credentials tries to log in
	Given I am on the start page
	When I try to log in with the username "invalid" and the password "invalid"
	Then the login page should display "The user name or password provided is incorrect."
