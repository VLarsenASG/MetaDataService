#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["MetaDataService/MetaDataService.web.csproj", "MetaDataService/"]
COPY ["Application/Application.csproj", "Application/"]
COPY ["Domain/Domain.csproj", "Domain/"]
RUN dotnet restore "MetaDataService/MetaDataService.web.csproj"
COPY . .
WORKDIR "/src/MetaDataService"
RUN dotnet build "MetaDataService.web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MetaDataService.web.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MetaDataService.web.dll"]