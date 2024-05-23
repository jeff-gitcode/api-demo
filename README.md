# Add Aspire to Existing Project


```dotnetcli

# create a weather api

$ dotnet new sln -o api-demo
$ cd api-demo
$ dotnet new webapi -minimal -o Api-Demo

$ dotnet sln add (ls -r **//*.csproj)

$ dotnet build
$ dotnet run --project .\Api-Demo\


# add aspire support to weather api

$ dotnet workload list
$ dotnet workload update
$ dotnet workload install aspire

# In Visual Studio, in the Solution Explorer, right-click the Store project, select Add, and then select .NET Aspire Orchestrator Support.
# In the Add .NET Aspire Orchestrator Support dialog, select OK.


```