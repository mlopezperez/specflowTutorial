Feature: Retrieve a list of auctions using our API
	In order to consume LeasePlan auctions from an external site
	As an external consumer
	I want to get the list of all stored auctions ir our system

Background: 
	Given An stored auction
	| id | startDateTime | endDateTime  |
	| 1  | "12/12/2017"  | "13/12/2017" |
	| 2  | "11/12/2017"  | "16/12/2017" |
	Given An auctions with id 3 and start time "22/12/2017" and end time "23/12/2017"

@retrieveTest
Scenario: Retrieve all stored auctions
	Given An auctions with id 3 and start time "22/12/2017" and end time "23/12/2017"
	When I get all auctions using API
	Then the returned list has 3 items

Scenario: Retrieve a single auction
	When I get the auction with id "1"
	Then the returned auction must have id "1" and start date "12/12/2017"


