# Visual Studio Code - .NET C#
Estudo dos comandos via terminal para utilizar VsCode com .net C#

## Extensões
Instale as seguintes extensões:
* [C# Dev Kit](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit)
* [Visual Studio Keymap](https://marketplace.visualstudio.com/items?itemName=ms-vscode.vs-keybindings)

## Comandos via terminal

As opções dos comandos abaixo podem mudar de acordo com suas necessidades, verifique o `--help` do comando em caso de dúvidas.

## Criar solution
```csharp
dotnet new sln -n VsCodeSolution
```

## Listar tipos de projetos disponíveis
```csharp
dotnet new list
```

## Criar projeto
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

## Limpar cache de pacotes
```csharp
dotnet nuget locals all --clear
```

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
dotnet test -c Debug --no-build -v normal
```