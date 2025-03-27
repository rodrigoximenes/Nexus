# Etapa 1: Build da aplicação
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copia os arquivos da solução
COPY ./NpsApi.sln ./

# Copia os arquivos .csproj de todos os projetos
COPY ./src/NpsApi.Repositorio/*.csproj ./src/NpsApi.Repositorio/
COPY ./src/NpsApi.WebAPI/*.csproj ./src/NpsApi.WebAPI/
COPY ./src/NpsApi.Dominio/*.csproj ./src/NpsApi.Dominio/
COPY ./src/NpsApi.Servico/*.csproj ./src/NpsApi.Servico/

# Restaura dependências
RUN dotnet restore

# Copia o código restante e faz o build
COPY ./src . .
RUN dotnet publish ./src/NpsApi.WebAPI/NpsApi.WebAPI.csproj -c Release -o /out

# Etapa 2: Executando a aplicação
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /out .
EXPOSE 5000
EXPOSE 5001
ENTRYPOINT ["dotnet", "NpsApi.WebAPI.dll"]
