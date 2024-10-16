# Visual Studio Code - .NET C#
Estudo dos comandos via terminal para utilizar VsCode com .net C#

## Extensões
Instale as seguintes extensões:
* [C# Dev Kit](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit)
* [Visual Studio Keymap](https://marketplace.visualstudio.com/items?itemName=ms-vscode.vs-keybindings)
* [.NET Core Test Explorer](https://marketplace.visualstudio.com/items?itemName=formulahendry.dotnet-test-explorer)
* [Code Coverage](https://marketplace.visualstudio.com/items?itemName=markis.code-coverage)

## Comandos via terminal

As opções dos comandos abaixo podem mudar de acordo com suas necessidades, verifique o `--help` do comando em caso de dúvidas.

## Listar versão mais atual do SDK instalado
```csharp
dotnet --version
dotnet --info
```

## Listar todas as versões do SDK instalado
```csharp
dotnet --list-sdks
dotnet sdk check
```

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

## Listar todos os pacotes instalados nos projetos
```csharp
dotnet list package
dotnet list package --include-transitive
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
```

## Listar todos os pacotes instalados nos projetos que possuem vulnerabilidades
```csharp
dotnet list package --vulnerable
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