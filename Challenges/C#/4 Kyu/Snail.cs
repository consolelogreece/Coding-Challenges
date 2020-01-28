using System.Collections.Generic;

public class SnailSolution
{
    public enum direction {up, right, down, left};
    public static int[] Snail(int[][] array)
    {
            var snail = new List<int>(array[0]);
            var dir = direction.down;
            var topBound = 1;
            var bottomBound = array.Length;
            var leftBound = 0;
            var rightBound = array[0].Length;

            while(topBound != bottomBound && leftBound != rightBound)
            {
                switch(dir)
                {
                    case direction.down:
                        snail.AddRange(getTopDown(array, topBound, bottomBound, rightBound));
                        rightBound--;
                        dir = direction.left;
                        break;

                    case direction.left:
                        snail.AddRange(getRightLeft(array, rightBound, leftBound, bottomBound));
                        bottomBound--;
                        dir = direction.up;
                        break;

                    case direction.up:
                        snail.AddRange(getBottomUp(array, topBound, bottomBound, rightBound));
                        leftBound++;
                        dir = direction.right;
                        break;

                    case direction.right:
                        snail.AddRange(getLeftRight(array, rightBound, leftBound, bottomBound));
                        topBound++;
                        dir = direction.down;
                        break;
                }
            }

        return snail.ToArray();
    }
    private static int[] getTopDown(int[][] array, int topBound, int bottomBound, int rightBound) => getVertical(array, topBound, bottomBound, rightBound - 1).ToArray();

    private static int[] getBottomUp(int[][] array, int topBound, int bottomBound, int rightBound)
    {  
        var arr = getVertical(array, topBound, bottomBound,  array[0].Length - rightBound - 1);

        arr.Reverse();

        return arr.ToArray();
    }

    private static List<int> getVertical(int[][] array, int topBound, int bottomBound, int col)
    {
        var arr = new List<int>();

        for(int i = topBound; i < bottomBound; i++) arr.Add(array[i][col]);
        
        return arr;
    }

    public static int[] getRightLeft(int[][] array, int rightBound, int leftBound, int bottomBound)
    {
        var arr = getHorizontal(array, rightBound, leftBound, bottomBound - 1);

        arr.Reverse();

        return arr.ToArray();
    }

    private static int[] getLeftRight(int[][] array, int rightBound, int leftBound, int bottomBound) => getHorizontal(array, rightBound, leftBound, array.Length - bottomBound).ToArray();
    
    private static List<int> getHorizontal(int[][] array, int rightBound, int leftBound, int row)
    {
        var arr = new List<int>();

        for(int i = leftBound; i < rightBound; i++) arr.Add(array[row][i]);
        
        return arr;
    }
}

// https://www.codewars.com/kata/521c2db8ddc89b9b7a0000c1