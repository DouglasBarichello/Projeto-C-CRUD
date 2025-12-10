# Projeto CRUD em C# Console
 
Este projeto é uma aplicação simples de console desenvolvida em **C#**, simulando um sistema básico de gerenciamento de usuários (**CRUD – Create, Read, Update, Delete**).  
Os dados são armazenados em uma coleção **List<Usuario>**, funcionando como um banco de dados temporário em memória — ideal para estudos em **Programação Orientada a Objetos (POO)**, encapsulamento e manipulação de coleções.
 
O usuário interage por meio de um menu exibido diretamente no terminal.
 
---
 
## Funcionalidades Principais
 
- **Criar (Create):** Cadastro de novos usuários, com ID gerado automaticamente.  
- **Exibir (Read):** Lista completa de todos os usuários cadastrados.  
- **Atualizar (Update):** Permite buscar um usuário por ID e alterar seus dados.  
- **Deletar (Delete):** Remove um usuário com base no ID informado.  
- **Validação:** Verificação de entradas vazias, idade numérica e demais campos obrigatórios.  
- **Encapsulamento:** A classe `Usuario` usa propriedades privadas e métodos Get/Set para controlar acesso aos dados.
 
---
 
## Estrutura do Projeto
 
O projeto possui três classes principais, separando responsabilidades:
 
### **1. Usuario**
Define a estrutura do objeto e implementa o encapsulamento.
 
- Propriedades privadas:
  - `private int Id { get; set; }`
- Métodos públicos:
  - `public int GetId()`
  - `public void SetId(int novoId)`
- Métodos de acesso para:
  - `NomeCompleto`
  - `Email`
  - `Idade`
  - `Senha`
 
### **2. GerenciadorUsuario**
Responsável pela lógica de negócios (CRUD).
 
- `List<Usuario> bancoDados` – armazenamento dos registros.
- `private int proximoId` – controle de IDs únicos.
- `CriarUsuario()` – valida e insere novos usuários.
- `AtualizarUsuario()` – busca por ID e altera dados usando referência do objeto.
- `DeletarUsuario()` – remove um usuário da lista com base no ID.
 
### **3. Program**
Ponto de entrada da aplicação.
 
- Contém o loop principal `while(true)`.
- Apresenta o menu de navegação usando `switch`.
- Chama os métodos do `GerenciadorUsuario`.
 
---
 
## Classes e Métodos-Chave
 
### **Classe Usuario**
Armazena informações de cada usuário e controla o acesso por encapsulamento.
 
### **Classe GerenciadorUsuario**
Contém toda a lógica para criação, leitura, atualização e exclusão de usuários.
 
---
 
## Como Executar
 
Este é um projeto **console .NET**. Para executar, é necessário ter o SDK do .NET instalado (Visual Studio ou VS Code).
 
### ** Compilar e Rodar**
 
Salve o código como `Program.cs` e execute os comandos:
 
```bash
dotnet run
