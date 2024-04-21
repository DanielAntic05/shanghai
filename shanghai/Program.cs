using System;

class ShanghaiGame
{
	private const int N_STICKS = 10;
	private static int[] graph = new int[N_STICKS + 1];


    static bool IsWinningPosition(int sticksLeft)
    {
        if (sticksLeft == 0)
            return false;

        // Controls if the current player can force the opponent into a losing position
        for (int i = 1; i <= 3; i++)
            if (sticksLeft - i >= 0 && graph[sticksLeft - i] == 0)
                return true;

        return false;
    }


    static void Main(string[] args)
    {
        for (int sticksLeft = 1; sticksLeft <= N_STICKS; sticksLeft++)
            for (int i = 1; i <= 3; i++)
                if (sticksLeft - i >= 0 && graph[sticksLeft - i] == 0)
                {
                    graph[sticksLeft] = 1;
                    break;
                }

        if (IsWinningPosition(N_STICKS))
            Console.WriteLine("Player 1 wins!");
        else
            Console.WriteLine("Player 2 wins!");
    }
}