#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Boilerplate.Functions.Cleaner/Boilerplate.Functions.Cleaner.csproj", "Boilerplate.Functions.Cleaner/"]
RUN dotnet restore "Boilerplate.Functions.Cleaner/Boilerplate.Functions.Cleaner.csproj"
COPY . .
WORKDIR "/src/Boilerplate.Functions.Cleaner"
RUN dotnet build "Boilerplate.Functions.Cleaner.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Boilerplate.Functions.Cleaner.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Boilerplate.Functions.Cleaner.dll"]