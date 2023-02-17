Repro of .NET7 Isolated function app using [Application Insights Dependency Tracking in Preview](https://learn.microsoft.com/en-us/azure/azure-functions/dotnet-isolated-in-process-differences#execution-mode-comparison-table).

Function1 does a simple post request to google and returns the response body.

Function2 makes a simple query to Azure SQL server. Followed the [Use Azure Functions to connect to an Azure SQL Database](https://learn.microsoft.com/en-us/azure/azure-functions/functions-scenario-database-table-cleanup) which has a pre-req of [Create a single database - Azure SQL Database)[https://learn.microsoft.com/en-us/azure/azure-sql/database/single-database-create-quickstart?view=azuresql&tabs=azure-portal] to create the sample database used in the function. 
