using System;

class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Hi Badger");
        
        // Print a random prime number greater than 10000
        int randomPrime = GetRandomPrimeGreaterThan10000();
        Console.WriteLine($"Random prime number: {randomPrime}");
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
}
