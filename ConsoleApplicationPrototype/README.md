# Robot Pet Assistant : RoboBud

Build a console application where a robotic pet prompts the user to feed or play based on its status levels, which also determine whether it complies with one of two separate tasks.

## Features

* Happiness Level - will not comply to task if it did not play
* Satiated Level - will not comply to task if not fed

* Task:
    - Request the current time
    - Request a pomodoro timer

## Cycle

* Wakes up/Created
    - State its name and current age
    - State the current Happiness and Hunger Level

* User ask for a task
    - REFUSE: will not do the task
    - RELUCTANT: 50% chance it will not to the task
    - ACCEPT: will always do the task

* Activity
    - Increase `Satiated Level` : Feed using a feeder machine.
    - Increase `Happiness Level` : Play the `guess my number` game.

* Guess my number:
    - `Happiness Level` increase by 10% if guessed wrong after 5 turns.
    - `Happiness Level` increase by 30% if guessed correctly.
    - RoboBud will let user know if it's lower or upper.

```text
Console Interface → Business Logic Layer → Data Access Layer → Database
```

## Initial Technology Stack

* C# and Console Project
* Entity Framework Core
* SQL Server
* xUnit and Moq

## Test cases
* Pet refuses task when hunger above threshold.
* Pet refuses task when happiness below threshold.
* Feeding changes hunger and persists state once.
* Playing changes happiness and persists state once.
* Time request returns value from injected time provider.
* Pomodoro task starts only when compliance conditions are met.

## Info Section

### How xUnit helps

1 - Validates the robot pet rules
* Test that RoboBud refuses tasks when satiated is low or happiness is low.
* Test that feeding increases hunger status correctly.
* Test that playing increases happiness correctly.

2 - Protects business logic as features grow
* As more commands or statuses are added, tests catch regressions immediately.
* Refactor with confidence because behavior is locked by tests.

3 - Supports layered testing
* Unit tests for Core and BLL rules.
* Integration-style tests for DAL interactions.

### How Moq helps

1 - Isolates Business Logic from Data Access
* Mock repository interfaces so BLL tests do not need SQL Server running.
* Focus each test on decision logic, not infrastructure.

2 - Controls edge cases easily
* Simulate missing pet records, failed saves, or unusual status values.
* Simulate time-based behavior (current time and pomodoro) with fake clock services.

3 - Verifies side effects
* Confirm methods like SaveState or UpdatePet are called when expected.
* Confirm they are not called when RoboBud refuses a task.

## Places to use them

`Core`: Pure rule tests with xUnit only (no Moq needed).
`BLL`: xUnit + Moq to test behavior against mocked DAL/services.
`Console` : Keep minimal logic there since testable logic should stay in BLL/Core.

## Design patterns



