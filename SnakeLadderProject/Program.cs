using System;
/// The Player rolls the die to get a number 
/// between 1 to 6.

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int dice = random.Next(1, 6);
        Console.WriteLine("dice rolled = " + dice);
    }
}