# Trading Web App Final Project
The Trading Web App Final Project focuses on the development of a web service using ASP.NET Core Web API, Entity Framework Core, and AutoMapper. The project includes a Person Management Service and a Product Management Service with controllers responsible for processing HTTP requests related to products and users.



## Technologies Used
- C#
- ASP.NET Core
- Entity Framework Core
- AutoMapper
- SQL Server Management Studio
- Visual Studio
- Swagger
- .NET SDK
## Prerequisites
Before running the project, ensure you have the following installed:

- [.NET SDK](https://dotnet.microsoft.com/download)
- [Visual Studio](https://visualstudio.microsoft.com/)
## Installation

1. Clone the repository.
2. Open the solution in Visual Studio.
3. Configure the database connection in `appsettings.json`.
4. Run the application.

```bash
dotnet run
    
## Usage/Examples

The web service provides CRUD operations for managing customers and products. Explore the API endpoints for details on how to interact with the service.


## API Endpoints
### 1. Get Customers

- **Endpoint:** `/api/customers`
- **Method:** GET
- **Parameters:** None
- **Response:**
  - Sample Response:
    ```json
    {
      "customers": [...]
    }
    ```

### 2. Create Customer

- **Endpoint:** `/api/customers`
- **Method:** POST
- **Parameters:**
  - `firstName` (string, required): The first name of the customer.
  - `lastName` (string, required): The last name of the customer.
  - `gender` (enum, optional): The gender of the customer.
  - `personalNumber` (string, required): The personal identification number of the customer.
  - `birthDate` (date, required): The birth date of the customer.
  - `city` (object, optional): The city object containing details about the customer's city.
  - `country` (object, optional): The country object containing details about the customer's country.
  - `fullAddress` (string, optional): The full address of the customer.
  - `email` (string, required): The email address of the customer.
  - ...

- **Request Example:**
  ```json
  {
    "firstName": "John",
    "lastName": "Doe",
    "gender": "Male",
    "personalNumber": "123456789",
    "birthDate": "1990-01-01",
    "city": {
      "name": "CityName"
    },
    "country": {
      "countryCode": "US",
      "countryName": "United States"
    },
    "fullAddress": "123 Main St, CityName, US",
    "email": "john.doe@example.com",
    ...
  }
## Authors

- https://github.com/Magdana


## Feedback

If you have any feedback, please reach out to us at magdagvirjishvili@gmail.com
or +599 591 44 88 47

# TradingWebAppFinalProject
