Feature: Language
	Simple calculator for adding two numbers

@mytag
Scenario: Add Languages to profile Page
	Given Seller is on profile page to add a new language
	When The seller enters  new language
	And Selects the language level
	| English   | Fluent           |
	| Malayalam | Native/Bilingual |
	| Hindi     | Fluent           |
	| Marathi   | Fluent           |

	Then A message should be displayed "English has been added to your languages"


	Scenario: Add  4 Languages to profile Page
	Given Seller is on profile page to add a new language
	When The seller enters  new language
	And Selects the language level
	| English   | Fluent           |
	| Malayalam | Native/Bilingual |
	| Hindi     | Fluent           |
	| Marathi   | Fluent           |
	| French | Basic         |
	| Spanish  | Conversational           |

	Then A message should be displayed "You can do up to a maximum of four selections"
	
	
	Scenario: Repeat Languages on profile Page
	Given Seller is on profile page to add a new language
	When The seller enters  English language
	And Selects the language level as Fluent
	| English   | Fluent           |
	

	Then A message should be displayed "The lanuage is already excist in your language list"


	Scenario: Leave  Languages field blank and level field Blank on  profile Page
	Given Seller is on profile page to add a new language
	When The seller enters  null  language
	And Selects the language level as Null
	| Null   | Null          |
	

	Then A message should be displayed "Please enter language and level"



	Scenario: Leave  Languages field blank on  profile Page
	Given Seller is on profile page to add a new language
	When The seller enters  null  language
	And Selects the language level as Fluent
	| Null   | Fluent        |
	

	Then A message should be displayed "Please enter language and level"


	Scenario: Leave  Level field  blank on  profile Page
	Given Seller is on profile page to add a new language
	When The seller enters  French language
	And Selects the language level as Null
	| French  | Null        |
	

	Then A message should be displayed "Please enter language and level"



	Scenario: Update Languages to profile Page
	Given Seller is on profile page language tab and clicks on edit button for english 
	When The seller updates language 

	| Mandarin   | Basic         |
	
	Then A message should be displayed "Mandarin has been updated to your languages"

	Scenario: Delete Languages to profile Page
	Given Seller is on profile page to language tab and clicks  on delete button for Mandarin
	When The seller deletes Mandarin language
	

	Then A message should be displayed "Mandarin has been deleted from your languages"
