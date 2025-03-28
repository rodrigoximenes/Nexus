# NpsApi

## Descrição
Este é um projeto para cálculo do NPS, desenvolvido utilizando .NET Core e MongoDB. O projeto disponibiliza uma API para registro de respostas de clientes e cálculo do NPS.

## Tecnologias Utilizadas
- **.NET 7 / .NET Core** - Framework backend
- **MongoDB** - Banco de dados NoSQL
- **Docker** - Containerização da aplicação
- **Swagger** - Documentação interativa da API

## Como Rodar o Projeto

### Rodando via Docker Compose


1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/npsapi.git
   cd npsapi
   ```

2. Suba os contêineres com o Docker Compose:
   ```bash
   docker-compose up -d
   ```

3. Acesse a API:
   - **Swagger:** [http://localhost:8080/swagger](http://localhost:8080/swagger)
   - **MongoDB:** Rodando na porta 27017

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





