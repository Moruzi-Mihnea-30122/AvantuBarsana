# AvantuBarsana
Logistics App

DataBase creation:
  1) Open SSMS
  2) Connect to server
  3) Databases -> new database (ex: LogisticDB)
  4) New Querry
  5) Run the attached querry
  6) Open Visual Studio
  7) Project -> Add new Item -> ADO.NET Entity Framework
  8) New connection -> Connect to the server (same as on step 2) -> Select the LogisticDB -> Test Connection -> Create -> (copy the connection string) 
     
Database sync:
  - On every push generate new .sql file:
       a) Databases/LogisticBD -> tasks -> generate script
       b) Upload that script
  - On every pull run the attached querry
