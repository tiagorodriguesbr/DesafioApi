# Api Rest C# CRUD com Entity Framework e Db In-Memory!

## Como rodar em seu computador

- .NET 3 ou superior
- Extraia o repositório
- Com o terminal digite, "dotnet run" sem aspas

## Criar um usuário

VERBO HTTP POST

https://localhost:5001/users

```
{
    "nome": "Jhon",
    "endereco": "Rua Almirante 55",
}
```
## Listar Usuarios

VERBO HTTP GET

https://localhost:5001/users

## Update Usuários

VERBO HTTP PUT

https://localhost:5001/users/1

```
{
    "nome": "Jhon",
    "endereco": "Rua Barroso 34",
}
```

## Delete Usuários

VERBO HTTP DELETE

https://localhost:5001/users/1