# OpenApiServer - ASP.NET Core 2.0 Server

Optional multiline or single-line description in [CommonMark](http://commonmark.org/help/) or HTML.

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
cd src/OpenApiServer
docker build -t openapiserver .
docker run -p 5000:8080 openapiserver
```
