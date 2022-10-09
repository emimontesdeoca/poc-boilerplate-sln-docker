#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Boilerplate.Applications.TodoBlazor/Boilerplate.Applications.TodoBlazor.csproj", "Boilerplate.Applications.TodoBlazor/"]
COPY ["Boilerplate.Libraries.Data/Boilerplate.Libraries.Data.csproj", "Boilerplate.Libraries.Data/"]
COPY ["Boilerplate.Libraries.Repositories/Boilerplate.Libraries.Repositories.csproj", "Boilerplate.Libraries.Repositories/"]
COPY ["Boilerplate.Libraries.Services/Boilerplate.Libraries.Services.csproj", "Boilerplate.Libraries.Services/"]
RUN dotnet restore "Boilerplate.Applications.TodoBlazor/Boilerplate.Applications.TodoBlazor.csproj"
COPY . .
WORKDIR "/src/Boilerplate.Applications.TodoBlazor"
RUN dotnet build "Boilerplate.Applications.TodoBlazor.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Boilerplate.Applications.TodoBlazor.csproj" -c Release -o /app/publish /p:UseAppHost=false



FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Boilerplate.Applications.TodoBlazor.dll"]