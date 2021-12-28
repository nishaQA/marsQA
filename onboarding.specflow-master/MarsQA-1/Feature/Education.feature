Feature: Education
	
@mytag
Scenario: Add New Education Details to Create Education
Given The sellers' is in the Education page
When  The sellers' click AddNew Button And Enter details  
Then  The sellers' able to view  Education has been Added

@mytag
Scenario: Update Exsisting Education Details
Given The sellers' is in the Education page
When The sellers' click Update button and Edit details
Then The sellers' able to see Education has been  Updated 
@mytag
Scenario: Delete Exsisiting Education Details
Given The sellers' is in the Education page
When The sellers' click the Delete button 
Then The message should be Education has been Deleted 

@mytag
Scenario:Add again Exsisting Education details 
Given The sellers' is in the Education page
When  The sellers' is click  AddNew button and Enter same details
Then The message should appear  The inforfamtion is already exists

@mytag
Scenario: Keep Blank feilds to create New Education 
Given The sellers' is in the Education page
When  The sellers' click AddNew button and keep blank details
Then  The message should display Please enter all fields  