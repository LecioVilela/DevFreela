# DevFreela

Projeto realizado no módulo **Formação ASP NET Core**, utilizando .NET 5.

O objetivo deste projeto é, aperfeiçoar o framework, construindo uma **API REST**, utilizamos vários recursos como:

- Swagger
- Arquitetura Limpa
- Camadas -> Core, Infrastructure, Application, API
- Entity Framework Core
- Dapper 
- CQRS
- MediatR
- JWT -> Json Web Token
- xUnit -> Para testes unitários

Mas quais funcionalidades foram implementadas?

- Cadastro, Atualização, Cancelamento e Consulta de Serviço de Freelancers.
- Cadastro de Usuário e de perfis Freelancer e Cliente
- Adicionar comentários para um serviço de Freelancer
- Definir, iniciar e finalizar o projeto
---

## Swagger

Ferramenta que simplifica o desenvolvimento de APIs, permitindo entre outras funcionalidades, a documentar e testar APIs. Ele consegue gerar uma interface gráfica contendo todos os pontos de acesso (Endpoints) da API, permitindo realizar requisições diretamente em sua interface.
![image](https://user-images.githubusercontent.com/76961685/128607463-b449e0ca-1b39-4cce-9b8e-38fb1fa469e2.png)

---
## Arquitetura Limpa

Também conhecida como **Onion Architecture**, ou Arquitetura Cebola.
Tem como foco o **domínio** do sistema, tendo em sua essência o DDD - Domain Driven Design, sendo dividida em 4 camadas principais:

- Core, Infrastructure, Application e API
![image](https://user-images.githubusercontent.com/76961685/128607691-bbeeb09f-aeaf-4baa-8019-fcd73942ca5a.png)

---

## Entity Framework Core

É a ORM mais utilizada para desenvolvimento em .NET, sendo multiplataforma, open-source e mantida pela Microsoft. É madura, tendo sido evoluída junto ao .NET Core, com performance e funcionalidades sendo melhoradas a cada versão.
Os pacotes a serem utilizados são:

~~~ csharp
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools

using Microsoft.EntityFrameworkCore;
~~~
![image](https://user-images.githubusercontent.com/76961685/128608246-d12db8a9-384f-4768-baba-f33989824431.png)

---

## Dapper

ORM mais performática e simples que o Entity Framework Core, de fácil adoção em um projeto que já utiliza o EF Core ou outros métodos de acessos de dados.

- Apresenta métodos de extensão ao **IDbConnection** (no caso de Sql.Server, SqlConnection)

~~~ csharp
using Dapper;
~~~
![image](https://user-images.githubusercontent.com/76961685/128608179-b25a1d15-a999-4312-bc26-fd60d3cd110a.png)

--- 

## CQRS

~~~ csharp
Command-Query Responsability Segregation
~~~
Padrão de desenvolvimento que separa as consultas (**Queries**) das ações que alteram o estado do sistema (**Commands**).

Melhora a legibilidade da aplicação, além de permitir maior separação de responsabilidades e estimula separação de modelos.
![image](https://user-images.githubusercontent.com/76961685/128608304-837169e1-c5de-4d4e-b518-d18860fc2429.png)

---

## MediatR

Uma espécie de *mensageria interna em memória*
Tem suporte a **Commands** e **Queries**, delegando eles para serem processados pelos seus respectivos **Handlers**
Pacote *MediatR*
~~~ csharp
MediatR.Extensions.Microsoft.DependencyInjection
~~~
![image](https://user-images.githubusercontent.com/76961685/128608476-44424e3c-f0bc-49a5-999a-5e9867fbdd35.png)

---

## Json Web Token - JWT

Basicamente é uma cadeia de caracteres com dados da aplicação e usuário em *base64*, além de uma chave gerada com um algoritmo de *hashing* como o **SHA256**.
Essa chave é gerada através de uma chave secreta definida na aplicação e que é validada ao receber a requisição.
O JWT é enviado via cabeçalho Authorization.
![image](https://user-images.githubusercontent.com/76961685/128608610-bafab7cf-0145-49bc-99d0-e5e0b49e9d8a.png)

---

## xUnit

Ferramenta gratuita e open-source para testes unitários, sendo a principal opção atualmente junto com o NUnit.
Funciona com o .NET Core, .NET Framework, Universal Windows Apps e Xamarin.
Tem um template prório para o .NET Core, tanto via linha de comando quanto pelo Visual Studio 2019.
Em um projeto de testes do xUnit, basta criar uma classe e inserir o método com a anotação [Fact].

~~~ csharp
public class ProjectTests
    {
        [Fact]
        public void TestIfProjectStartWorks()
        {
            var project = new Project("Nome De Teste", "Descricao de Teste", 1, 2, 10000);

            Assert.Equal(ProjectStatusEnum.Created, project.Status);
            Assert.Null(project.StartedAt);

            Assert.NotNull(project.Title);
            Assert.NotEmpty(project.Title);

            Assert.NotNull(project.Description);
            Assert.NotEmpty(project.Description);

            project.Start();

            Assert.Equal(ProjectStatusEnum.InProgress, project.Status);
            Assert.NotNull(project.StartedAt);
        }
    }
~~~