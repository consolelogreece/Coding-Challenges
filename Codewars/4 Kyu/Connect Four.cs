using System.Collections.Generic;
using System;

public class ConnectFour
{
    public static string WhoIsWinner(List<string> piecesPositionList)
    {
       var game = new ConnectFourGame();

       return game.WhoIsWinner(piecesPositionList);
    }
}

public class ConnectFourGame
{
    private string[][] _board;

    private int _winThreshold = 4;

    private int _rowCount = 6;

    private int _columnCount = 7;

    private Dictionary<string, int> columns = new Dictionary<string, int>() { { "A", 0 }, { "B", 1 }, { "C", 2 }, { "D", 3 }, { "E", 4 }, { "F", 5 }, { "G", 6 } };

    public string WhoIsWinner(List<string> piecesPositionList)
    {
        InitializeBoard(); 

        foreach (var move in piecesPositionList)
        {
            var info = move.Split('_');

            var col = columns[info[0]];

            var player = info[1];

            var row = FindRow(col);

            if (row > -1)
            {
                //make move
                _board[row][col] = player;

                if (CheckWinner(row, col))
                {         
                    return player;
                }
            }
            else
            {
                    //illegal move
            }
        }

        return "draw";
    }

    private void InitializeBoard()
    {
        _board = new string[6][];

        for (int i = 0; i < 6; i++)
        {
            string[] row = new string[7];
            // assign values to row
            _board[i] = row;
        }
    }

    private int FindRow(int col)
    {   
        int i = -1;
        foreach (var row in _board)
        {
            i++;
            if (row[col] == null)
            {
                return i;
            }
        }

        return -1;
    }

    private bool CheckWinner(int row, int col)
    {
        return CheckVertical(row, col) || CheckHorizontal(row, col) || CheckDiagonalTLBR(row, col) || CheckDiagonalTRBL(row, col);
    }

    private bool CheckVertical(int row, int col)
    {
        int count = 1;

        var player = _board[row][col];

        row--;

        for (; row >= 0; row--)
        {
            if (_board[row][col] == player) count++;
            else break;
        }

        return count >= _winThreshold;
    }

    private bool CheckHorizontal(int row, int col)
    {
        int count = 1;

        var tempCol = col;

        var player = _board[row][col];

        while (++tempCol < _columnCount && _board[row][tempCol] == player) count++;
        
        while (--col >= 0 && _board[row][col] == player) count++;

        return count >= _winThreshold;
    }

    private bool CheckDiagonalTLBR(int row, int col)
    {
        int count = 1;

        var tempCol = col;

        var tempRow = row;

        var player = _board[row][col];

        while (++tempCol < _columnCount && ++tempRow < _rowCount && _board[tempRow][tempCol] == player)count++;
        
        while (--col >= 0 && --row >= 0 && _board[row][col] == player) count++;

        return count >= _winThreshold;
    }

    private bool CheckDiagonalTRBL(int row, int col)
    {
        int count = 1;

        var tempCol = col;

        var tempRow = row;

        var player = _board[row][col];

        while (++tempCol < _columnCount && --tempRow >= 0 && _board[tempRow][tempCol] == player)count++;
        
        while (--col >= 0 && ++row < _rowCount && _board[row][col] == player) count++;

        return count >= _winThreshold;
    }
}

// https://www.codewars.com/kata/56882731514ec3ec3d000009