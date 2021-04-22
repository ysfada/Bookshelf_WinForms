# README

# Start
Look at .env.example, docker-compose.yml and Properties/Settings.settings files

## Object Hungarian Notation Naming Conventions
https://github.com/jeffpar/kbarchive/tree/master/kb/173/Q173738

## SQL Server Name Convention and T-SQL Programming Style
https://github.com/ktaranov/sqlserver-kit/blob/master/SQL%20Server%20Name%20Convention%20and%20T-SQL%20Programming%20Style.md

## Assign null to a sqlparameter
https://stackoverflow.com/questions/4555935/assign-null-to-a-sqlparameter

## Data Visualization
https://github.com/dotnet/winforms-datavisualization
https://www.nuget.org/packages/System.Windows.Forms.DataVisualization/

## Docker
https://hub.docker.com/_/microsoft-mssql-server
docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=yourStrong(!)Password' -e 'MSSQL_PID=Express' -p 1433:1433 -d -v <YOUR_PATH>:/var/opt/mssql/data --name MsSqlServer mcr.microsoft.com/mssql/server:2017-latest-ubuntu 
docker exec -it <container_id|container_name> /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P <your_password>
