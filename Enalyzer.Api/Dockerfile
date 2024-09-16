# Stage 1: Build the project
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
EXPOSE 8080
EXPOSE 8081
COPY ["Enalyzer.Api.csproj", "."]
RUN dotnet restore "./Enalyzer.Api.csproj"

COPY . .
RUN dotnet build "./Enalyzer.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "./Enalyzer.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Enalyzer.Api.dll"]
