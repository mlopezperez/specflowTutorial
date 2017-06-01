Feature: Retrieve auctions from API
	In order to manage auctions in my custom application
	As an API consumer
	I want to retrieve distinct auctions from API

@controllerTest
Scenario: Get all auctions
	Given A list of 3 auctions stored in database	
	When I retrieve all actions
	Then the returned result must have 3 elements
