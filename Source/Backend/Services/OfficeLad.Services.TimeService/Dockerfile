#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/runtime:3.1-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["OfficeLad.Services.TimeService/OfficeLad.Services.TimeService.csproj", "OfficeLad.Services.TimeService/"]
RUN dotnet restore "OfficeLad.Services.TimeService/OfficeLad.Services.TimeService.csproj"
COPY . .
WORKDIR "/src/OfficeLad.Services.TimeService"
RUN dotnet build "OfficeLad.Services.TimeService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OfficeLad.Services.TimeService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OfficeLad.Services.TimeService.dll"]