# Adform application task

## Task

A simple order management API with a persistence layer. [Learn more here](https://github.com/erinev/order-management-api-exercise).

## Getting started

### Prerequisites

- Docker and Docker compose installed on system
- Other Docker services are down (might get porting conflicts)

### Instructions

1. Open a terminal in the project root
2. Launch with:

```sh
docker compose up -d
```

_If you get certificate issues, try getting rid of part mappings and `ASPNETCORE_HTTPS_PORTS=8081` in `docker-compose.yml`_

## Highlights

- Clean architecture
- CQRS with **MediatR**
- Request validation with **FluentValidation**
- Exception filters
- Easy setup thanks to Docker
- Mappings with **AutoMapper**

## Possible improvements

- Get rid of lazy-loading. Only used it for convenience :p
- Global Exception Handler
- Tests
