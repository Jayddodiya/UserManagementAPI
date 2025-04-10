# User Management API

This is a simple .NET Web API for managing users, built using Copilot and C#.

## Features

- ✅ CRUD operations: Create, Read, Update, Delete users
- ✅ Validation using `ModelState`
- ✅ Middleware for logging
- ✅ Swagger UI for testing endpoints
- ✅ Built and debugged with help from GitHub Copilot

## Endpoints

- `GET /api/users` - List all users
- `POST /api/users` - Create a new user
- `GET /api/users/{id}` - Get a user by ID
- `PUT /api/users/{id}` - Update a user
- `DELETE /api/users/{id}` - Delete a user

## Run Locally

```bash
dotnet dev-certs https --trust
dotnet run --launch-profile https

