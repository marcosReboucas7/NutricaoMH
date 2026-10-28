# 🥗 NutriçãoMH

> API REST para gestão de pacientes e acompanhamento nutricional, feita com **ASP.NET Core**, **PostgreSQL** e **Docker**.

![.NET](https://img.shields.io/badge/.NET-10-512BD4?logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?logo=csharp&logoColor=white)
![PostgreSQL](https://img.shields.io/badge/PostgreSQL-4169E1?logo=postgresql&logoColor=white)
![Docker](https://img.shields.io/badge/Docker-2496ED?logo=docker&logoColor=white)
![JWT](https://img.shields.io/badge/Auth-JWT-000000?logo=jsonwebtokens&logoColor=white)
![Status](https://img.shields.io/badge/status-em%20desenvolvimento-yellow)

---

## 📌 Sobre o projeto

O **NutriçãoMH** nasceu da união de duas áreas: a **programação** e a **nutrição**. O domínio do sistema (consultas, avaliações, evolução do paciente, plano alimentar) vem da experiência real de uma nutricionista. A parte técnica é um projeto de estudo e portfólio, para aplicar na prática conceitos de back-end moderno.

O objetivo é permitir que o **nutricionista** gerencie seus pacientes e acompanhe a evolução ao longo do tempo, enquanto o **paciente** consulta os próprios dados com segurança.

## ✨ Funcionalidades

- [ ] 🔐 Autenticação e autorização com **ASP.NET Identity + JWT** (login, logout e controle por perfil)
- [ ] 👥 Perfis de acesso: **Nutricionista** e **Paciente**
- [ ] 🧑‍⚕️ Cadastro, consulta e gestão de pacientes
- [ ] 🎯 Objetivos do paciente (ex.: perda de peso, ganho de massa)
- [ ] 📅 Histórico de consultas
- [ ] 📏 Avaliações nutricionais: peso, altura, medidas e **cálculo automático de IMC**
- [ ] 📈 Histórico e indicadores de evolução
- [ ] 🍽️ Refeições / plano alimentar

> Os itens serão marcados conforme forem sendo entregues. Veja o [Roadmap](#-roadmap).

## 🛠️ Tecnologias

| Camada | Tecnologia |
|---|---|
| Linguagem / Framework | C# · ASP.NET Core Web API (.NET 10) |
| Banco de dados | PostgreSQL 17 |
| ORM | Entity Framework Core + Npgsql |
| Autenticação | ASP.NET Core Identity + JWT Bearer |
| Documentação da API | Swagger (Swashbuckle) |
| Infraestrutura | Docker · Docker Compose |

## 🏗️ Estrutura do projeto

```
NutricaoMH/
├── docker-compose.yml        # API + PostgreSQL
├── .env.example              # variáveis de ambiente (modelo)
└── NutricaoMH/
    ├── Controllers/          # endpoints REST
    ├── Models/               # entidades do domínio
    ├── Dtos/                 # contratos de entrada/saída da API
    ├── Data/                 # DbContext e Migrations
    ├── Services/             # regras de negócio (ex.: IMC, geração de token)
    ├── Program.cs
    └── Dockerfile
```

## 🚀 Como executar

### Pré-requisitos

- [Docker Desktop](https://www.docker.com/products/docker-desktop/)
- (Opcional, para desenvolvimento) [.NET SDK 10](https://dotnet.microsoft.com/download)

### Com Docker (recomendado)

```bash
# 1. Clone o repositório
git clone https://github.com/<seu-usuario>/NutricaoMH.git
cd NutricaoMH

# 2. Configure as variáveis de ambiente
cp .env.example .env        # no Windows (PowerShell): Copy-Item .env.example .env

# 3. Suba a API e o banco
docker compose up --build
```

| Serviço | URL |
|---|---|
| API | http://localhost:8080 |
| PostgreSQL | `localhost:5432` |

Para parar tudo: `docker compose down` (adicione `-v` para apagar também os dados do banco).

### Sem Docker para a API (só o banco no container)

```bash
docker compose up db -d
cd NutricaoMH
dotnet run
```

> Nesse modo, configure a connection string em `appsettings.Development.json` ou com `dotnet user-secrets`.

## 🔑 Perfis e permissões

| Ação | Nutricionista | Paciente |
|---|:---:|:---:|
| Cadastrar / editar pacientes | ✅ | ❌ |
| Registrar consultas e avaliações | ✅ | ❌ |
| Definir objetivos e refeições | ✅ | ❌ |
| Ver os próprios dados e evolução | ✅ | ✅ |

## 🗺️ Roadmap

- [x] Estrutura inicial do projeto, Docker e pacotes
- [ ] Modelagem do banco + primeira migration
- [ ] Autenticação (registro, login, logout) com JWT e perfis
- [ ] CRUD de pacientes
- [ ] Consultas e avaliações com cálculo de IMC
- [ ] Objetivos e refeições
- [ ] Endpoint de evolução (histórico de peso/IMC)
- [ ] Testes automatizados
- [ ] CI com GitHub Actions

## 👤 Autor

Desenvolvido por **<seu nome>**, com a consultoria de domínio de uma nutricionista (minha esposa 💚).

- LinkedIn: <seu-link>
- GitHub: <seu-link>

## 📄 Licença

Este projeto está sob a licença MIT. Consulte o arquivo `LICENSE` para mais detalhes.
