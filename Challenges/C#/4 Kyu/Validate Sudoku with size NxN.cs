using System;
using System.Linq;

class Sudoku
{
  private int[][] data;
  private int sqLength;
  private int nSquaresPerLine;
  
  public Sudoku(int[][] sudokuData)
  {
    this.data = sudokuData;

    this.sqLength = (int)Math.Sqrt(data.Length);  

    this.nSquaresPerLine = (data.Length / sqLength);
  }

  public bool IsValid()
  {    
    if (!IsSodukuFormattedCorrectly()) return false;
    
    bool areRowsValid = AreRowsValid();
    bool areColsValid = AreColsValid();
    bool areSubsquaresValid = AreSubsquaresValid();

    return areColsValid && areColsValid && areSubsquaresValid;
  }
  
  private bool IsSodukuFormattedCorrectly()
  {
    // ensure all rows and cols are same length
    for(int i = 0; i < data.Length; i++)
    {
      if (data[i].Length != data.Length) return false;
    }
  
    var isValidSquare = Math.Sqrt(data.Length) % 1 == 0;

    if (!isValidSquare) return false;

    return true;
  }

  private bool AreSubsquaresValid()
  {
    var nSubSquaresTotal = nSquaresPerLine * nSquaresPerLine;

    for(int i = 0; i < nSubSquaresTotal; i++)
    {
      var square = GetSubsquare(i);

      if (!IsSetValid(square)) return false;
    }

    return true;
  }

  public int[] GetSubsquare(int i)
  {
    int initialRowIndex = (i / nSquaresPerLine) * sqLength;
  
    int initialColIndex = (i % nSquaresPerLine) * sqLength;

    int squareSize = sqLength * sqLength;

    int[] subSquare = new int[squareSize];

    int count = 0;

    for(int row = initialRowIndex; row < initialRowIndex + sqLength; row++)
    {
      for (int col = initialColIndex; col < initialColIndex + sqLength; col++)
      {
        subSquare[count] = data[row][col];

        count++;
      }
    }

    return subSquare;
  }
  
  private bool AreRowsValid() => data.Any(row => IsSetValid(row));

  private bool AreColsValid() 
  {
    for (int i = 0; i < data.Length; i++)
    { 
      int[] col = new int[data.Length];

      for (int j = 0; j < data[i].Length; j++)
      {
        col[j] = data[j][i];
      }

      if (!IsSetValid(col)) return false;
    }

    return true;
  }
  
  private bool IsSetValid(int[] set) 
  {
    bool areAllUnique = set.Length == set.Distinct().Count();

    if (!areAllUnique) return false;

    var upperBound = data.Length;

    bool areAllInsideBounds = set.Any(n => !(n <= 0 || n > upperBound));

    if (!areAllInsideBounds) return false;

    return true;
  } 
}

// https://www.codewars.com/kata/540afbe2dc9f615d5e000425