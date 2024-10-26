## Listar todos os pacotes instalados nos projetos
```csharp
dotnet list package
dotnet list package --include-transitive
```

## Listar todos os pacotes instalados nos projetos que podem ser atualizados
```csharp
dotnet list package --outdated
dotnet list package --outdated --include-prerelease
```

## Listar todos os pacotes instalados nos projetos que estão obsoletos
```csharp
dotnet list package --deprecated
dotnet list package --deprecated --include-transitive
```

## Listar todos os pacotes instalados nos projetos que possuem vulnerabilidades
```csharp
dotnet list package --vulnerable
dotnet list package --vulnerable --include-transitive
```

## Procurar um pacote para ser instalado
O comando dotnet não possui recursos para listar todas as versões de um pacote específico, sendo necessário utilizar o CLI do nuget.exe
```csharp
dotnet package search moq
```

## Adicionar pacote ao projeto
```csharp
dotnet add ./tests/TestProject/TestProject.csproj package coverlet.msbuild -v 6.0.2
dotnet add ./tests/TestProject/TestProject.csproj package xunit.runner.visualstudio -v 3.0.0-pre.35
```

## Limpar cache de pacotes
```csharp
dotnet nuget locals all --clear
```