# 📦 AssetRadar -- Infraestrutura Local (Desenvolvimento)

Esta pasta contém os containers necessários para rodar a infraestrutura
local da aplicação:

-   SQL Server (Banco de Dados)
-   Redis (Cache)
-   Azurite (Azure Blob Storage local)

A API e o Angular **não fazem parte deste compose**.

## 🚀 Como subir a infraestrutura

``` bash
cd docker/infra
docker compose up -d
docker compose ps
docker compose down
docker compose down -v
```

## 🔐 Arquivo .env

Crie um arquivo `.env` na mesma pasta:

``` env
SA_PASSWORD=YourStrong(!)Password123
```

⚠️ Não commitar este arquivo.

## 🗄 SQL Server

Connection String:

    Server=localhost,1433;
    Database=AssetRadarDb;
    User Id=sa;
    Password=YourStrong(!)Password123;
    TrustServerCertificate=True;
    MultipleActiveResultSets=True;

## ⚡ Redis

    localhost:6379

## 🖼 Azurite (Blob Storage)

Blob Endpoint:

    http://127.0.0.1:10000/devstoreaccount1

Connection String:

    DefaultEndpointsProtocol=http;
    AccountName=devstoreaccount1;
    AccountKey=Eby8vdM02xNOcqFeqCnf2xNOcqFeqCnf2xNOcqFeqCnf2xNOcqFeqCnf2xNOcqFeqCnf2x==;
    BlobEndpoint=http://127.0.0.1:10000/devstoreaccount1;

## 🧼 Reset completo

``` bash
docker compose down -v
docker compose up -d
```
