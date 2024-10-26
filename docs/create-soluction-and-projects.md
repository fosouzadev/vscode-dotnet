## Criar solution
```csharp
dotnet new sln -n VsCodeSolution
```

## Listar os templates de projeto disponíveis
```csharp
dotnet new list
```

## Criar projetos
Web Api
```csharp
dotnet new webapi -n WebApiProject -o ./src/WebApiProject -f net8.0 --use-controllers
```
Biblioteca
```csharp
dotnet new classlib -n LibraryProject -o ./src/LibraryProject -f net8.0
```
Testes
```csharp
dotnet new xunit -n TestProject -o ./tests/TestProject -f net8.0
```

## Adicionar projetos a solution
```csharp
dotnet sln add ./src/WebApiProject/ -s src
dotnet sln add ./src/LibraryProject/ -s src
dotnet sln add ./tests/TestProject/ -s tests
```

## Adicionar referência entre projetos
```csharp
dotnet add ./src/WebApiProject/WebApiProject.csproj reference ./src/LibraryProject/LibraryProject.csproj
dotnet add ./tests/TestProject/TestProject.csproj reference ./src/WebApiProject/WebApiProject.csproj
```