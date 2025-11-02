# ===== BUILD STAGE =====
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy everything — preserves folder structure
COPY . .

# Restore and publish server project only
RUN dotnet restore Crisnamart.BlazorHibrido/Crisnamart.BlazorHibrido/Crisnamart.BlazorHibrido.csproj
RUN dotnet publish Crisnamart.BlazorHibrido/Crisnamart.BlazorHibrido/Crisnamart.BlazorHibrido.csproj -c Release -o /app/publish /p:UseAppHost=false

# ===== RUNTIME STAGE =====
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .
EXPOSE 8080
ENV ASPNETCORE_URLS=http://+:8080
ENTRYPOINT ["dotnet", "Crisnamart.BlazorHibrido.dll"]
