@login
Feature: LI2 Log in to site
	As a valid LogIn user
	I want to be able to log in
	So I can access protected content

Background:
	Given these users
		| username | password |
		| demo     | demo2012 |
		| demo1    | demo321  |
	And I am on the start page

Scenario Outline: Invalid users should get rejected
	When I log in with the username "<invalid username>" and the password "<invalid password>"
	Then the login page should display "The user name or password provided is incorrect."

Scenarios:
	| invalid username | invalid password |
	| demo2012         | demo             |
	| foo              | bar              |

Scenario Outline: Valid users should get logged in
	When I log in with the username "<valid username>" and the password "<valid password>"
	Then the start page should display "<login success message>"

Scenarios:
	| valid username | valid password | login success message |
	| demo           | demo2012       | Hello, demo!          |
	| demo1          | demo321        | Hello, demo1!         |