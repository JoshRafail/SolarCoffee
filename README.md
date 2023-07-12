# SolarCoffee


What I did to get it running:

use Dotnetcore 6.0. Make sure to specify dotnet version for SolarCoffee.Web (by defaut this is not specified)
add Microsoft.AspNetCore.Mvc.NewtonsoftJson at version 6
In startup code (Program.cs) update line to be the following: services.AddControllers().AddNewtonsoftJson();


## postgres
When using commands make sure to execute as user "postgres" eg:
`psql postgres`

How to view users:
`psql -U postgres -c "\du"`

Now create database
`createuser -U postgres -l -d -P "solardev"`
