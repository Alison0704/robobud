# Robot Pet Assistant : RoboBud

A three-tier ASP.NET Core console application prototype for monitoring and managing a robot pet and assistant.</br>
During the initial development phase, robot telemetry is simulated by random values within a range and stored in a database instead of being collected from physical sensors.

## Features

* Monitor simulated battery, temperature, distance, and motor data
* Determine robot state and mood using business rules
* Issue commands such as Explore, Rest, and Charge
* Track activities, interactions, maintenance, and operating costs
* Display robot information through an MVC dashboard
* Support future integration with real sensors and custom ASIC RISC-V Processor Design

## Architecture

- **Presentation Layer:** .NET console menus, user commands, and formatted output
- **Business Logic Layer:** Robot behaviour, state, maintenance, and cost-management services
- **Data Access Layer:** Entity Framework Core repositories and database operations

```text
Console Interface → Business Logic Layer → Data Access Layer → Database
```

## Initial Technology Stack

* C# and Console Project
* Entity Framework Core
* SQL Server
* xUnit and Moq
