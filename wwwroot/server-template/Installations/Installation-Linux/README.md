
### Installation Info
In Installation folder is folder "Data" in Project Installation   
In this Folder is Startup Database and config.txt Configuration file    
If your User in connection string has Enabled Create Database - DB will be created automatically
Next Copy the License 'license.lic' file to "Data" folder   

First Login user/password:   You must do Registration new User

Default Database: MSSQL

Database Can convert to Any other Database Engine 
[MsSQL,Oracle,DB2,PosGreSql,MySql,SqLite]   

DB is used With Entity Framework 6 - Centralized Solution for DBs.  

Server need for Start Valid DB connection string in file 
> Data/config.json 

```   
{  
  "DatabaseConnectionString": "Server=127.0.0.1;Database=EasyITCenter;Trusted_Connection=True;TrustServerCertificate=True"   
}   
```     


> Installation Steps   

```cs
1a] Generate correct Connection String with allow Create Database 
1b] Install MSSQL DB to Server Manually from Data folder 
2] Write this connection string to "config.txt"   
3] Insert downloaded License File to Data folder

Info] for read Startup info you can run exe / dll from command line 
```

--- 
### Windows Installation Steps
Run Installation Exe file   
Check "config.txt" Project file for correct connection string with allowed Create Database  
Copy the License 'license.lic' file to "Data" folder   
Is was installed as Windows Service - you can enable/disable over services   
Run the server and Done   

```cs
```

--- 
### Linux Installation Steps
Install ASPNETCORE6 Runtime + Hosting support on your Linux Server   
Copy unpacked Project to some folder on Linux server   
Configure and enable new Linux service [dotnet-EICServer.service](./dotnet-EICServer.service)      
Check "config.json" Project file in "Data" folder for correct connection string with allowed Create Database  
Copy the License 'license.lic' file to "Data" folder   
Run the server and Done    


```cs

Copy new service file dotnet-EICServer.service to '/lib/systemd/system' Linux server folder   

enable service by command: systemctl enable dotnet-EICServer.service
run service by command: systemctl start dotnet-EICServer.service

stop service by command: systemctl stop dotnet-EICServer.service
status service by command: systemctl status dotnet-EICServer.service
```


--- 

