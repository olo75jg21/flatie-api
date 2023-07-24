# Flatie - Collaborative Home Management Platform (Backend)

Welcome to the backend repository of Flatie, the Collaborative Home Management Platform. This project is currently a work in progress and is being built using .NET 7. It serves as the backend server for the collaborative web application designed to enhance shared living experiences.

## Table of Contents

- [Project Overview](#project-overview)
- [Features](#features)
- [Technologies Used](#technologies-used)
- [Getting Started](#getting-started)
- [Configuration](#configuration)

## Project Overview

Flatie is a web-based application that simplifies and improves shared living experiences. The backend server, built on .NET 7, is responsible for handling data storage, processing user requests, and facilitating communication between the frontend and the database.

## Features

- User management: Create, update, and authenticate user accounts.
- Home space management: Create, join, and manage different home spaces with assigned roles.
- Task management: Create, assign, and track household tasks within each home space.
- Shopping list: Collaboratively create and manage shopping lists for household items.
- Guest calendar: Schedule and manage guest visits using a shared calendar.
- Notifications: Real-time notifications for important updates and events.
- Chat and messaging: Group chats and private messaging for seamless communication.
- Quiet hours: Allow users to set quiet hours to respect personal space and preferences.
- Home space preferences: Share preferences and allergies with other members.

## Technologies Used

- .NET 7
- Entity Framework Core
- ASP.NET Core Web API
- PostgreSQL
- JSON Web Tokens (JWT) for authentication
- SignalR for real-time communication

## Getting Started

To run the backend server locally, follow these steps:

1. Clone this repository to your local machine.
2. Ensure you have .NET 7 SDK installed on your system.
3. Update the [configuration](#configuration) section with your database connection details and any other necessary configurations.
4. Restore the NuGet packages by running `dotnet restore` in the project root.
5. Build the project by running `dotnet build`.
6. Apply the database migrations by running `dotnet ef database update`.
7. Start the server using `dotnet run` command.

## Configuration

Ensure to set up the necessary configurations for the project. Some of the important configurations include:

- Database connection string: Update the `appsettings.json` file with your SQL Server or preferred database connection details.
- JWT settings: Configure the token expiration time, issuer, and audience for authentication purposes.

Thank you for your interest in Flatie, the Collaborative Home Management Platform! Please note that the project is currently in progress, and I appreciate your understanding as I continue to work on it. If you have any questions or need further assistance, please don't hesitate to reach out to me. Happy coding!
