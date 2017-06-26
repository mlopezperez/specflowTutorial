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
	Given A an auction with <id> and <StartDateTime>
	When I save it	
	Then the auction in repo must have <expectedId> and <ExpectedEndDate>
	Examples: 
	| id | StartDateTime | expectedId | ExpectedEndDate |
	| 4  | "28/02/2016"  | 4          | "29/02/2016"    |
	| 5  | "28/02/2017"  | 5          | "01/03/2017"    |
	


@loginTest
Scenario Outline: Check login credentials
	Given the user credentials <login> and <password>
	When I try to log in 
	Then the server must return an <httpCode>
	Examples: 
	| login      | password       | httpCode |
	| aroaTrader | AroaTrader01   | 200      |
	| manuTrader | ManuPassword01 | 403      |


