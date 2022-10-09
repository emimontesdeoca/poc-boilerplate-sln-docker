#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Boilerplate.Functions.Migrations/Boilerplate.Functions.Migrations.csproj", "Boilerplate.Functions.Migrations/"]
COPY ["Boilerplate.Libraries.Data/Boilerplate.Libraries.Data.csproj", "Boilerplate.Libraries.Data/"]
RUN dotnet restore "Boilerplate.Functions.Migrations/Boilerplate.Functions.Migrations.csproj"
COPY . .
WORKDIR "/src/Boilerplate.Functions.Migrations"
RUN dotnet build "Boilerplate.Functions.Migrations.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Boilerplate.Functions.Migrations.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Boilerplate.Functions.Migrations.dll"]