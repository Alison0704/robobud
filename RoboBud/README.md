# Robot Pet Assistant : RoboBud

Build a console application where a robotic pet prompts the user to feed or play based on its status levels, which also determine whether it complies with a given task.

## Features

* Level Percentage:
    - Happiness Level - will not comply to task if it did not play.
    - Energized Level - will not comply to task if not fed.

* Task:
    - Request the current time
    - Request a pomodoro timer

* Activity
    - Increase `Energized Level` : Feed with virtual food.
    - Increase `Happiness Level` : Play games.

* Games:
    * Guess my number:
        - `Happiness Level` increase by 10% if guessed correctly after 5 turns.
        - `Happiness Level` increase by 30% if guessed correctly before 5 turns.
        - RoboBud will let user know if it's lower or upper. 
    * More can be added later...

* Feeding :
    * Use the enter key till user feeds RoboBud as much as they want.
        - By pressing 'SpaceBar'
    * `[LaterAddition]` Play more game to get more food resources.
    * See the Energy Bar go up, but not over 100%.

* Status: REFUSE, RELUCTANT, ACCEPT

## Cycle
* Creation
    - Reset the content in database
    - Ask for name
    - Both levels are at 100%

* Boot up
    - State its name.
    - State the current Happiness and Energy Level
    - Based on the saved timed on Program exit and the boot up time, 0.2*{difference in minutes} is deducted from both levels.

* Task Request
    - REFUSE: will not do the task
        + Both levels are below 40%
    - RELUCTANT: 50% chance it will not do the task
        + Either one of the levels is below 40%
    - ACCEPT: will always do the task
        + Both levels are above 40%

## Initial Technology Stack

* C# Classes and Console App Project
* SQLite Database
* NUnit

## Folder Organization
- BLL — Contains the application's business rules and decision-making logic.
- Controller — Receives user actions from the View and coordinates calls to the BLL.
- Core — Contains shared contracts, interfaces, and types used across DAL and BLL.
    - BLL and DAL can both depend on Core, while Core should remain independent and not depend on or directly modify BLL or DAL.
- DAL — Handles retrieving, storing, and updating data through the database.
- Database — Permanently stores the application's data.
- Tests — Verifies that the application's components behave as expected.
- View — Displays information to the user and collects user input.

## Project Phases

### `Phase1:` Database and DAL implementation

- Designed the SQLite schema for `Robot` and `RobotLevel`, including name, timestamps, and percentage-based `HAPPY`/`ENERGIZED` levels.
- Documented the status logic for `REFUSE`, `RELUCTANT`, and `ACCEPT` based on happiness and energy thresholds.
- Captured the game requirements for number guessing and planned future extensibility for additional games.
- Added a learning log for NUnit setup, test lifecycle, and organization patterns used in the project.
- Recorded the planned design approach using a Singleton pattern for the active app instance and a future Factory pattern for game creation.
- Identified the next implementation steps: database normalization, table creation, object mapping, and DAL development.

## Learning section

### Database and DAL creation
The following attributes has been distrilled down to the following based on the requirements listed above.
```
CREATE TABLE Robot(
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Name TEXT NOT NULL,
    CreatedAt TEXT NOT NULL DEFAULT (datetime('now')),
    UpdatedAt TEXT NOT NULL DEFAULT (datetime('now'))); 

CREATE TABLE RobotLevel(
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    RobotId INTEGER NOT NULL,
    Type TEXT NOT NULL CHECK(Type IN ('HAPPY', 'ENERGIZED')),
    Percentage INTEGER NOT NULL CHECK(Percentage BETWEEN 0 AND 100),
    FOREIGN KEY (RobotId) REFERENCES Robot(Id));
```

### NUnit
Since this is the first time I am using NUnits, I want to log down what I have learn.

- `[SetUp]` tells NUnit to execute this method before every test case.
- `[Test]`  marks this method as an individual NUnit test.
- `[TestCase]` allows one test method to run multiple times with different inputs.
- `[OneTimeSetUp]` — runs once before all tests in the test class.
- `[TearDown]` — runs after every test case, commonly for cleanup.
- `[OneTimeTearDown]` — runs once after every test in the class has finished.

### NUnit - Organisation
- `[TestFixture]` — marks a class as an NUnit test class.
- `[Category("Name")]` — groups tests, such as Unit, Integration, or Database.
- `[Description("...")]` — documents what a test verifies.
- `[Order(1)]` — controls test execution order, although independent tests are preferred.

## Design patterns
`Singleton` - Since RoboBud should have only one active instance while the application is running, the Singleton pattern prevents the application from creating another instance when one already exists. </br> 
`[LaterAdditions]` `Factory` – As more games are added, the factory centralizes their creation and setup. The program only provides the user’s selected game type and receives the appropriate game service.

## TODO
Todo: 
TODO Design database and normalize (Check ACID Database)
TODO Create Tables
TODO Create Object in DAL (Table Name = Object Name / Table Column = Object Attribute)
TODO Create DAL per object




