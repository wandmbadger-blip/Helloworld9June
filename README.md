# Helloworld9June

A simple C# interactive console application that generates random prime numbers and 7-letter words, with square root calculations.

## Features

- **Greets the user** with "Hi Badger"
- **Generates random prime numbers** greater than 10,000 (between 10,001 and 100,000)
- **Calculates square roots** - After each random number, the program calculates and displays its square root
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
3. Calculates and displays the square root of that prime number
4. Selects a random 7-letter word
5. Asks user: "Would you like to 'go again' or 'exit'?"
6. Loop continues until user types "exit"
7. Displays "Thank you for using the program!" before closing

## Random Words List

The program randomly selects from these 7-letter words:
- Badgers, Console, Numbers, Program, Compile, Testing, Happens, Quality, Respect, Amazing, Perfect, Welcome, Crystal, Thunder, Sunrise, History, Journey, Kingdom, Liberty, Machine

## Example Output

```
Hi Badger
Random prime number: 23467
Here is its square root: 153.18

Random word: Crystal

Would you like to 'go again' or 'exit'?
> go again

Random prime number: 89753
Here is its square root: 299.59

Random word: Testing

Would you like to 'go again' or 'exit'?
> exit
Thank you for using the program!
```

## Chat History

This project was developed through an interactive chat session where features were progressively added:
- Initial Hello World program
- Addition of random prime number generation
- Addition of random 7-letter word selection
- Interactive loop with exit functionality
- Square root calculation feature (latest addition)

For detailed information about the development process, see `chat_transcript.md`.
