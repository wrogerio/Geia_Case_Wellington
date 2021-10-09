# Geia - Case Candidato Wellington

### Descrição / Regras de Negócio
```
1 - Criar uma aplicação web em MVC, utilizando uma arquitetura simples em camadas (camada de apresentação, negócio e infra)

2 - Utilizar o Entity Framework ou Dapper como ORM para as operações de banco de dados.

3 - Criar um CRUD de produtos, com os campos Id, Nome, Empresa, NumeroRegistro, DataValidade, Preço.

4 - Inserir uma validação na EDIÇÃO, para não permitir alterar o preço caso a data atual seja antes da DataValidade.

5 - Na Listagem dos produtos cadastrados, ter a opção de exportar os registros em Excel.

6 - Na exclusão, exibir uma mensagem de confirmação antes da operadora ser realizada.
```
---

### Obter uma cópia do fonte
```
git clone https://github.com/wrogerio/Geia_Case_Wellington.git
```
---

### Arquitetura Utilizada
Para o desenvolviemento da aplicação, a arquitetura utilizada foi a DDD (Domain Driven Design) com as seguintes camadas!

- Web - `ASPNET Core MVC.`
- Application - `Application`
- Domain - `Domain`
- Infra - `Infra`
    - 4.1 Data - `Infra.Data`
    - 4.2 IoC - `Infra.IoC`

---

### Importante - Preparação de Ambiente para subir o sistema
1 - Abrir o `cmd` como administrador.  
2 - Rodar o comando: `dotnet tool install --global dotnet-ef`  
3 - Com o cmd, acessar a pasta `GeiaSolution\src\Cadastro.Infra.Data`  
4 - Rodar o comando: `dotnet ef database update`  

---

### Subir o Sistema
- Abrir o projeto `GeiaSolution\GeiaSolution.sln` com o Visual Stdio.
- Menu `Debug` e escolhar `Start Debugging`.
---