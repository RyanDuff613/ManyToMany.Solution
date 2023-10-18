# Example Repo for Section #4 - Many-to_Many Relationships - ToDoList

#### By: Ryan Duff

## Description
A Todo List Application created with ASP.NET Core MVC. 

## Technologies Used
- C#
- ASP.NET Core MVC
- Razor Pages
- Entity Framework Core

## Setup/Installation Requirements
- Note: An installation of the .NET SDK is required in order to run this application locally. [See Here](https://dotnet.microsoft.com/en-us/) for installation.
1. Clone this repo.
2. Open your shell (e.g., Terminal or GitBash) and navigate to this project's directory called "ManyToMany.Solution". 
3. Navigate to the project directory: `$ cd ToDoList`
4. Create a file named `appsettings.json`: `$ touch appsettings.json`
5. Within `appsettings.json` add the following code, replacing the `uid` and `pwd` values with your own username and password for MySQL. Replace the `database` value with the name that you wish to give the database that will back up this application. Entity will create the database for you in a subsequent step. 

    ```json
    {
      "ConnectionStrings": {
          "DefaultConnection": "Server=localhost;Port=3306;database=[DATABASE-NAME];uid=[YOUR-USERNAME];pwd=[YOUR-MYSQL-PASSWORD];"
      }
    }
    ```
6. Run `$ dotnet ef database update`. This command will create the database and required tables on your local machine.
7. Run `$ dotnet watch run` in the command line to start the project in development mode with a watcher.
8. Open the browser at: _https://localhost:5001_. If you cannot access localhost:5001 it is likely because you have not configured a .NET developer security certificate for HTTPS. To learn about this, review this lesson: [Redirecting to HTTPS and Issuing a Security Certificate](https://www.learnhowtoprogram.com/c-and-net/basic-web-applications/redirecting-to-https-and-issuing-a-security-certificate).

## Known Bugs
- Please visit this projects [GitHub repository]() to submit Issues and Pull Requests.

## License
MIT License

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

Copyright (c) Ryan Duff 2023 