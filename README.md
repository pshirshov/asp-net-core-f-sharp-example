# Notes

* Modified to accept command line and environment variables to be deployable to PCF
* When pushing to PCF, you'll have to use more disk than 1GB. In my tests, this sample consumes close enough to 1GB that there isn't enough space to push the droplet and run it.

Minimal demo of ASP.NET Core F# app

Just perform these commands:

    dotnet restore
    dotnet run
