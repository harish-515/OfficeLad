#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["OL.Svcs.VehicleMgmt.Api/OL.Svcs.VehicleMgmt.Api.csproj", "OL.Svcs.VehicleMgmt.Api/"]
COPY ["OL.Svcs.VehicleMgmt.Infrastructure/OL.Svcs.VehicleMgmt.Infrastructure.csproj", "OL.Svcs.VehicleMgmt.Infrastructure/"]
COPY ["OL.Svcs.VehicleMgmt.Application/OL.Svcs.VehicleMgmt.Application.csproj", "OL.Svcs.VehicleMgmt.Application/"]
COPY ["OL.Svcs.VehicleMgmt.Domain/OL.Svcs.VehicleMgmt.Domain.csproj", "OL.Svcs.VehicleMgmt.Domain/"]
COPY ["OL.Svcs.VehicleMgmt.Persistence/OL.Svcs.VehicleMgmt.Persistence.csproj", "OL.Svcs.VehicleMgmt.Persistence/"]
RUN dotnet restore "OL.Svcs.VehicleMgmt.Api/OL.Svcs.VehicleMgmt.Api.csproj"
COPY . .
WORKDIR "/src/OL.Svcs.VehicleMgmt.Api"
RUN dotnet build "OL.Svcs.VehicleMgmt.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OL.Svcs.VehicleMgmt.Api.csproj" -c Release -o /app/publish

ENV ASPNETCORE_ENVIRONMENT="ContainerDevelopment"

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OL.Svcs.VehicleMgmt.Api.dll"]