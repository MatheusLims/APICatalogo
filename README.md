# 📦 APICatalogo

API REST de catálogo desenvolvida em **.NET 8.0**, utilizando **MySQL** como banco de dados, com foco em boas práticas de back-end, organização de código e aprendizado de APIs modernas.

---

## 🚀 Tecnologias Utilizadas

- **.NET 8.0**
- **ASP.NET Core Web API**
- **MySQL**
- **Entity Framework Core**
- **Pomelo.EntityFrameworkCore.MySql**
- **OpenAPI (Swagger)**
- **DotNet EF Tools**

---

## 🧱 Estrutura do Projeto

O projeto **APICatalogo** é composto por duas entidades principais:

### 🔹 Produto
Representa os produtos do catálogo, contendo informações essenciais para gerenciamento e exibição.

### 🔹 Categoria
Responsável por organizar e classificar os produtos dentro do sistema.

Ambas as entidades utilizam **Data Annotations** para:
- Definição de chaves primárias
- Relacionamentos
- Regras de validação
- Mapeamento do banco de dados

---

## 🗄️ Banco de Dados

- Banco de dados relacional **MySQL**
- Utilização de **Migrations** para:
  - Criação do schema
  - Versionamento do banco
  - População inicial de dados

As migrations foram geradas utilizando o **Entity Framework Core**, garantindo controle e consistência da estrutura do banco.

---

## 🔁 Endpoints e Métodos HTTP

A API implementa os principais métodos HTTP utilizados em APIs REST:

| Método | Descrição |
|------|----------|
| GET | Consulta de dados |
| POST | Criação de registros |
| PUT | Atualização de registros |
| DELETE | Remoção de registros |

Esses métodos são aplicados tanto para **Produtos** quanto para **Categorias**.

---

## ⚠️ Tratamento de Erros

O projeto implementa:
- Tratamento de exceções
- Validações de entrada
- Respostas HTTP adequadas para cenários de erro
- Garantia de maior estabilidade e previsibilidade da API

---

## 📄 Documentação da API

A documentação é gerada automaticamente utilizando **OpenAPI (Swagger)**, permitindo:
- Visualização dos endpoints
- Testes diretos via navegador
- Melhor entendimento da estrutura da API

---

## ✨ Bônus: Refatoração e Otimização

Durante o desenvolvimento, foram realizadas:
- Refatorações para melhoria da legibilidade do código
- Otimização de alguns fluxos da API
- Ajustes em protocolos e organização dos controllers
- Melhoria na estrutura geral do projeto

---

## ▶️ Como Executar o Projeto

1. Clone o repositório:
   ```bash
   git clone https://github.com/MatheusLims/APICatalogo.git
