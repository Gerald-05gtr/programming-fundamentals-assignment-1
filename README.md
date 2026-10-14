# Assignment 1 — Review of Programming Fundamentals

Three console exercises, implemented in **Python** and **C#** with a menu in each language.

## Tasks

1. **Two-number calculator:** addition, subtraction, multiplication and division using `if/elif` or `if/else`.
2. **Temperature converter:** Celsius ↔ Fahrenheit with conditional statements.
3. **Student grade average:** read N grades using `for`, calculate average and pass for average >= 3.0.

Both applications validate invalid entries and guard against division by zero. Grades must be from 1 to 6.

## Run Python

From this repository's root directory:

```bash
python python/main.py
```

On Windows, `py python/main.py` is an alternative.

## Run C#

Install the .NET 8 SDK or newer, then from the repository's root directory:

```bash
dotnet run --project csharp/ProgrammingFundamentals.csproj
```

## Sample tests

| Task | Input sequence | Expected output |
| --- | --- | --- |
| Calculator | menu `1`, `10`, `20`, `+` | `Result: 30` |
| Calculator | menu `1`, `10`, `0`, `/` | `Error: Cannot divide by zero.` |
| Converter | menu `2`, `C`, `0` | `0°C = 32°F` |
| Converter | menu `2`, `F`, `32` | `32°F = 0°C` |
| Grades | menu `3`, `4`, `5`, `3`, `4`, `2` | `Average: 3.50`, `The student passed.` |
| Grades | menu `3`, `2`, `2`, `3` | `Average: 2.50`, `The student failed.` |

## Branches and Git history

For the **branch-use assessment criterion**, create meaningful branches in your actual Git repository as you develop or review the project, for example:

- `feature/python-tasks`
- `feature/csharp-tasks`
- `docs/readme`

Commit changes on each branch and merge those branches into `main`. **Simply naming branches without commits does not demonstrate a Git workflow.** See instructions below for example commands.

## Submission

Submit your own public GitHub repository URL, for example:

`https://github.com/YOUR-USERNAME/programming-fundamentals-assignment-1`

The sample URL above is not a real repository. Create your repository and replace it with its actual URL.
## Python Exercises

The Python console application contains three tasks:

1. Calculator — performs addition, subtraction,
   multiplication and division.
2. Temperature converter — converts between
   Celsius and Fahrenheit.
3. Student grade average — calculates the
   average grade and checks whether the
   student has passed.

Run the program using:

python python/main.py