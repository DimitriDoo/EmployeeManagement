#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["EmployeeManagement/EmployeeManagement.csproj", "EmployeeManagement/"]
COPY ["EmployeeManagement.Business/EmployeeManagement.Business.csproj", "EmployeeManagement.Business/"]
COPY ["EmployeeManagement.Data/EmployeeManagement.Data.csproj", "EmployeeManagement.Data/"]
COPY ["EmployeeManagement.DTO/EmployeeManagement.DTO.csproj", "EmployeeManagement.DTO/"]
COPY ["EmployeeManagement.Mapping/EmployeeManagement.Mapping.csproj", "EmployeeManagement.Mapping/"]
RUN dotnet restore "./EmployeeManagement/EmployeeManagement.csproj"
COPY . .
WORKDIR "/src/EmployeeManagement"
RUN dotnet build "./EmployeeManagement.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./EmployeeManagement.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EmployeeManagement.dll"]