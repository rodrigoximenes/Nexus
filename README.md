# NpsApi

## Descrição
Este é um projeto para cálculo do NPS, desenvolvido utilizando .NET Core e MongoDB. O projeto disponibiliza uma API para registro de respostas de clientes e cálculo do NPS.

## Tecnologias Utilizadas
- **.NET 7 / .NET Core** - Framework backend
- **MongoDB** - Banco de dados NoSQL
- **Docker** - Containerização da aplicação
- **Swagger** - Documentação interativa da API

## Como Rodar o Projeto

### Rodando Localmente

1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/npsapi.git
   cd npsapi
   ```

2. Configure a string de conexão do MongoDB no `appsettings.json`:
   ```json
   "MongoDbSettings": {
     "ConnectionString": "mongodb://root:sua-senha@localhost:27017/admin",
     "DatabaseName": "seuBancoDeDados"
   }
   ```

3. Inicie o MongoDB localmente:
   ```bash
   docker run -d \
     --name mongo \
     -e MONGO_INITDB_ROOT_USERNAME=root \
     -e MONGO_INITDB_ROOT_PASSWORD=sua-senha \
     -v mongo-data:/data/db \
     -p 27017:27017 \
     mongo:latest
   ```

4. Execute a API:
   ```bash
   dotnet run --project src/NpsApi.WebAPI/NpsApi.WebAPI.csproj
   ```

5. Acesse a documentação Swagger:
   - URL: [http://localhost:5000/swagger](http://localhost:5000/swagger)

---

### Rodando via Docker Compose

1. Suba os contêineres com o Docker Compose:
   ```bash
   docker-compose up -d
   ```

2. Acesse a API:
   - **Swagger:** [http://localhost:5000/swagger](http://localhost:5000/swagger)
   - **MongoDB:** Rodando na porta 27017

3. Para parar os contêineres:
   ```bash
   docker-compose down
   ```

## Cálculo do NPS
O NPS é um método utilizado para medir a satisfação dos clientes e sua lealdade à marca.

1. Os clientes respondem a uma pergunta de 0 a 5: **"O quanto você recomendaria nossa empresa a um amigo?"**
2. Eles são classificados em:
   - **Detratores (0 a 2)**: Clientes insatisfeitos
   - **Neutros (3)**: Clientes satisfeitos, mas não leais
   - **Promotores (4 e 5)**: Clientes entusiasmados que promovem a empresa
3. O cálculo do NPS é feito pela fórmula:
   
   \[
   NPS = \% de Promotores - \% de Detratores
   \]





