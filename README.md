# Tacta Shopping Task

This project combines Angular 15.2.10 for the frontend, .NET 6 Web API for the backend, and MSSQL Server for database storage. It provides a robust foundation for building modern web applications with a responsive user interface, a scalable server-side architecture, and a reliable database backend.

## Getting Started

To run this project locally, ensure you have the following software installed on your machine:

### Prerequisites

1. [Node.js](https://nodejs.org/en/) (v15.2.10 or later)
2. [Angular CLI](https://cli.angular.io/) (v15.2.10 or later)
3. [.NET SDK](https://dotnet.microsoft.com/download/dotnet/6.0) (v6.0 or later)
4. [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/) (optional, for backend development)
5. [MSSQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (v2017 or later)

### Clone the Repository

```bash
git clone https://github.com/SandiStokanovicc/ShoppingTask.git
cd ShoppingTask
```

### Frontend Setup

```bash
cd TactaShoppingTaskFront
npm install
ng serve
```

The Angular application will be accessible at `http://localhost:4200/` by default.

### Backend Setup

```bash
cd TactaShoppingTask
dotnet restore
dotnet run
```

The .NET Web API will be hosted at `http://localhost:7229/` by default.

### MSSQL Server Setup

- Ensure MSSQL Server is installed and running.
- Update the database connection string in the `TactaShoppingTask/Properties/appsettings.json` file to match your MSSQL Server setup.

## Project Structure

- **frontend**: Contains the Angular application.
- **backend**: Contains the .NET 6 Web API.
- **database**: Placeholder for database scripts or migrations.


## License

This project is licensed under the [MIT License](LICENSE).
