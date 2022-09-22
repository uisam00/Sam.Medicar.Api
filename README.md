# Cria Migrations
Instale a ferramenta ```dotnet tool install --global dotnet-ef``` .
<br>
Na pasta ```src/Sam.Medicar.Data``` rode
```dotnet ef migrations add Initial -s ..\Sam.Medicar.Api\```

# Executar Migrations
Na pasta ```src/Sam.Medicar.Data``` rode ```dotnet ef database update -s ..\Sam.Medicar.Api\```
