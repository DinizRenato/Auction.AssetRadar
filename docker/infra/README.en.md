# 📦 AssetRadar -- Local Infrastructure (Development)

This folder contains the containers required to run the local
infrastructure:

-   SQL Server (Database)
-   Redis (Cache)
-   Azurite (Local Azure Blob Storage)

The API and Angular app are **not included** in this compose.

## 🚀 Start infrastructure

``` bash
cd docker/infra
docker compose up -d
docker compose ps
docker compose down
docker compose down -v
```

## 🔐 .env File

Create a `.env` file:

``` env
SA_PASSWORD=YourStrong(!)Password123
```

⚠️ Do not commit this file.

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

## 🧼 Full reset

``` bash
docker compose down -v
docker compose up -d
```
