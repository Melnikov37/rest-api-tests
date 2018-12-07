Feature: APIApplication

@mytag
Scenario: Get API response using given endpoint 
	Given I have a endpoint endpoint/
	When I call get method of api
	Then I get API response in json format

#http://mydomain.com/userinfomarion/userid	
Scenario Outline: Get user infomation using userid
	Given I have a endpoint userInfomarion/
	When I call get method of get user information using <userid>
	Then I will get user information

Examples: User Info
| userid    |
| user10001 |

#http://mydomain.com/userinfomarion/userid/AccountInformation?account={accountNumber}
Scenario Outline: Get user infomation using userid and accountnumber
	Given I have a endpoint userInfomarion/
	When I call get method of get user account information using <userid> and <accountNumber>
	Then I will get user information

Examples: User Info
| userid    | accountNumber |
| user10001 | 123456789     |
