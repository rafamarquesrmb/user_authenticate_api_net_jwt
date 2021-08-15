


[![author](https://img.shields.io/badge/Author-Rafael_Marques-blue.svg)](https://www.linkedin.com/in/rafamarquesrmb/) [![github](https://img.shields.io/badge/Github-rafamarquesrmb-ligh.svg)](https://github.com/rafamarquesrmb/) 

  
# User Authentication Web API using JWT and Bearer in .NET Core :rocket:

:brazil: [**PT-BR**] :brazil:
Demonstração de uma WEB API com autênticação de usuário utilizando JWT e Bearer no .NET Core.




:us: [**EN**] :us:

Demonstration of a WEB API with user authentication using JWT and Bearer in .NET Core.
  
  

## 📝Sobre/About:
:brazil: [**PT-BR**] :brazil:

Esta aplicação demonstra a utilização de Autênticação com JWT e Bearer no .NET Core.
Basicamente possui um modelo de usuário "User", que consiste em ID, username, password e Role.

Neste exemplo, o repositório de usuário consiste em um repositório estático, contendo dois usuários com roles diferentes. Um com a role de "manager" e outro com role de "employee".

A funcionalidade principal consiste na rota de login, onde a rota recebe um modelo User, verifica se este modelo existe dentro do repositório, e, caso sim, realiza a criação de um Token. 

A partir disso, o token pode ser utilizado nos Header (lembre-se de utilizar como Bearer) para garantir autenticação. 

Obs: para garantir a segurança do usuário, o retorno desta rota retorna uma password com string vazia.

Você pode rodar a aplicação com o comando no terminal:

    dotnet run


:us: [**EN**] :us:

This application demonstrates the use of Authentication with **JWT** and **Bearer** in **.NET Core**.

Basically it has a user model: "User", which have an ID, username, password and Role.

In this example, the user repository consists of a static repository, containing two users with different roles. One with the role of "manager" and the other with the role of "employee".

The main functionality consists of the login route, where the route receives a User model, checks if this model exists within the repository, and, if so, creates a Token.

From there, the token can be used in Headers (remember to use it as Bearer) to guarantee authentication.

Note: to ensure user security, the return from this route returns a password with an empty string.

You can run the application with the command in the terminal:

    dotnet run


## :computer:Tecnologias/Technologies:

 - [C#](https://docs.microsoft.com/pt-br/dotnet/csharp/) 
 - [.NET 5](https://docs.microsoft.com/pt-br/dotnet/)

<img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white" /> <img src="https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white" /> 

**Packages**

 - "Microsoft.AspNetCore.Authentication"  Version="2.2.0"
 - "Microsoft.AspNetCore.Authentication.JwtBearer"  Version="5.0.9"

To add these packages You can use these commands in Terminal:

    dotnet add package Microsoft.AspNetCore.Authentication
    dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer
---
---

## Encontre-me/Find me :globe_with_meridians: 🚩
:brazil: [**PT-BR**] :brazil:
Olá! Meu nome é Rafael Marques! Sou Brasileiro e Nordestino! Atuo como desenvolvedor Full Stack. Você pode conhecer mais sobre mim acessando os links nos botões abaixo!

:us: [**EN**] :us:
Hi!! My name is Rafael Marques, I'm a Brazilian Developer. You can find me on the links below:

  

[<img src="https://img.shields.io/badge/linkedin-%230077B5.svg?&style=for-the-badge&logo=linkedin&logoColor=white" />](https://www.linkedin.com/in/rafamarquesrmb/) [<img src = "https://img.shields.io/badge/instagram-%23E4405F.svg?&style=for-the-badge&logo=instagram&logoColor=white">](https://www.instagram.com/rafamarquesrmb/) [<img src="https://img.shields.io/badge/GitHub-100000?style=for-the-badge&logo=github&logoColor=white" />](https://github.com/rafamarquesrmb)
