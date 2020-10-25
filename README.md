# GraphQL in .Net Framework
A lot of the examples on the internet shows GraphQL server implementation in .Net core but rarely we find GraphQL implementation in .Net Framework. So this is my two cents for those who are looking for it.

<<<<<<< HEAD
There are two projects in the solution. Landlord.API which has all the setup for GraphQL server. I use Ninject dependency injection for the project. The other project is Landlord.SRC, which has all the business logic.
=======
There are two projects in the solution. LandlordDFK.API which has all the setup for GraphQL server. I use Ninject dependency injection for this project. The other project is LandlordDFK.SRC, which has all the business logic.
>>>>>>> a4e5dcc0820e7a93ef619cad2be7b1d568ee1d7b


How to run locally: You need to use Postman (or other similar tools you are familier with) to make a GraphQL reqeust. The URL to the GraphQL server (after you run the Landlord.API project) is something like this, https://localhost:44302/api/graphql (adjust your port number if needed).

A dummy GraphQL query is following 

{
  properties { payments {id} }
}



ENJOY!
