FROM mcr.microsoft.com/dotnet/core/sdk:3.0 AS build-env
WORKDIR /app

ENV DOTNET_CLI_TELEMETRY_OPTOUT=1

# copy csproj and restore as distinct layers
COPY ./src/com.dell.emulator.powerstore/com.dell.emulator.powerstore.csproj ./com.dell.emulator.powerstore.csproj
RUN dotnet restore

# copy everything else and build
COPY ./src/com.dell.emulator.powerstore/ ./
RUN dotnet publish -c Release -o out

# build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.0
RUN mkdir /data
VOLUME /data
WORKDIR /app
COPY --from=build-env /app/out .
RUN dotnet tool install --global dotnet-ef
ENTRYPOINT ["sh", "entrypoint.sh"]
