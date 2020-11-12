## SOPHIA TECHNOLOGIES LTD - Technical Challenge
## Solid Web Service + Client
Challenge

### Overview
Create a Web Service with Web API interface that implements the following method
with n-tier level architecture.
Int GetPrimeNumber(int index)
Where index is the index-th number
Example:

GetPrimeNumber(5)
=>	7

GetPrimeNumber(7)
=>	13

Extra:
Use BDD approach 

###Tier 1 - Persistency:
Add a Data access Layer to persist the results in a table designed as follow:
Int Index
Int PrimeValue

So the first time the function is called with an Index value, the calculation
is performed by the business logic, saved in the database and returned to the client.
From that moment, the result will be retrieved from the database (the result
is always the same for the same parameter value) saving computation time.
Extra:
Use Entity Framework Code First with migrations

###Tier 2 – Software Engineering Principles:
Show SOLID principles, separation of concerns and separation of layers.

###Tier 3 – Client Web Application:
Create a Web Application with a functional UI that consumes the service and displays
the result
