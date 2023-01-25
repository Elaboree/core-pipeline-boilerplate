#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["core-pipeline-boilerplate/Services/Contact.API/Contact.API/Contact.API.csproj", "core-pipeline-boilerplate/Services/Contact.API/Contact.API/"]
COPY ["core-pipeline-boilerplate/Services/Contact.API/Contact.API.Infrastructure/Contact.API.Infrastructure.csproj", "core-pipeline-boilerplate/Services/Contact.API/Contact.API.Infrastructure/"]
COPY ["core-pipeline-boilerplate/Services/Contact.API/Contact.API.Models/Contact.API.Models.csproj", "core-pipeline-boilerplate/Services/Contact.API/Contact.API.Models/"]
COPY ["core-pipeline-boilerplate/Services/Contact.API/Contact.API.Service/Contact.API.Service.csproj", "core-pipeline-boilerplate/Services/Contact.API/Contact.API.Service/"]
RUN dotnet restore "core-pipeline-boilerplate/Services/Contact.API/Contact.API/Contact.API.csproj"
COPY . .
WORKDIR "/src/core-pipeline-boilerplate/Services/Contact.API/Contact.API"
RUN dotnet build "Contact.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Contact.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Contact.API.dll"]