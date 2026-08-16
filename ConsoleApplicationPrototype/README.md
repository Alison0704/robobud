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

## Learning section

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
`Observer` - Observing the current status of both levels in order to change the state. 



