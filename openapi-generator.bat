:: run `npm i --location=global @openapitools/openapi-generator-cli` to install openapi-generator-cli
openapi-generator-cli generate -i https://petstore3.swagger.io/api/v3/openapi.json -g csharp -o sdk --skip-validate-spec --additional-properties useCollection=true,targetFramework=net6.0,library=httpclient,packageName=OpenApi.Pets.Sdk