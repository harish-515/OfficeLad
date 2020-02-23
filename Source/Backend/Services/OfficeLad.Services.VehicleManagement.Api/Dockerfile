#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["OfficeLad.Services.VehicleManagement.Api/OfficeLad.Services.VehicleManagement.Api.csproj", "OfficeLad.Services.VehicleManagement.Api/"]
RUN dotnet restore "OfficeLad.Services.VehicleManagement.Api/OfficeLad.Services.VehicleManagement.Api.csproj"
COPY . .
WORKDIR "/src/OfficeLad.Services.VehicleManagement.Api"
RUN dotnet build "OfficeLad.Services.VehicleManagement.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OfficeLad.Services.VehicleManagement.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OfficeLad.Services.VehicleManagement.Api.dll"]