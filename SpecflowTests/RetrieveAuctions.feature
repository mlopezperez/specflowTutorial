Feature: Retrieve auctions from API
	In order to manage auctions in my custom application
	As an API consumer
	I want to retrieve distinct auctions from API

@controllerTest
Scenario: Get all auctions
	Given A list of 3 auctions stored in database	
	When I retrieve all actions from controller
	Then the returned result must have 3 elements

#@controllerTest
#Scenario Outline: 
#	Given A an auction stored with <id> and <StartDateTime>
#	When I retrieve the auction with the <id>
#	Then the returned auction must have <expectedId> and <ExpectedEndDate>
