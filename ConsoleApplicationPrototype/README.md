# Robot Pet Assistant : RoboBud

Build a console application where a robotic pet prompts the user to feed or play based on its status levels, which also determine whether it complies with a given task.

## Features

* Happiness Level - will not comply to task if it did not play
* Satiated Level - will not comply to task if not fed

* Task:
    - Request the current time
    - Request a pomodoro timer

* Activity
    - Increase `Satiated Level` : Feed using a feeder machine.
    - Increase `Happiness Level` : Play games

* Games: 
    * Guess my number:
        - `Happiness Level` increase by 10% if guessed wrong after 5 turns.
        - `Happiness Level` increase by 30% if guessed correctly.
        - RoboBud will let user know if it's lower or upper. 

## Cycle
* Wakes up/Created
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
* NUnits

## Test cases
* Pet refuses task when hunger above threshold.
* Pet refuses task when happiness below threshold.
* Feeding changes hunger and persists state once.
* Playing changes happiness and persists state once.
* Time request returns value from injected time provider.
* Pomodoro task starts only when compliance conditions are met.

## Info Section

### Testing tools - NUnits

### Design patterns



