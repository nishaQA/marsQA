Feature: Skills
	Simple calculator for adding two numbers

@mytag
Scenario: Add Skills to profile Page
	Given Seller is on profile page to add a new skill
	When The seller enters  new skill
	And Selects the skill level
	| Baking   | Beginner          |
	| Desserts| Intermediate |
	| Italian    | Expert          |
	Then A message should be displayed "Baking has been added to your skills"

	Scenario: Update Skills on profile Page
	Given Seller is on profile page Skills tab and clicks on edit button for Baking 
	When The seller updates skills 

	| Cookies   | Expert        |
	
	Then A message should be displayed "Cookies has been updated to your Skills"

	Scenario: Delete a skill from profile Page
	Given Seller is on profile page to Skills tab and clicks  on delete button for Cookies
	When The seller deletes Cookies Skill
	

	Then A message should be displayed "Cookies has been deleted from your Skills"
