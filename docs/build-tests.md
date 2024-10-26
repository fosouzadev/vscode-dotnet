## Limpar solution
```csharp
dotnet clean -c Debug
```

## Restaurar pacotes
```csharp
dotnet restore
```

## Build
```csharp
dotnet build -c Debug --no-restore
```

## Listar testes
```csharp
dotnet test -t
```

## Executar testes
```csharp
dotnet test -c Debug --no-build -v normal /p:CollectCoverage=true /p:CoverletOutput=./coverage/lcov.info /p:CoverletOutputFormat=lcov
```