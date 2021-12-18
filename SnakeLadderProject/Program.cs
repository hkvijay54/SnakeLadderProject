using System;
/// The Player then checks for a Option.
/// They are No Play,Ladder or Snake.


class Program
{
    
    static void Main(string[] args)
    {
        int Position = 0;
        int i = 0;
        string[] choice = { "no play", "ladder", "Snake" };
        Random random = new Random();
        
        while(i<=100)
        {
            int dice = random.Next(1, 6);
            int randnum = random.Next(choice.Length);
            if (choice[randnum] == "no play")
            {
                Console.WriteLine("No play for you, next round");
                Console.WriteLine("------------------------------");
                Position = Position + 0;
            }
            else if (choice[randnum] == "ladder")
            {
                Console.WriteLine("you got ladder "+ dice + "incremented");
               
                if(Position == 100)
                {
                    Console.WriteLine("Payer won" + Position);
                    break;
                }
                else
                {
                    Position = Position + dice;
                    Console.WriteLine(Position);
                }
            }
            else
            {
                if (Position-dice <= 0)
                {
                    Console.WriteLine("Reached 0 . Restart the game");
                    i = 0;
                }
                else
                {
                    Console.WriteLine("you got snake " + dice + "decremented");
                    Position = Position - dice;
                    Console.WriteLine(Position);
                }

            }
        }
    }
}