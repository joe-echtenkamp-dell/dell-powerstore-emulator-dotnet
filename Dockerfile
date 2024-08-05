FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /App

# Copy everything
COPY . ./
# Restore as distinct layers
RUN dotnet restore src/Com.Dell.Emulator.Powerstore/Com.Dell.Emulator.Powerstore.csproj 
# Build and publish a release
RUN dotnet publish -c Release -o out src/Com.Dell.Emulator.Powerstore/Com.Dell.Emulator.Powerstore.csproj

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /App
COPY --from=build-env /App/out .
ENV ASPNETCORE_ENVIRONMENT=Production
ENV ASPNETCORE_URLS=http://+:8080
ENTRYPOINT ["dotnet", "Com.Dell.Emulator.Powerstore.dll"]
