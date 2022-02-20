# DESAFIO DE PROGRAMAÇÃO - ACADEMIA CAPGEMINI

> ## TECNOLOGIAS UTILIZADAS  
Os códigos foram escritos em `C#` com [.NET 5.0](https://dotnet.microsoft.com/en-us/download/dotnet/5.0) e o editor de código [Visual Studio Code](https://code.visualstudio.com/download) em sisteme operacional Linux.  

As extensões utilizadas para o editor de código foram: [C# for Visual Sudio Code](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp) | [C# Extensions](https://marketplace.visualstudio.com/items?itemName=jchannon.csharpextensions) | [dotnet](https://marketplace.visualstudio.com/items?itemName=leo-labs.dotnet) | [NuGet Package Manager](https://marketplace.visualstudio.com/items?itemName=jmrog.vscode-nuget-package-manager) | [Markdown All in One](https://marketplace.visualstudio.com/items?itemName=yzhang.markdown-all-in-one).

> ## COMO EXECUTAR O CÓDIGO  
  
Para executar o código é necessário [clonar esse repositório](https://docs.github.com/en/repositories/creating-and-managing-repositories/cloning-a-repository) em uma máquina local que ja tenha instalado o [Sdk e o Runtime do .NET 5.0](https://dotnet.microsoft.com/en-us/download/dotnet/5.0).  

Em um terminal, navegue até o diretório onde está o projeto e execute o seguinte comando:
 ```
 dotnet run
 ```  

Nesse repositório cada projeto fica em seu respectivo diretório: 
- Questao1
- Questao2
- Questao3

> ## TESTES

Para os testes, foram utilizados os pacotes: `Microsoft.NET.Test.Sdk` | `xunit` | `xunit.runner.visualstudio`. Para o download dos pacotes, execute o seguinte comando no terminal integrado do editor de código ou IDE, lembrando que o comando deve ser executado no diretório onde está cada projeto:
``` 
dotnet add package Microsoft.NET.Test.Sdk
dotnet add package xunit
dotnet add package xunit.runner.visualstudio
```  

Para executar os testes, em um terminal navegue até o diretório em que o projeto se encontra e execute o seguinte comando:
```
dotnet test
```
