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
O comando `/p:CollectCoverage=true /p:CoverletOutput=./coverage/lcov.info /p:CoverletOutputFormat=lcov` é utilizado para que a extensão `Code Coverage` possa analisar a cobertura de código.
```csharp
dotnet test -c Debug --no-build -v normal /p:CollectCoverage=true /p:CoverletOutput=./coverage/lcov.info /p:CoverletOutputFormat=lcov
```

## Executar testes específicos
```csharp
dotnet test --filter Somar_SomaDeNumerosPos
```