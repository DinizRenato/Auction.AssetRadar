# Auction.AssetRadar

AssetRadar is a real estate auction aggregation platform built with ASP.NET Boilerplate (ABP) and Angular.

The project is designed as a portfolio-grade application, focusing on:

- Clean architecture
- Domain-driven design principles
- Scalable infrastructure
- Caching strategies (Redis)
- Storage abstraction (Azure Blob / Azurite)
- CI/CD readiness
- Professional Git workflow

---

## 🚀 Tech Stack

- ASP.NET Boilerplate (ABP)
- .NET
- Angular
- SQL Server
- Redis
- Azure Blob Storage (Azurite for local development)
- Docker (Infrastructure)

---

## 🧱 Project Goals

- Aggregate auction properties
- Provide filtering by state, discount, and other criteria
- Implement intelligent ranking for home page highlights
- Apply production-ready infrastructure patterns
- Simulate enterprise-level development workflow

---

## 🌿 Branch Strategy

This project follows a simplified professional branching model.

### Main Branch

- `main`
  - Always stable
  - Always deployable
  - No direct commits allowed

### Supporting Branches

- `feature/<name>` – New features
- `fix/<name>` – Bug fixes
- `chore/<name>` – Infrastructure or maintenance changes
- `docs/<name>` – Documentation updates

### Naming Convention

- Lowercase only
- Words separated by hyphen

Examples:
feature/property-search
feature/redis-home-cache
fix/null-document-type
chore/docker-infra
docs/readme-update


### Workflow

1. Create branch from `main`
2. Develop and commit
3. Push branch to remote
4. Open Pull Request
5. Merge into `main`
6. Delete branch

---

## 📝 Commit Convention

This project follows a simplified Conventional Commit style:

- `feat:` New feature
- `fix:` Bug fix
- `chore:` Infrastructure / maintenance
- `docs:` Documentation updates
- `refactor:` Code improvements without behavior changes

Examples:
feat: add property filtering by state
fix: handle null document type
chore: add docker infra configuration
docs: update branch strategy section


---

## 🐳 Local Infrastructure

Infrastructure for development (SQL Server, Redis, Azurite) is available in:
docker/infra


See the README inside that folder for setup instructions.

---

## 📈 Future Improvements

- CI/CD pipeline
- Production containerization
- Azure deployment
- Observability and logging
- Performance optimizations

---

This project is intentionally structured to simulate a real-world enterprise workflow.
