# Robot Pet Assistant : RoboBud

Build a console application where a robotic pet prompts the user to feed or play based on its status levels, which also determine whether it complies with a given task.

## Features

* Level Percentage:
    - Happiness Level - will not comply to task if it did not play
    - Satiated Level - will not comply to task if not fed

* Task:
    - Request the current time
    - Request a pomodoro timer

* Activity
    - Increase `Satiated Level` : Feed with virtual food.
    - Increase `Happiness Level` : Play games.

* Games:
    * Guess my number:
        - `Happiness Level` increase by 10% if guessed correctly after 5 turns.
        - `Happiness Level` increase by 30% if guessed correctly before 5 turns.
        - RoboBud will let user know if it's lower or upper. 
    * More can be added later...

* Status: REFUSE, RELUCTANT, ACCEPT

## Cycle
* Wakes up/Created (BootOnService)
    - State its name and current age
    - State the current Happiness and Hunger Level

* User ask for a task
    - REFUSE: will not do the task
        + Both levels are below 40%
    - RELUCTANT: 50% chance it will not to the task
        + Either one of the levels is below 40%
    - ACCEPT: will always do the task
        + Both levels are above 40%

## Prototype architechture 
```text
Console Interface -> Business Logic Layer -> Data Access Layer -> Database
```

## Initial Technology Stack

* C# Classes and Console App Project
* SQLites Database
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
                       

### Testing tools - NUnits

### Design patterns



