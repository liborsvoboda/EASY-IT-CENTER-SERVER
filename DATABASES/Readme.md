
# update tool   
dotnet tool update --global dotnet-ef --version 6.0.33   



https://github.com/zzzprojects/docs/blob/master/learnentityframeworkcore.com/pages/migrations/index.md

Command Line	Description
dotnet ef migrations add [name]	Create a new migration with the specific migration name.
dotnet ef migrations remove	Remove the latest migration.
dotnet ef database update	Update the database to the latest migration.
dotnet ef database update [name]	Update the database to a specific migration name point.
dotnet ef migrations list	Lists all available migrations.
dotnet ef migrations script	Generates a SQL script for all migrations.
dotnet ef migrations has-pending-model-changes	Check if there is any model changes since the last migration.
dotnet ef database drop	Drop the database.

dotnet ef migrations script