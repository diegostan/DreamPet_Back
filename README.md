# DreamPet_Back 
### Todo código backend da aplicação

## 💜 DreamPet 💜

* O DreamPet surgiu da ideia de gerenciar melhor o histórico de animais como controle de vacinação, alimentação, exercícios entre outras.
* A ideia é que donos em geral cadastrem seus pets no sistema e tenham um histórico total da vida do seu animal.
* Também idealizo a ideia de criar um forum para as pessoas se comunicarem e trocar experiências.
* Um dono pode ter diversos animais cadastrados e suas respectivas linha do tempo.
* Uma empresa poderá cadastrar seus animais usando o cadastro com CNPJ.
* Não existe qualquer intuito de monetizar esse sistema, ele sempre será OpenSource, sem anuncios, sem pagamentos.
* Caso a escalabilidade horizontal se torne insustentável do ponto de vista financeiro, iremos procurar algum patrocinio APENAS para infra.

## Open Source

* Desenvolvimento com .NET Core 5 será totalmente OPEN e multiplataforma

## Sobre o projeto

* O projeto está dividido em camadas para facilitar a escalabilidade e manutenção
* A parte de testes unitarios já está implementada
* As entidades e os modelos de domínio estão desacoplados do Repositorio
* Repository Patterns, S.O.L.I.D

## Sobre a API

* A API está em processo de construção, nela irá conter apenas a parte Rest para executar commands, 
a ideia é desenvolver uma API Clean Code com alta taxa de manutenção e escalabilidade
* ASP.NET MVC 
* Autenticação e autorização via redes sociais com Firebase(futuro)

## Modelagem e estrutura

* A modelagem do back é com DDD e TDD 
* A aplicação terá domínio rico, o DB só serivrá de repos
* Criou uma entidade ? Crie um teste para ela!
* Testes testes e mais testes. Vai que a aplicação cresce a nível global 🤣💜

## Atualizações

* Integração de sistema de autorização
* Integração de sistema de autenticação
* Integrar os Handler no Dominio 
* Implementar o Repository Patterns

## Tecnologias back end

* ASP.NET Core 5
* Entity Framework Core 5
* Autenticação com Bearer
* JSON
* MVC
* Dominio rico (tratamento de dados do lado da API)
* SQL Server
* Azure

## Tecnologias front end

* Xamarin para Mobile
* Quem sabe o MAUI chegue para criarmos algo para Desk ? ❤️
* Pretendo utilizar Angular para WEB(estou aprendendo ainda...)
