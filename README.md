# Helloworld9June

A simple C# interactive console application that generates random prime numbers and 7-letter words.

## Features

- **Greets the user** with "Hi Badger"
- **Generates random prime numbers** greater than 10,000 (between 10,001 and 100,000)
- **Selects random 7-letter words** from a predefined list
- **Interactive loop** - Users can choose to generate new numbers/words or exit
- **User-friendly prompts** - The program asks users if they want to "go again" or "exit"

## How to Run

1. Clone the repository
2. Compile the C# program:
   ```bash
   csc HelloWorld.cs
   ```
3. Run the executable:
   ```bash
   HelloWorld.exe
   ```

## Program Flow

1. Program starts with "Hi Badger" greeting
2. Generates a random prime number > 10,000
3. Selects a random 7-letter word
4. Asks user: "Would you like to 'go again' or 'exit'?"
5. Loop continues until user types "exit"
6. Displays "Thank you for using the program!" before closing

## Random Words List

The program randomly selects from these 7-letter words:
- Badgers, Console, Numbers, Program, Compile, Testing, Happens, Quality, Respect, Amazing, Perfect, Welcome, Crystal, Thunder, Sunrise, History, Journey, Kingdom, Liberty, Machine

## Example Output

```
Hi Badger
Random prime number: 23467
Random word: Crystal

Would you like to 'go again' or 'exit'?
> go again

Random prime number: 89753
Random word: Testing

Would you like to 'go again' or 'exit'?
> exit
Thank you for using the program!
```
