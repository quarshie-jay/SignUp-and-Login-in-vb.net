# Login and Signup Project

This project is a simple login and signup system implemented in VB.NET with a SQL database. It provides basic user registration and authentication functionalities.

## Table of Contents

- [Introduction](#introduction)
- [Features](#features)
- [Technologies Used](#technologies-used)
- [Database Schema](#database-schema)
- [Installation](#installation)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)
- [Contact](#contact)

## Introduction

This project aims to provide a straightforward example of how to implement a login and signup system using VB.NET and SQL Server. It includes user registration, login, and basic user management functionalities.

## Features

- User Registration
- User Login
- User Role Management
- Account Status Management
- Profile Picture Upload

## Technologies Used

- **Programming Language:** VB.NET
- **Database:** SQL Server

## Database Schema

The project uses a SQL Server database named `loginreg`. The main table used is `login` with the following columns:

- `firstname` (VARCHAR)
- `lastname` (VARCHAR)
- `username` (VARCHAR) - Unique
- `password` (VARCHAR)
- `dob` (DATE)
- `role` (VARCHAR)
- `status` (VARCHAR)
- `pic` (VARCHAR) - Path to the profile picture


## Installation

1. **Clone the Repository:**
    ```bash
    git clone https://github.com/quarshie-jay/SignUp-and-Login-in-vb.net
    ```
   
2. **Set Up the Database:**
    - Create a new database named `loginreg`.
    - Run the SQL script provided in the repository to create the `login` table.
    
    ```sql
    CREATE TABLE login (
        firstname VARCHAR(50),
        lastname VARCHAR(50),
        username VARCHAR(50) UNIQUE,
        password VARCHAR(50),
        dob DATE,
        role VARCHAR(50),
        status VARCHAR(50),
        pic VARCHAR(255)
    );
    ```

3. **Configure the Project:**
    - Open the project in Visual Studio.
    - Update the database connection string in the configuration file to match your SQL Server setup.

4. **Build and Run:**
    - Build the solution in Visual Studio.
    - Run the application.

## Usage

- **Register:** Fill in the registration form to create a new user.
- **Login:** Use the username and password to log in.
- **Manage Users:** Depending on the role and status, manage user profiles and roles.

## Contributing

Contributions are welcome! Please fork the repository and submit a pull request for any changes or enhancements.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Contact

For any questions or suggestions, feel free to reach out to:

- **Email:** jamquar@gmail.com
- **GitHub:** (https://github.com/quarshie-jay) 
