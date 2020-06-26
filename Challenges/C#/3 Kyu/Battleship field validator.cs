namespace Solution {
  using System;
  using System.Collections.Generic;
  using System.Linq;
  
  public class BattleshipField 
  {
    public static bool ValidateBattlefield(int [,] field) 
    {
      var x = new BattleshipValidator(field);
      return x.ValidateBattlefield();
    }
  }

  public class BattleshipValidator
  {
    private int[,] Field;
  
    private int SideLength = 10;
    
    private enum ShipDirection {none, horizontal, vertical, both};
    
    public BattleshipValidator(int[,] field)
    {
      Field = field;
    }
     public bool ValidateBattlefield() 
     {
      List<int> shipLengths = new List<int>();
  
      for(int row = 0; row < SideLength; row++)
      {
        for(int col = 0; col < SideLength; col++)
        {
          if (Field[row, col] == 1)
          {
            var shipLength = handle(row, col);
  
            // illegal layout
            if (shipLength == -1) return false;
  
            shipLengths.Add(shipLength);
          }
        }
      }
    
      return AreShipNumbersValid(shipLengths);
    }
  
    private bool AreShipNumbersValid(List<int> shipLengths)
    {
      var submarineTotRequire = 4;
      var submarineLength = 1;
  
      var battleshipTotRequire = 1;
      var battleshipLength = 4;
  
      var cruiserTotRequire = 2;
      var cruiserLength = 3;
  
      var destroyerTotRequire = 2;
      var destroyerLength = 3;
  
      var subsValid = shipLengths.Where(s => s == submarineLength).Count() == submarineTotRequire;
      var battleshipValid = shipLengths.Where(s => s == battleshipLength).Count() == battleshipTotRequire;
      var cruiserValid = shipLengths.Where(s => s == cruiserLength).Count() == cruiserTotRequire;
      var destroyerValid = shipLengths.Where(s => s == destroyerLength).Count() == destroyerTotRequire;
  
      return subsValid && battleshipValid && cruiserValid && destroyerValid;
    }
  
    private int handle(int row, int col)
    {
      var sDir = GetDirection(row, col);
  
      // ships next to eachother, illegal.
      if (sDir == ShipDirection.both) return -1;
      
      var shipLength = (sDir == ShipDirection.horizontal ? HandleHorizontal(row, col) : HandleVertical(row, col));
  
      return shipLength;
    }
  
    private int HandleVertical(int row, int col)
    {
      int length = 0;
      
      while (row < SideLength)
      {
        var sqVal = Field[row, col];
  
        if (sqVal == 0) break;
        else if (sqVal == 1)
        {
           if (AreSquaresAdjacentHorizontallyOccupied(row, col) || AreSquaresAdjacentDiagonallyOccupied(row, col)) return -1;
           length++;
           Field[row, col] = 2;
        }
        //illegal, for instance the value could be 2, meaning next to a ship.
        else return -1;
  
        row++;
      }
  
      return length;
    }
  
    private int HandleHorizontal(int row, int col)
    {
      int length = 0;
      
      while (col < SideLength)
      {
        var sqVal = Field[row, col];
  
        if (sqVal == 0) break;
        else if (sqVal == 1)
        {
          if (AreSquaresAdjacentVerticallyOccupied(row, col) || AreSquaresAdjacentDiagonallyOccupied(row, col)) return -1;
          length++;
          Field[row, col] = 2;
        }
        //illegal, for instance the value could be 2, meaning next to a ship.
        else return -1;
  
        col++;  
      }
  
      return length;
    }
  
    private bool AreSquaresAdjacentVerticallyOccupied(int row, int col)
    {
      if(row > 0)
      {
        if (Field[row - 1, col] != 0) return true;
      }
      if (row < SideLength - 1)
      {
        if (Field[row + 1, col] != 0) return true;
      }
  
      return false;
    }
    private bool AreSquaresAdjacentHorizontallyOccupied(int row, int col)
    {
      if(col > 0)
      {
        if (Field[row, col - 1] != 0) return true;
      }
      if (row < SideLength - 1)
      {
        if (Field[row, col + 1] != 0) return true;
      }
  
      return false;
    }
    
    private bool AreSquaresAdjacentDiagonallyOccupied(int row, int col)
    {
      if (row > 0)
      {
        if(col > 0)
        {
          if (Field[row - 1, col - 1] != 0) return true;
        }
        if (col < SideLength - 1)
        {
          if (Field[row - 1, col + 1] != 0) return true;
        }
      }
      if (row < SideLength - 1)
      {
        if(col > 0)
        {
          if (Field[row + 1, col - 1] != 0) return true;
        }
        if (col < SideLength - 1)
        {
          if (Field[row + 1, col + 1] != 0) return true;
        }
      }
  
      return false;
    }
  
    private ShipDirection GetDirection(int row, int col)
    {
      bool vert = false;
      bool hori = false;
      if (row + 1 < SideLength && Field[row + 1, col] != 0) vert = true;
      if (col + 1 < SideLength && Field[row, col + 1] != 0) hori = true;
  
      if (hori && vert) return ShipDirection.both;
      else if (hori) return ShipDirection.horizontal;
      else if (vert) return ShipDirection.vertical;
      else return ShipDirection.none;
    }
  }
}

// https://www.codewars.com/kata/52bb6539a4cf1b12d90005b7