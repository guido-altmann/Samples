REM Execute with a Node.js command prompt.
REM Further infos at: https://openapi-generator.tech/
REM

openapi-generator generate -i openapi.json -g aspnetcore --additional-properties packageName=OpenApiServer,aspnetCoreVersion=2.1 -o ./Server
