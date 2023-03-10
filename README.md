# sumUntilOk
A simple C# project that asks for an integer until "ok" is entered, then returns the sum.
## Running
```
dotnet build
dotnet run
```
## Process
* Starts a while loop
* Asks for an integer or "ok"
* if input is an integer then adds integer to the sum and restarts the loop
* if input value is "ok" then breaks from the loop
* returns the sum of all integers

## Output
```
Enter a number or "ok" to exit:
5
Enter a number or "ok" to exit:
5
Enter a number or "ok" to exit:
4
Enter a number or "ok" to exit:
6
Enter a number or "ok" to exit:
ok
the sum of all numbers is 20
```
