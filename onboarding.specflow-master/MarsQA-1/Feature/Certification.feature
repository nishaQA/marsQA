Feature: Certification
	Simple calculator for adding two numbers

@mytag
Scenario: Add New Certification Details to Create Certificate
Given The sellers' is in the Certification page
When  The sellers' click AddNew Button And Enter details  
Then  The sellers' able to view  Certificate Successfully Added

@mytag
Scenario: AUpdate Exsisting Certification Details
Given The sellers' is in the Certification page
When The sellers' click Update button and Edit details
Then The sellers' able to see Certificate Updated Successfully

@mytag
Scenario: Delete Exsisiting Certification Details
Given The sellers' is in the Certification page
When The sellers' click the Delete button 
Then The message should be Certificate Deleted Successfully

@mytag
Scenario:Add again Exsisting Certification details 
Given The sellers' is in the Certification page
When  The sellers' is click  AddNew button and Enter same details
Then The message should appear  Duplicate data

@mytag
Scenario: Keep Blank feilds to create New Certification 
Given The sellers' is in the Certification page
When  The sellers' click AddNew button and keep blank details
Then  The message should display Please enter Certificates 