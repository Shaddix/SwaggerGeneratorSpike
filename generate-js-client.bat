java -jar swagger-codegen-cli.jar generate -l javascript --additional-properties usePromises=true -i http://localhost:65441/swagger/v1/swagger.json -o JsClient

cd JsClient
call npm install

rem //if npm link fails with "Invalid version 'v1'" - change API version in Startup.cs to something like v1.1.1 (it should be semantic version)
call npm link

cd ..

call npm link JsClient

call npm install browserify

call browserify main.js > wwwroot/bundle.js