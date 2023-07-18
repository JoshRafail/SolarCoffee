# SolarCoffee

Requirements:
dotNet 7.0
VS Community 2022

What I did to get it running:

use Dotnetcore 6.0. Make sure to specify dotnet version for SolarCoffee.Web (by defaut this is not specified)
add Microsoft.AspNetCore.Mvc.NewtonsoftJson at version 6
In startup code (Program.cs) update line to be the following: services.AddControllers().AddNewtonsoftJson();

Commands:
dotnet new sln
dotnet new webapi -o SolarCoffee.Web
dotnet new classlib -f net7.0 -o SolarCoffee.Data
dotnet new classlib -f net7.0 -o SolarCoffee.Services
dotnet new xunit -f net7.0 -o SolarCoffee.Test

dotnet sln add SolarCoffee.Data
dotnet sln add SolarCoffee.Services
dotnet sln add SolarCoffee.Test
dotnet sln add SolarCoffee.Web

cd SolarCoffee.Web
dotnet run

Packages:
Microsoft.AspNetCore.Identity.EntityFrameworkCore on Data
Microsoft.EntityFrameworkCore on Data
Npgsql.EntityFrameworkCore.PostgreSQL on Data

## postgres
When using commands make sure to execute as user "postgres" eg:
`psql -U postgres`
`CREATE USER solardev WITH PASSWORD 'solar123';`
`CREATE DATABASE solardev;`
`GRANT ALL PRIVILEGES ON DATABASE solardev TO solardev;`
`\c solardev solardev`
password: solar123


How to view users:
`psql -U postgres -c "\du"`

Now create database
`createuser -U postgres -l -d -P "solardev"`


### Add Packages to Web:
Microsoft.EntityFrameworkCore
Microsoft.AspNetCore.Mvc.NewtonsoftJson
Microsoft.EntityFrameworkCore.Design
Microsoft.EntityFrameworkCore.Tools
Microsoft.EntityFrameworkCore.Tools

dotnet tool install --global dotnet-ef
dotnet ef --startup-project ../SolarCoffee.Web/ migrations add InitialMigration


## Prompts:
Following this tutorial https://www.udemy.com/course/learn-full-stack-vue-net-core-postgres

This tutorial is nearly 3 years old so there are much newer dotnet versions now. I am having issues getting the necessary packages such as entity framework being compatible with the dotnet 7.0. Do you have advice on how to make a dotnet, entity framework, postgres, vue based web app with the newest and compatible versions?
