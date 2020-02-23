#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["OfficeLad.Services.CubicleSpaceManagement.Api/OfficeLad.Services.CubicleSpaceManagement.Api.csproj", "OfficeLad.Services.CubicleSpaceManagement.Api/"]
RUN dotnet restore "OfficeLad.Services.CubicleSpaceManagement.Api/OfficeLad.Services.CubicleSpaceManagement.Api.csproj"
COPY . .
WORKDIR "/src/OfficeLad.Services.CubicleSpaceManagement.Api"
RUN dotnet build "OfficeLad.Services.CubicleSpaceManagement.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OfficeLad.Services.CubicleSpaceManagement.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OfficeLad.Services.CubicleSpaceManagement.Api.dll"]