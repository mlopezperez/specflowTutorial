Feature: Retrieve auctions from API
	In order to manage auctions in my custom application
	As an API consumer
	I want to retrieve distinct auctions from API

@controllerTest
Scenario: Get all auctions
	Given A list of 3 auctions stored in database	
	When I retrieve all actions from controller
	Then the returned result must have 3 elements

@controllerTest
Scenario Outline: Check end date time is properly set
	Given A an auction with <id> and <StartDateTime>
	When I save it
	Then the auction in repo must have <expectedId> and <ExpectedEndDate>
	Examples: 
	| id | StartDateTime | searchId | expectedId | ExpectedEndDate |
	| 1  | "30/06/2017"  | 1        | 1          | "01/07/2017"    |
	| 2  | "19/06/2017"  | 2        | 2          | "20/06/2017"    |


