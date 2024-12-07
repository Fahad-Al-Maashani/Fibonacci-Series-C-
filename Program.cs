using System;

class Fibonacci
{
    static void Main()
    {
        int n = 10;  // The number of terms you want to display
        int firstTerm = 0, secondTerm = 1, nextTerm;

        Console.WriteLine("Fibonacci Series:");

        // Loop to generate Fibonacci numbers
        for (int i = 1; i <= n; ++i)
        {
            if (i == 1)
            {
                Console.Write(firstTerm + " ");
                continue;
            }
            if (i == 2)
            {
                Console.Write(secondTerm + " ");
                continue;
            }
            nextTerm = firstTerm + secondTerm;
            firstTerm = secondTerm;
            secondTerm = nextTerm;

            Console.Write(nextTerm + " ");
        }
    }
}
