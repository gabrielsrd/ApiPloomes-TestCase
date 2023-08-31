# ApiPloomes - API REST em C# para Gerenciamento de Usuários e Tarefas

O ApiPloomes é uma API simples criada em C# que permite você executar operações básicas de gerenciamento de usuários e tarefas. A API utiliza o protocolo HTTP e o formato JSON para se comunicar e interage com um banco de dados SQL Server.

## Começando

Siga estas instruções para configurar e executar o projeto ApiPloomes em sua própria máquina.

### Pré-requisitos

- SDK do .NET Core (versão X.X.X)
- SQL Server (local ou remoto)

### Instalação

1. Clone este repositório:

2. Vá para a pasta do projeto:

   ```bash
   cd ApiPloomes
   ```

3. Edite o arquivo `appsettings.json` com os detalhes da sua conexão com o SQL Server:

   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=SEU_SERVIDOR;Database=ApiPloomesDB;Trusted_Connection=True;"
     }
   }
   ```

4. Aplique as migrações para criar o banco de dados:

   ```bash
   dotnet ef database update -Context SistemaTarefasDBContext
   ```

### Uso

1. Compile e execute o projeto:

   ```bash
   dotnet run
   ```

2. Acesse a API usando um navegador, é possível ver a documentação em Swagger no link.

   - URL Base: (https://localhost:7190/swagger/index.html)

3. Endpoints Disponíveis:

   - `GET /usuarios`: Obtenha uma lista de todos os usuários.
   - `GET /usuarios/{id}`: Obtenha detalhes de um usuário específico.
   - `POST /usuarios`: Crie um novo usuário.
   - `PUT /usuarios/{id}`: Atualize um usuário existente.
   - `DELETE /usuarios/{id}`: Exclua um usuário.

   - `GET /tarefas`: Obtenha uma lista de todas as tarefas com o usuario(se relacionado).
   - `GET /tarefas/{id}`: Obtenha detalhes de uma tarefa específica com o usuario(se relacionado).
   - `POST /tarefas`: Crie uma nova tarefa.
   - `PUT /tarefas/{id}`: Atualize uma tarefa existente.
   - `DELETE /tarefas/{id}`: Exclua uma tarefa.

