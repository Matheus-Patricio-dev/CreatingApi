# 🖥️ **Construção de API em Web API .NET Core** 🖥️

---

## 🚀 Sobre o Projeto

Este projeto tem como objetivo a construção de uma API utilizando o **ASP.NET Core** para criar um serviço web robusto e escalável. A API será capaz de realizar operações básicas de CRUD (Criar, Ler, Atualizar, Deletar) e estará conectada a um banco de dados **PostgreSQL** para persistência de dados. Além disso, utilizamos o **Entity Framework Core** para facilitar a interação com o banco de dados e garantir uma camada de acesso a dados eficiente e intuitiva.

---

## 📚 O que é uma API?

Uma **API** (Interface de Programação de Aplicações) é um conjunto de definições e protocolos que permite a comunicação entre diferentes sistemas ou componentes de software. Em termos simples, é como uma ponte que permite que diferentes sistemas "conversem" entre si de maneira padronizada e segura.

---

## 💻 O que é o ASP.NET Core?

**ASP.NET Core** é um framework de código aberto desenvolvido pela Microsoft para a construção de aplicações web e APIs. Ele é uma versão mais moderna, leve e modular do ASP.NET, permitindo a criação de aplicações de alto desempenho, escaláveis e seguras.

### Como o ASP.NET Core se relaciona com o Projeto?

No projeto, o **ASP.NET Core** é utilizado para criar e gerenciar os endpoints da API, fornecer a lógica de negócios e garantir a segurança das requisições. A API foi construída com as melhores práticas do framework, garantindo uma arquitetura limpa e fácil manutenção.

---

## 🗄️ Banco de Dados: PostgreSQL

O banco de dados utilizado neste projeto é o **PostgreSQL**, um sistema de gerenciamento de banco de dados relacional poderoso, open-source e altamente confiável. Ele é amplamente utilizado para armazenar dados de forma estruturada e garantir alta disponibilidade e integridade dos dados.

### Como o Entity Framework Core se relaciona com o Projeto?

Para a persistência de dados, este projeto utiliza o **Entity Framework Core** (EF Core), uma ORM (Object-Relational Mapper) da Microsoft que simplifica a interação com o banco de dados, permitindo que você trabalhe com dados usando objetos .NET em vez de escrever SQL manualmente. O EF Core facilita a criação e a manutenção de um modelo de dados, mapeando as classes do C# diretamente para as tabelas no banco PostgreSQL.

---

## Status do Projeto
- **Status Atual**: Em progresso
- **Versão Atual**: v0.8
- **Última Atualização**: 2024-11-27
- [![Status de Build](https://img.shields.io/badge/build-passing-brightgreen)](https://ci.example.com)

## Descrição
Uma Api básica, utilizando Nomes de Carros, sua fabricante e seu pais, utilizando banco de dados Postgree

## Funcionalidades
- Metodo GET
- Metodo GET{Id}
- Metodo POST
- Metodo PUT
- Metodo DELETE
- Comunicação com Postgree

## Lista de Tarefas

### Tarefas Completas ✅
- [x] Implementação do GET
- [x] Implementacao do Metodo UPDATE.
- [x] Implementacao do Metodo DELETE.
- [x] Implementacao do Metodo POST.
- [x] Integração com o Banco de dados
- [x] tratar erros dos Verbos HTTP.
- [x] Implementar a interface e nova tabela de comunicação com Banco de dados.
 
### Tarefas Pendentes 🚧
- [ ] Testar integração.
- [ ] Criar documentação para a API

### Melhorias Futuros 🌱
- [ ] Refatorar código do módulo do Contexto e Repositorio
- [ ] Melhorar comunicacao com o usuario no Swagger
- [ ] Melhorar interface do usuário

## Como Contribuir
Se você deseja contribuir com o projeto, siga estas etapas:
1. Fork o repositório.
2. Crie uma branch para a sua feature (`git checkout -b feature/nome-da-feature`).
3. Comite suas alterações (`git commit -am 'Adiciona nova feature'`).
4. Envie para o repositório original (`git push origin feature/nome-da-feature`).
5. Abra um pull request.


## ⚙️ Tecnologias Utilizadas

- **ASP.NET Core** ![ASP.NET Core](https://img.shields.io/badge/-ASP.NET%20Core-512BD4?style=flat&logo=aspnetcore&logoColor=white)
- **API** ![API](https://img.shields.io/badge/-API-25D366?style=flat&logo=api&logoColor=white)
- **PostgreSQL** ![PostgreSQL](https://img.shields.io/badge/-PostgreSQL-336791?style=flat&logo=postgresql&logoColor=white)
- **Entity Framework Core** ![Entity Framework Core](https://img.shields.io/badge/-Entity%20Framework%20Core-7C7C7C?style=flat&logo=entitydotnet&logoColor=white)

---

## 🔧 Como Rodar o Projeto

1. Clone o repositório:
   ```bash
   git clone https://github.com/Matheus-Patricio-dev/CreatingApi
