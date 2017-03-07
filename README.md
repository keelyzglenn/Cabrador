# _Cabrador_

http://www.enlightenmental.com/news-blog/calculate-distance-using-javascript-and-google-maps-to-create-a-realtime-quote-based-on-distance/

https://www.youtube.com/watch?v=obOa8fdJ9aQ

https://jmperezperez.com/google-maps-geolocation-directions-specific-destination/

#### _Ride share app with dogs, 3.3.17_

#### By _**Katy Daviscourt, Cassie Musolf, Caitlin Hines, Keely Glenn**_

## Description

_This webpage allows the user to create an account and book a ride with a driver and a cute dog._

## Setup/Installation Requirements

* Clone the git from the repository at https://github.com/katyisgreaty/Cabrador.
* In Powershell, navigate to the git's location
* In SQLCMD:
    * > CREATE DATABASE cabrador;
    * > GO
    * > USE cabrador;
    * > GO
    * > CREATE TABLE drivers (id INT IDENTITY(1,1), name VARCHAR(255), car VARCHAR(255), photo VARCHAR(255));
    * > CREATE TABLE dogs (id INT IDENTITY(1,1), name VARCHAR(255), breed VARCHAR(255), photo VARCHAR(255), shelter VARCHAR(255) adopted TINYINT);
    * > CREATE TABLE customers (id INT IDENTITY(1,1), name VARCHAR(255), photo VARCHAR(255), email VARCHAR(255), password VARCHAR(255));
    * > CREATE TABLE trips (id INT IDENTITY(1,1), start_point VARCHAR(255), destination VARCHAR(255), price INT, miles INT, date DATETIME);
    * > CREATE TABLE customers_dogs_drivers_trips (id INT IDENTITY(1,1), driver_id INT, dog_id INT, customer_id INT, trip_id INT);
    * > GO
* Backup and restore database, naming the restored database cabrador_test
* Type "dnx kestrel" into Powershell
* In the browser, to go "localhost:5004" to view webpage


## Specifications

### Customers

* The get all method gets a list of all customers
  * ex input: get all
  * ex output: list of all customers

* The add method will add a new customer to the database
  * ex input: Bill, wwww.photoofbill.com
  * ex output: saved

* Find by Id method can find a particular customer
  * ex input: find by id
  * ex output: found customer returned

* Find by Log In method can find a particular customer
  * ex input: find by email and password
  * ex output: found customer returned

* Update properties method can update customers properties
  * ex input: edit name or photo
  * ex output: updated

* Delete method can delete single customer from database
  * ex input: delete account
  * ex output: deleted

* The get all trips gets a list of all trips (with driver name, dog name, and all trip properties) automatically order by date
  * ex input: get all trips
  * ex output: list of all trips (with driver name, dog name, and all trip properties) by date


### Dogs
* The get all method gets a list of all dogs
  * ex input: get all
  * ex output: list of all dogs

* Find by Id method can find a particular dog
  * ex input: find by id
  * ex output: found dog returned

* Update (Adopt) method will change adoption status of dog
  * ex input: adopt dog
  * ex output: dog adopted


### Drivers
* The get all method gets a list of all drivers
  * ex input: getall
  * ex output: list of all drivers

* Find by Id method can find a particular driver
  * ex input: find by id
  * ex output: found driver returned

### Trips

* The add method will add a new trip to the database
  * ex input: 1701 22nd ave, 802 pine st, $14, 6 miles
  * ex output: saved

* Get Distance method will calculate the miles between origin and destination
  * ex input: 1701 22nd ave, 802 pine st
  * ex output: output 5 miles

* Get price method will calculate price based on miles
  * ex input: 5 miles
  * ex output: base price = $10 + miles * .20



## Ice Box Specifications


  * The add method will add a new driver to the database
    * ex input: Alex, honda civic, greenlake, http/lkinkofphoto.pht
    * ex output: saved

  * The add method will add a new dog to the database
    * ex input: Puffles, Doberman, photolink.com, Seattle Humane Society
    * ex output: saved

  * Add extra price for extra dogs/puppies/breeds in car

  * quiz to figure out which




## Known Bugs

_None at this time._

## Support and contact details

_For questions or comments please contact us at cabrador_support@gmail.com_


## Technologies Used

_C#, MSSQL_

### License

*Available under an MIT License*

Copyright (c) 2017 **_Katy Daviscourt, Cassie Musolf, Caitlin Hines, Keely Glenn_**
