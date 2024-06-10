# Blazor Markdown

This is a Blazor Web App with a Docker Compose configuration also splitting the database and the application.
It uses the **Markdig** Libary to render Markdown as HTML on the Frontend.

## Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [Docker Engine](https://docs.docker.com/engine/install/)
- [Docker Desktop (optional)](https://www.docker.com/products/docker-desktop/)

## Project Configurations

### docker-compose

The `docker-compose` project contains two start profiles, `docker-compose` and 'DB only'. The `docker-compose` profile will start the application and the database, while the 'DB only' profile will only start the database.

## Create Migrations

To create a migration the Data Directory must be the current Project Directory, then a migration can be created normally with

```bash
Add-Migration [Name]
```

## Project Structure

| Directory | Description |
| --- | --- |
| Data | Contains the models, interfaces and database context for the application. |
| docker-compose | Contains the configuration for the Docker containers. |
| Web | Contains the UI / Frontend of the application. |

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
