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

### Obter uma cópia do fonte
```
git clone https://github.com/wrogerio/Geia_Case_Wellington.git
```

### Arquitetura Utilizada
```
Para o desenvolviemento da aplicação, a arquitetura utilizada foi a DDD (Domain Driven Design)

Teremos as camadas:
 1.  Web             - Projeto ASPNET Core MVC.
 2.  Application     - Projeto Application
 3.  Domain          - Projeto Domain
 4.  Infra           - Projeto Infra
 4.1 Infra/Data      - Projeto Infra.Data
 4.2 Infra/IoC       - Projeto Infra.IoC
```