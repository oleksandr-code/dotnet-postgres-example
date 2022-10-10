# example-net-core-postgresql
Example .NET Core 3.1 project with xUnit and connection to PostgreSQL database.

## Requirements:
- PostgreSQL database
- .NET Core 3.0 SDK

## Start example database
**Use this _only_ if you don't have existing PostgreSQL database.**
1. Change directory to the docker directory
    - Command:\
        `cd docker`
2. Run docker-compose
    - Command:\
        `docker-compose up`

## EntityFramework database scaffold
1. Change directory to the project folder
    - Command:\
        `cd src/ExampleSolution.Db`
2. Scaffold the database
    - Command:\
        `dotnet ef dbcontext scaffold "Host=my_host;Database=my_db;Username=my_user;Password=my_pw" Npgsql.EntityFrameworkCore.PostgreSQL -c MyDbContext -o Models --context-dir .`

Additional info:
- [Other scaffold command options](https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/dotnet#common-options)
