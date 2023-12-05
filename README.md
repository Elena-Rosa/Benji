# Benji Api

#### By: Elena Rosa

## Description
An API with pagination. This application allows for a local animal shelter to create and edit animals as needed. Users are able to search for pets in need of a home. 

## Technologies Used
- C#
- ASP.NET Core MVC
- .NET 5.0
- Entity Framework Core
- HTML
- CSS


## Setup/Installation Requirements
- Note: An installation of the .NET SDK is required in order to run this application locally. [See Here](https://dotnet.microsoft.com/en-us/) for installation.
1. Clone this repo.
2. Open your shell (e.g., Terminal or GitBash) and navigate to this project's directory called "Factory.Solution/Factory". 
3. Create a file named `appsettings.json`: `$ touch appsettings.json`
4. Within `appsettings.json` add the following code, replacing the `uid` and `pwd` values with your own username and password for MySQL.

    ```json
    {
      "ConnectionStrings": {
          "DefaultConnection": "Server=localhost;Port=3306;database=Benji-database;uid=[YOUR-USERNAME];pwd=[YOUR-MYSQL-PASSWORD];"
      }
    }
    ```

5. Navigate to the project directory: `$ cd Benji`

6. Run the command dotnet restore to install necessary packages.

7. Run `$ dotnet watch run` in the command line to start the project in development mode with a watcher.

8. Run the command dotnet build to compile the application.

9. Run dotnet run to start the server and application.

10. Open the browser at: _https://localhost:5001_. If you cannot access localhost:5001 it is likely because you have not configured a .NET developer security certificate for HTTPS. 

11. This application used authentication with Identity. Users must create an account in order to create and edit items. 



# API Documentation

This document provides detailed descriptions and usage examples for each endpoint in the Benji Application

## Base URL

The base URL for all endpoints is: https://localhost:5001/api/animals

#### Description

Retrieve a list of animals based on specified filters.

#### Query Parameters

- `species` (string): Filter animals by species.
- `name` (string): Filter animals by name.
- `minimumAge` (int): Filter animals by minimum age.
- `breed` (string): Filter animals by breed.
- `gender` (string): Filter animals by gender.
- `adoptionStatus` (string): Filter animals by adoption status.

## Animal by ID
GET /api/animal/{id}
Retrieve details of a specific animal by its ID.

# Example Get request
https:/localhost:5001/api/animal/1"

# Response
{
  "animalID: 1
  "Species", dog,
  "name": "Benji",
  "age": "12,
  "breed": Poodlelab",
  "gender": "Male".
  "adopton status": "available"
}

## Add a New Animal
POST /api/animal
Add a new animal to the database.

## Update Animal Information
PUT /api/animal/{id}
Update information about a specific animal.

## Delete Animal
DELETE /api/animal/{id}
Delete a specific animal by its ID.




# Pagination
Pagination is applied to the list of animals. This enables clients to retrieve a specific subset of animals rather than the entire collection in a single request.

To retrieve a list of animals with pagination, you can make a GET request to the /api/animal endpoint. The following query parameters are available for pagination:
example: GET /api/animal?page=2&pageSize=10

The API response includes pagination information:
TotalCount of animals in database
TotalPages on specified page.
CurrentPage
PageSize(number of items per page)
Animals list for current page




## Known Bugs
- Please visit this projects [GitHub repository](https://github.com/Elena-Rosa/BenjiApi.git) to submit Issues and Pull Requests.

## License
MIT License

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

Copyright (c) Elena Rosa 2023 