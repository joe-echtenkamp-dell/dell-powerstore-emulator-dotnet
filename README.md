# Com.Dell.Emulator.Powerstore - ASP.NET Core 3.0 Server

Storage cluster REST API definition. ( For \"Try It Out\", use the cluster management IP address to load this swaggerui interface. )

## Run

Linux/OS X:

```
sh build.sh
```

Windows:

```
build.bat
```

## Run in Docker

```
cd src/Com.Dell.Emulator.Powerstore
docker build -t Com.Dell.Emulator.Powerstore .
docker run -p 5000:5000 Com.Dell.Emulator.Powerstore
```
