using System;
/// The Player then checks for a Option.
/// They are No Play,Ladder or Snake.


class Program
{

    static void Main(string[] args)
    {
        int Position = 0;
        int i = 0;

        Random random = new Random();

        while (i <= 100)
        {
            int dice = random.Next(1, 6);
            Console.WriteLine("dice rolled and got = " + dice);
            Console.WriteLine("Current you are in " + Position);
            if (Position == 100)
            {
                Console.WriteLine("Game Won" + Position);
                break;
            }
            else if (Position + dice > 100)
            {
                Console.WriteLine("Not possible move");
                Position = Position + 0;
                i++;
            }
            else
            {
                Position = Position + dice;
                Console.WriteLine("The Position Now " + Position);
                i++;
            }

        }
        Console.WriteLine("num " + i);
    }
}