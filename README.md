# Thrive
•	This Project is a Blazor Server application using .Net Core (5) and it tries to follow Clean Architecture. It has 8 projects including a Test project. It is broken down into different projects/modules to demonstrate separation of concerns including extensibility and scalability concepts. There is an eCommerce.bak file that can be restored in a local instance of SQL Server(localDB) to make it easier to run.

•	There is admin@test.com user which has Administrators role (to perform CRUD operations) and simple registering as a new user will only allow you to view only a list of products.

•	Most products will not show images as I was using web links to display online images during development and later switched to database storage to store images. You can simply sort by Product code to see test products that have images.

•	I have used Dapper for CRUD operations and EF Core for Authentication and Authorization (I wanted to apply the plugin concept in Clean Architecture). This is to show that the underlying data access should not matter, and it can be swapped for any suitable access method preferred. 

•	There is a Test project to test the service layer and you can simple right click and run tests

