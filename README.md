# ASP.NET Core Web Application with Authentication and Authorization
Simple proof of concept app to demonstrate concepts of authorisation and authentication via an ASP.NET Core Web Application.

## Features
- User registration with fields like first/last name, email, phone number etc. validated and stored in SQL Server.
- Login and logout system using ASP.NET Core Identity.
- The "User" page is only accessible to logged-in users.
- The "Admin", "Client" and "Seller" pages are only accessible to users assigned those roles.
- Nav menu updates dynamically based on user login state and role.

## Technologies
- ASP.NET Core.
- Entity Framework Core.
- Razor Pages.
- SQL Server.

## Setup
- Update connection string in ```appsettings.json```.
- Run EF Core migrations to create SQL database with ```Update-Database```.
- Register a new user account.
- Assign roles to users in the database tables manually:
  - First identify the ```UserId``` and ```RoleId```.
  - Execute this SQL statement:
  ```sql
  INSERT INTO AspNetUserRoles (UserId, RoleId) VALUES ('<Enter UserId string>', '<Enter RoleId string>');
  ```
  - To update the existing user's role:
  ```sql
  UPDATE AspNetUserRoles
  SET RoleId = '<Enter new RoleId>'
  WHERE UserId = '<Enter UserId>' AND RoleId = '<Enter old RoleId>';
  ```

## Usage
- New users can register accounts.
- Registered users can log in.
- The ```/User``` page loads user details and requires authentication.
- The ```/Admin```, ```/Client```, ```/Seller``` pages authorise based on assigned roles.
- Nav menu changes based on authentication state and role.
