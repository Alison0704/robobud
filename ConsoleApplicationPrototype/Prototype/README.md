# Console Prototype - Robot Pet : RoboBud

Build a console application where a robotic pet prompts the user to feed or play based on its status levels, which also determine whether it complies with one of two separate tasks.

## Features
### Emotional state level
* Happiness Level - Must play if low, else it will not comply to task.

### Games
* Play Guessing Game
* `[Later]`Agressive Petting Time

### Tasks
* Show current time
* Pomodoro timer - Time set 25min

## Architecture

```text
Console Interface → Business Logic Layer → Data Access Layer → Database
```
## Idea Breakdown

The user should be able to:
- select a game to play with RoboBud
- view the happiness level of RoboBud
- select a task to Robobud

Robobud needs:
- Happiness Level
- Age(in terms of days)

Service:
- Count down timer 
- Current time Provider

Notes:
- Robobud may refuse to do task if happiness level is lower than 30%
- Model: What does an expense look like?
- Repository: Where are expenses stored?
- Service: What operations and rules exist?
- UI: How does the user interact with the program?
- Program: How are the objects connected?