REM Execute with a Node.js command prompt.
REM Further infos at: https://openapi-generator.tech/
REM

openapi-generator generate -i openapi.json -g csharp-netcore --additional-properties packageName=OpenApiClient -o ./Client
