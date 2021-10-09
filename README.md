# Geia - Case Candidato Wellington

### Descrição / Regras de Negócio
- Criar uma aplicação web em MVC, utilizando uma arquitetura simples em camadas (camada de apresentação, negócio e infra)
- Utilizar o Entity Framework ou Dapper como `ORM` para as operações de banco de dados.
- Criar um CRUD de produtos, com os campos `Id`, `Nome`, `Empresa`, `NumeroRegistro`, `DataValidade` e `Preço`.
- Inserir uma validação na `EDIÇÃO`, para não permitir alterar o `preço` caso a `data atual` seja antes da `DataValidade`.
- Na Listagem dos produtos cadastrados, ter a opção de `exportar os registros em Excel`.
- Na exclusão, `exibir uma mensagem de confirmação` antes da operadora ser realizada.

---
### Obter uma cópia do fonte
Para obter a cópia do fonte, basta seguir os procedimentos a seguir.
- Abrir o `cmd` no local onde ficará os arquivos
- executar o comando `git clone https://github.com/wrogerio/Geia_Case_Wellington.git`

---

### Arquitetura Utilizada
No desenvolvimento da aplicação, a arquitetura utilizada foi: `DDD` com as seguintes camadas!

- Web - `ASPNET Core MVC.`
- Application - `Application`
- Domain - `Domain`
- Infra - `Infra`
    - 4.1 Data - `Infra.Data`
    - 4.2 IoC - `Infra.IoC`

---

### Importante - Preparação de Ambiente para subir o sistema
- Abrir o `cmd` como administrador.  
- Rodar o comando: `dotnet tool install --global dotnet-ef`  
- Com o cmd, acessar a pasta `GeiaSolution\src\Cadastro.Infra.Data`  
- Rodar o comando: `dotnet ef database update`  

---

### Subir o Sistema
- Abrir o projeto `GeiaSolution\GeiaSolution.sln` com o Visual Stdio.
- Menu `Debug` e escolhar `Start Debugging`.
---