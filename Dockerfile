# ===== BUILD STAGE =====
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy server & client project files
COPY Crisnamart.BlazorHibrido/Crisnamart.BlazorHibrido/*.csproj Crisnamart.BlazorHibrido/
COPY Crisnamart.BlazorHibrido/Crisnamart.BlazorHibrido.Client/*.csproj Crisnamart.BlazorHibrido.Client/
COPY Crisnamart.Domain/ Crisnamart.Domain/

# Restore server project
RUN dotnet restore Crisnamart.BlazorHibrido/Crisnamart.BlazorHibrido.csproj

# Copy the rest of the source code
COPY . .

# Publish server project only
RUN dotnet publish Crisnamart.BlazorHibrido/Crisnamart.BlazorHibrido.csproj -c Release -o /app/publish /p:UseAppHost=false

# ===== RUNTIME STAGE =====
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .
EXPOSE 8080
ENV ASPNETCORE_URLS=http://+:8080
ENTRYPOINT ["dotnet", "Crisnamart.BlazorHibrido.dll"]
