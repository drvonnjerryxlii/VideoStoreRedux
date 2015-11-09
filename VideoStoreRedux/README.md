## Project Set-up (aka, what to get help with from Gil)
- How to use a database with Asp.net
- ORM set up 
- Seeding the database (seed data is already in json)
- Resources for building an API 
- How to set up routes
- Version control integration, specifically with github repositories
- Pushing, pulling, fetching
- How to stack front end on this
- Passing equivalent of instance variables to view layer
- Passing those to a front end framework like Angular or React

### [Original version (with seed data)](https://github.com/Ada-Developers-Academy/C3Projects--VideoStoreAPI)

## API Requirements
The API you build should have the following capabilities. The schema of your database/datastore, and the structure of the endpoints are completely up to you.

### Customers
- GET Retrieve a list of all customers
- GET Given a customer's id...
    - Customer info + List the movies they currently have checked out
    - (List the movies a customer has checked out in the past)
    - (ordered by check out date)
    - (includes return date)
- (DELETE A customer)

### Movies
- GET Retrieve a list of all movies
    - ordered by customer id
    - ordered by customer name
    - ordered by check out date
- GET Given a movie's title...
    - Movie details  
    - (Get a list of customers that have currently checked out a copy of the film)
    - (Get a list of customers that have checked out a copy in the past)

### (Rental)
- Given a customer's id and a movie's title ...
- POST "check out" one of the movie's inventory to the customer
- PATCH "check in" one of customer's rentals