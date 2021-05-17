# GraphQL in .Net Framework
A lot of the examples on the internet shows GraphQL server implementation in .Net core but rarely we find GraphQL implementation in .Net Framework. So this is my two cents for those who are looking for it.

There are two projects in the solution. 
1. Landlord.API - which has all the setup for GraphQL server. I use Ninject dependency injection for this project. 
2. Landlord.SRC - which has all the business logic.

## How to run locally
You need to use Postman (or other similar tools you are familier with) to make a GraphQL POST reqeust. The URL to the GraphQL server (after you run the Landlord.API project) is, https://localhost:44302/api/graphql (adjust your port number if needed).

A dummy GraphQL query is following 

``` { properties { objectNumber, street, city, postalCode, country, payments {id, paid, value, dateCreated, dateOverdue} } } ```



ENJOY!
