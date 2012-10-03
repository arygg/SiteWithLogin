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


Scenario Template: User attempts to log in
	Given I have a user with username "<configured username>" and password "<configured password>"
	And I am on the start page
	When I log in with the username "<username>" and the password "<password>"
	Then the current page should display "<display message>"

Scenarios: 
	| configured username | configured password | username | password | display message                                  |
	| demo                | demo2012            | demo     | demo2012 | Hello, demo!                                     |
	| valid               | valid123            | invalid  | invalid  | The user name or password provided is incorrect. |
	| valid               | valid123            | valid    | invalid  | The user name or password provided is incorrect. |
	| valid               | valid123            | invalid  | valid    | The user name or password provided is incorrect. |

