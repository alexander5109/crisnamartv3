# ===== BUILD STAGE =====
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy all .csproj files and restore
COPY Crisnamart.BlazorHibrido/Crisnamart.BlazorHibrido/*.csproj Crisnamart.BlazorHibrido/
COPY Crisnamart.BlazorHibrido/Crisnamart.BlazorHibrido.Client/*.csproj Crisnamart.BlazorHibrido.Client/
COPY Crisnamart.Domain/*.csproj Crisnamart.Domain/
RUN dotnet restore Crisnamart.BlazorHibrido/Crisnamart.BlazorHibrido.csproj

# Copy everything else and build
COPY . .
RUN dotnet publish Crisnamart.BlazorHibrido/Crisnamart.BlazorHibrido.csproj -c Release -o /app/publish

# ===== RUNTIME STAGE =====
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .
EXPOSE 8080
ENV ASPNETCORE_URLS=http://+:8080
ENTRYPOINT ["dotnet", "Crisnamart.BlazorHibrido.dll"]
