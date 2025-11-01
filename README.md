# Adform application task

## Description

[![ASP.NET Core][ASP.NET Core]][ASP.NET-Core-url]
[![PostgreSQL][PostgreSQL]][PostgreSQL-url]
[![Docker][Docker]][Docker-url]

A simple order management API with a persistence layer. [Learn more here](https://github.com/erinev/order-management-api-exercise).

## Getting started

### Prerequisites

- **Docker** and **Docker compose** installed on system
- Other Docker services are down (might get porting conflicts)

### Instructions

1. Open a terminal in the project root
2. Launch with:

```sh
docker compose up -d
```

_If you get certificate issues, try getting rid of port mapping `8001:8081` and `ASPNETCORE_HTTPS_PORTS=8081` in `docker-compose.yml`_

3. Go to `localhost:8000/swagger/index.html` to access Swagger UI

4. _(Optionally)_ You can go to `http://localhost:8080/browser/` to access pgAdmin4 and log in with Username - `admin@example.com` and Password - `admin`

## Highlights

- Clean architecture
- CQRS with **MediatR**
- Request validation with **FluentValidation**
- Exception filters
- Easy setup thanks to Docker
- Mappings with **AutoMapper**
- Minimal seeding

## Possible improvements

- Get rid of lazy-loading. Only used it for convenience :p
- Global exception handler
- Tests

## Final thoughts

- Spent around 8 hours in total working on this project
- Prioritised functionality (KISS)
- Had lots of fun :p

[ASP.NET Core]: https://img.shields.io/badge/ASP.NET_Core-20232A?style=for-the-badge&logo=.net&logoColor=512BD4
[ASP.NET-Core-url]: https://dotnet.microsoft.com/en-us/apps/aspnet
[PostgreSQL]: https://img.shields.io/badge/PostgreSQL-20232A?style=for-the-badge&logo=postgresql&logoColor=3178C6
[PostgreSQL-url]: https://www.postgresql.org/
[Docker]: https://img.shields.io/badge/Docker-20232A?style=for-the-badge&logo=docker&logoColor=2496ED
[Docker-url]: https://www.docker.com/
