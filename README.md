### [Original VideoStoreAPI Project (with seed data)](https://github.com/Ada-Developers-Academy/C3Projects--VideoStoreAPI)

## API Requirements
The API you build should have the following capabilities. The schema of your database/datastore, and the structure of the endpoints are completely up to you.

### Customers
- GET Retrieve a list of all customers
- GET Given a customer's id...
    - Customer info + List the movies they currently have checked out
    - (_List the movies a customer has checked out in the past_)
    - (_ordered by check out date_)
    - (_includes return date_)
- (_DELETE a customer_)

### Movies
- GET Retrieve a list of all movies
    - ordered by customer id
    - ordered by customer name
    - ordered by check out date
- GET Given a movie's title...
    - Movie details  
    - (_Get a list of customers that have currently checked out a copy of the film_)
    - (_Get a list of customers that have checked out a copy in the past_)

### (_Rental_)
- _POST "check out" one of the movie's inventory to the customer_
- _PATCH "check in" one of customer's rentals_