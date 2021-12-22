using System;


class Program
{
    public static int curpostion = 0;
    static Boolean playerTurn = true;

    public static int dieRollPlay(int position, string Player)
    {
        const int NO_PLAY = 0;
        const int LADDER = 1;
        const int SNAKE = 2;

        Random rand = new Random();
        int diceNumber = rand.Next(1, 7);
        int playOption = rand.Next(0, 3);
        switch (playOption)
        {
            case NO_PLAY:
                break;
            case LADDER:
                position = position + diceNumber;
                if (position != 100)
                {
                    dieRollPlay(position, Player);
                }
                break;
            case SNAKE:
                position = position - diceNumber;
                if (position < 0)
                {
                    position = 0;
                }
                break;

        }
        Console.WriteLine("Position of Player {0} : {1}", Player, position);
        return position;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("----Snake & Ladder Game----");
        int postionPlayer1 = 0;
        int postionPlayer2 = 0;
        int diceRollCount = 0;

        while (postionPlayer1 < 100 && postionPlayer2 < 100)
        {
            diceRollCount++;
            if (playerTurn)
            {
                postionPlayer1 = dieRollPlay(postionPlayer1, "Player1");
            }
            else
            {
                postionPlayer2 = dieRollPlay(postionPlayer2, "Player2");
            }
            playerTurn = !playerTurn;
        }
        if (postionPlayer1 == 100)
        {
            Console.WriteLine("Player1 Wins !");
            Console.WriteLine("Total Nnumber of the dice rolled for Player 1 is: " + diceRollCount);
        }
        else
        {
            Console.WriteLine("Player2 Wins!");
            Console.WriteLine("Total Nnumber of the dice rolled for Player 2 is: " + diceRollCount);
        }
    }
}
