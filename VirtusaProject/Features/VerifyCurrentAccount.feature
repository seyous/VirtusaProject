Feature: VerifyCurrentAccount


@mytag
Scenario: Verify correct page
	Given I navigate to the URL
	When I click on Products and Services tab
	And I click on current account
	Then I am on the correct page


Scenario Outline: Verify current account products
	Given I navigate to the URL
	When I click on Products and Services tab
	And I click on current account
	Then there are "<Currentaccounts>" products

	Examples:
		| Currentaccounts		 |
		| Classic account        |
		| Club Lloyds account    |
		| Platinum account       |


Scenario: Verify platinium account fees
	Given I navigate to the URL
	When I click on Products and Services tab
	And I click on current account
	Then fees for Platinum account is "£21 per month"