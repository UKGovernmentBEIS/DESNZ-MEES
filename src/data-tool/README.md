# DESNZ-MEES Alpha - Data Tool

## Warning
This is experimental code and not intended for commercial use.

## How it Works
This is a basic asp.net core web app with a couple of quirks:
- the db is defined and loaded by the scripts in the [data-analysis](../data-analysis/) folder. Use the `dotnet ef dbcontext scaffold` command to update the DbContext and related entities.
- all the data is read-only
- the app can be run locally as a pair of docker containers, one for the web app and one for the postgres db.
- GitHub Actions are used to ensure the app builds before a PR is merged and also deploys the app to an Azure App Service when `main` is updated. The Azure uses the docker image to create a containerised App Service. Bear this in mind if you start changing ports. Also Azure expects to be able to ping port 80 on the container as a health check.
- there are currently no tests

## Installation
### Pre-requisites
- a clone of this repo
- an IDE 
- docker desktop or equivalent
- a postresql DB already loaded with the relevant data
- .NET User Secrets for the Web.csproj
- a [dev ssl certificate](https://github.com/dotnet/dotnet-docker/blob/main/samples/run-aspnetcore-https-development.md) for running via https locally, keep the password in the user secrets config below.
### Config
- The user secrets file for running the Web app locally should be updated to contain the following items:
```json
    {
      "DataConfiguration:DbConnectionString": "Server=db;Port=5432;Database=data_tool;User Id=postgres;Password=YOUR_DB_PASSWORD;",
      "Kestrel:Certificates:Development:Password": "YOUR_CERT_PASSWORD",
      "WebConfiguration:Username": "YOUR_WEB_USER",
      "WebConfiguration:Password": "YOUR_WEB_PASSWORD"
    }
```
- The config for the Azure App Service has already been defined and does not need to be modified.
## Local Running
- use `docker compose -f compose.yaml -p data-tool build` and then `docker compose -f compose.yaml -p data-tool up -d` to ensure any code changes are captured in the docker image used by the `compose.yaml` file. Change the Server name of the postgres connection string accordingly to match the server name defined there.
## External Dependencies
- the DB is created by the scripts in the [data-analysis](../data-analysis/) folder. Modify the Database in the postgres connection string accordingly.
- it uses GitHub Actions to deploy the docker image to an Azure Container Registry
- Azure is used as the host.
## Technologies
- .Net 8
- EF Core
- Docker
- GOV.UK Design System
## Known Issues
- why basic auth??????: single user, no further ui work, 'ok' if forced through https. defo only for POC, NOT FOR PROD CODE!
- no tests, tho it has been written using .net core IOC for testing at a future date
- the LA parameter to the SQL query should really be chooseable by the user
- GDS css and js is hard coded