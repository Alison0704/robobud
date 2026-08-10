# Robot Pet Assistant : RoboBud

A three-tier ASP.NET Core MVC application for monitoring and managing a robot pet and assistant. During the initial development phase, robot telemetry is simulated by random values within a range and stored in a database instead of being collected from physical sensors.

## Features

* Monitor simulated battery, temperature, distance, and motor data
* Determine robot state and mood using business rules
* Issue commands such as Explore, Rest, and Charge
* Track activities, interactions, maintenance, and operating costs
* Display robot information through an MVC dashboard
* Support future integration with real sensors and custom ASIC RISC-V Processor Design

## Architecture

* **Presentation:** ASP.NET Core MVC controllers, views, and view models
* **Business Logic:** Robot state, mood, maintenance, and cost services
* **Data Access:** Entity Framework Core repositories and database operations

```text
MVC Web Application → Business Logic Layer → Data Access Layer → Database
```

## Project Structure

```text
RobotPet.Web
RobotPet.BL
RobotPet.DAL
RobotPet.Tests
```

## Initial Technology Stack

* C# and ASP.NET Core MVC
* Entity Framework Core
* SQL Server
* xUnit and Moq
