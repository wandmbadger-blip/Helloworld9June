using System;
using System.Collections.Generic;

class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Hi Badger");
        
        string continueChoice = "go again";
        
        while (continueChoice.ToLower() != "exit")
        {
            // Print a random prime number greater than 10000
            int randomPrime = GetRandomPrimeGreaterThan10000();
            Console.WriteLine($"Random prime number: {randomPrime}");
            
            // Calculate and print the square root
            double squareRoot = Math.Sqrt(randomPrime);
            Console.WriteLine($"Here is its square root: {squareRoot:F2}");
            
            // Print a random 7-letter word
            string randomWord = GetRandom7LetterWord();
            Console.WriteLine($"Random word: {randomWord}");
            
            // Ask user to continue or exit
            Console.WriteLine("\nWould you like to 'go again' or 'exit'?");
            continueChoice = Console.ReadLine();
            Console.WriteLine();
        }
        
        Console.WriteLine("Thank you for using the program!");
    }
    
    static int GetRandomPrimeGreaterThan10000()
    {
        Random random = new Random();
        int candidate;
        
        while (true)
        {
            // Generate a random number between 10001 and 100000
            candidate = random.Next(10001, 100000);
            
            if (IsPrime(candidate))
            {
                return candidate;
            }
        }
    }
    
    static bool IsPrime(int number)
    {
        if (number < 2)
            return false;
        
        if (number == 2)
            return true;
        
        if (number % 2 == 0)
            return false;
        
        // Check for divisors up to the square root of the number
        for (int i = 3; i <= Math.Sqrt(number); i += 2)
        {
            if (number % i == 0)
                return false;
        }
        
        return true;
    }
    
    static string GetRandom7LetterWord()
    {
        List<string> words = new List<string>
        {
            "Badgers",
            "Console",
            "Numbers",
            "Program",
            "Compile",
            "Testing",
            "Happens",
            "Quality",
            "Respect",
            "Amazing",
            "Perfect",
            "Welcome",
            "Crystal",
            "Thunder",
            "Sunrise",
            "History",
            "Journey",
            "Kingdom",
            "Liberty",
            "Machine"
        };
        
        Random random = new Random();
        return words[random.Next(words.Count)];
    }
}
