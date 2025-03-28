# NpsApi

## Descri��o
Este � um projeto para c�lculo do NPS, desenvolvido utilizando .NET Core e MongoDB. O projeto disponibiliza uma API para registro de respostas de clientes e c�lculo do NPS.

## Tecnologias Utilizadas
- **.NET 7 / .NET Core** - Framework backend
- **MongoDB** - Banco de dados NoSQL
- **Docker** - Containeriza��o da aplica��o
- **Swagger** - Documenta��o interativa da API

## Como Rodar o Projeto

### Rodando via Docker Compose


1. Clone o reposit�rio:
   ```bash
   git clone https://github.com/seu-usuario/npsapi.git
   cd npsapi
   ```

2. Suba os cont�ineres com o Docker Compose:
   ```bash
   docker-compose up -d
   ```

3. Acesse a API:
   - **Swagger:** [http://localhost:8080/swagger](http://localhost:8080/swagger)
   - **MongoDB:** Rodando na porta 27017

## C�lculo do NPS
O NPS � um m�todo utilizado para medir a satisfa��o dos clientes e sua lealdade � marca.

1. Os clientes respondem a uma pergunta de 0 a 5: **"O quanto voc� recomendaria nossa empresa a um amigo?"**
2. Eles s�o classificados em:
   - **Detratores (0 a 2)**: Clientes insatisfeitos
   - **Neutros (3)**: Clientes satisfeitos, mas n�o leais
   - **Promotores (4 e 5)**: Clientes entusiasmados que promovem a empresa
3. O c�lculo do NPS � feito pela f�rmula:
   
   \[
   NPS = \% de Promotores - \% de Detratores
   \]





