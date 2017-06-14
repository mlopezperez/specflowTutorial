Feature: Retrieve auctions from API
	In order to manage auctions in my custom application
	As an API consumer
	I want to retrieve distinct auctions from API
@controllerTest
Scenario: Get all auctions	
	Given A list of auctions stored in database
	| Id | StartDateTime |
	| 1  | "09/06/2017"  |
	| 2  | "01/06/2017"  |
	| 3  | "02/06/2017"  |
	When I retrieve all actions from controller
	Then the returned result must have 3 elements

@controllerTest
Scenario Outline: Check end date time is properly set
	Given A list of 3 auctions stored in database
	And A an auction with <id> and <StartDateTime>
	When I save it
	And I retrieve all actions from controller
	Then the auction in repo must have <expectedId> and <ExpectedEndDate>
	And the returned result must have 4 elements
	Examples: 
	| id | StartDateTime | expectedId | ExpectedEndDate |
	| 4  | "30/06/2017"  | 4          | "01/07/2017"    |
	| 5  | "19/06/2017"  | 5          | "20/06/2017"    |


