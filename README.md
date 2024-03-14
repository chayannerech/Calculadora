 ## Calculadora TopShow
 Uma calculadora de console simples, poderosa, que permite realizar as quatro operações matemáticas.

 ### Funcionalidades
 - **Operações básicas:** Realize somas, subtrações, divisões e multiplicações com facilidade;
 - **Suporte a decimais:** Trabalhe com números não inteiros;
 - **Validação de entrada:** A calculadora garante que apenas operações válidas sejam selecionadas no menu inicial;
 - **Tratamento de divisão por zero:** A calculadora é capaz de evitar uma tentativa de divisão por zero;

---
### Como usar
1. Clone o repositório ou baixe o código fonte da calculadora;
2. Abra o terminal ou o Prompt de Comando e navegue até a pasta correspondente;
3. Utilize o comando abaixo para restaurar as dependências do projeto:
```
dotnet restore
```
4. Em seguida, compile a solução utilizando o comando:
```
dotnet build --configuration Release
```
5. Para executar o projeto compilando em tempo real:
```
dotnet run --project Calculadora.ConsoleApp
```
6. Para executar o arquivo compilado, navegue até a pasta `./Calculadora.ConsoleApp/bin/Release/net8.0/`
```
Calculadora.ConsoleApp.exe
```

## Requisitos

- .NET SDK (recomendado .NET 5.0 ou superior) para compilação e execução do projeto.