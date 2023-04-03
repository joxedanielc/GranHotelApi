# Grand Hotel API

Gran Hotel, a well-known national hotel chain, requires keeping a record of all guests who enter through reception. In this sense, it is required to have an API that allows the registration of the guest's data.

## Features

- Check-in for guests
- Check-out for guests
- List of all history guests
- List of available rooms

# Table of contents

1. [Tech Stack](https://github.com/joxedanielc/GranHotelApi.git#tech-stack)
2. Code Explanation
   1. [Controllers](https://github.com/joxedanielc/GranHotelApi.git#controllers)
3. [Run Locally](https://github.com/joxedanielc/GranHotelApi.git#run-locally)
4. [Feedback](https://github.com/joxedanielc/GranHotelApi.git#feedback)
5. [License](https://github.com/joxedanielc/GranHotelApi.git#license)

## Tech Stack

**Client:** .Net Core, Entity Framework Core, Swagger, MySQL

## Code Explanation

### Controllers

This code defines an API controller called RoomsController that is responsible for handling room-related requests in a hotel application. The controller has a single action, GetAvailableRooms, which handles HTTP GET requests. This action returns a list of identifiers (IDs) of the available rooms, that is, those that are not occupied.

The controller uses an IRoomService instance to interact with the underlying data store and retrieve the room information. The GetAvailableRooms action calls the service's GetAllAsync method to get all the rooms, then filters out those that are vacant and selects their identifiers before returning them in the response.

## Run Locally

### Important:

Clone the project

```bash
  git clone https://github.com/joxedanielc/GranHotelApi.git
```

Go to the project directory

```bash
cd GranHotelApi
```

Install packages:

```bash
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Pomelo.EntityFrameworkCore.MySql
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.AspNetCore.Mvc.NewtonsoftJson
dotnet add package Swashbuckle.AspNetCore
```

Run Migrations

```bash
dotnet ef database update
```

## Feedback

If you have any feedback, please leave a comment.

## License

[MIT](https://choosealicense.com/licenses/mit/)