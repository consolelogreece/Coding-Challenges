using System.Collections.Generic;

namespace CodeWars
{
    class Kata
    {

        public static Dictionary<string, double> damagedOrSunk(int[,] board, int[,] attacks)
        {
            int[] shipLengths = new int[] { 0, 0, 0, 0 }, shipHits = new int[] { 0, 0, 0, 0 };

            int boardLen = board.GetLength(0) - 1;

            foreach (int tile in board) shipLengths[tile]++;

            for (int i = 0; i < attacks.GetLength(0); i++)
            {
                int x = attacks[i, 0] - 1;
                int y = attacks[i, 1] - 1;

                // manipulation of y is neccesary here as the challenge creator gave a non-conventional board layout.
                int boardVal = board[boardLen - y, x];
                shipHits[boardVal]++;

            }

            var tracker = new Dictionary<string, double>() { { "sunk", 0 }, { "damaged", 0 }, { "notTouched", 0 }, { "points", 0 } };

            for (int i = 1; i < shipLengths.Length; i++)
            {
                // if length of ship is zero, ship doesn't exist.
                if (shipLengths[i] == 0) continue;

                if (shipLengths[i] <= shipHits[i] && shipHits[i] != 0) { tracker["sunk"]++; tracker["points"]++; }
                else if (shipLengths[i] > shipHits[i] && shipHits[i] > 0) { tracker["damaged"]++; tracker["points"] += 0.5; }
                else { tracker["notTouched"]++; tracker["points"]--; }
            }

            return tracker;
        }
    }
}

//https://www.codewars.com/kata/58d06bfbc43d20767e000074