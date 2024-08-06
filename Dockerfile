FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /app

# copy csproj and restore as distinct layers
COPY ./src/com.dell.emulator.powerstore/com.dell.emulator.powerstore.csproj ./com.dell.emulator.powerstore.csproj
RUN dotnet restore

# copy everything else and build
COPY ./src/com.dell.emulator.powerstore/ ./
RUN dotnet publish -c Release -o out

# build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
RUN mkdir /data
VOLUME /data
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "com.dell.emulator.powerstore.dll"]
