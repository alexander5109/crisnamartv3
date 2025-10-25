CREATE DATABASE crisnamart3;

CREATE TABLE Productos (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    CodigoUnico VARCHAR(50) NOT NULL,
    Ruta VARCHAR(255) NOT NULL,
    Descripcion TEXT NOT NULL
);
INSERT INTO Productos (CodigoUnico, Ruta, Descripcion) VALUES
('10022300305', 'IMAGENES JAZZ/TRAMONTINA/DYNAMIC/10022300305.jpg', 'TRAMONTINA DYNAMIC Cuchillo Asado 5/ Bx3'),
('184365', 'IMAGENES JAZZ/ARGOS/184365.jpg', 'BELGIOCO LUNCHERA CON BOTELLA');



dotnet new sln -n Crisnamart

dotnet new classlib -n Crisnamart.DB
dotnet sln add Crisnamart.DB/Crisnamart.DB.csproj

dotnet new webapi -n Crisnamart.Api
dotnet sln add Crisnamart.Api/Crisnamart.Api.csproj

dotnet new blazorserver -n Crisnamart.BlazorClient
dotnet sln add Crisnamart.BlazorClient/Crisnamart.BlazorClient.csproj

dotnet new console -n Crisnamart.DB.Runner
dotnet sln add Crisnamart.DB.Runner/Crisnamart.DB.Runner.csproj

dotnet add Crisnamart.Api/Crisnamart.Api.csproj reference Crisnamart.DB/Crisnamart.DB.csproj
dotnet add Crisnamart.DB.Runner/Crisnamart.DB.Runner.csproj reference Crisnamart.DB/Crisnamart.DB.csproj

dotnet add Crisnamart.DB package Dapper
dotnet add Crisnamart.DB package MySqlConnector

dotnet add Crisnamart.Api package Dapper
dotnet add Crisnamart.Api package MySqlConnector
dotnet add Crisnamart.Api package Swashbuckle.AspNetCore

dotnet add Crisnamart.BlazorClient package Microsoft.AspNetCore.Components.Web
dotnet add Crisnamart.BlazorClient package Microsoft.AspNetCore.Components.WebAssembly

{
    "Logging": {
        "LogLevel": {
            "Default": "Information",
            "Microsoft.AspNetCore": "Warning"
        }
    },
    "AllowedHosts": "*",
    "ConnectionStrings": {
        "MySql": "Server=[PORT/LOCALHOST];Database=[DATABASE];User=[USER];Password=[PASS];SslMode=None;"
    }
}
