1. Install docker
2. open cmd in residing folder of docker-compose 
3. run command: docker-compose up -d
4. Open SSMS with server name: 127.0.0.1, username: sa, password: pa55w0rd!
5. To connect to the db you need to add the UserId and the Password in your configuration secret manager.
6. Use the next two commands in your package manager console.
user-secrets set "UserId" "sa" --project MinimalApiLearning
dotnet user-secrets set "Password" "pa55w0rd!" --project MinimalApiLearning