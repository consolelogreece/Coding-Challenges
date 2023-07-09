public class Matrix
{
  public static int Determinant(int[][] matrix)
  {
    int N = matrix.GetLength(0);
    if (N == 1) return matrix[0][0];
    else if (N == 2) return (matrix[0][0] * matrix[1][1]) - (matrix[0][1] * matrix[1][0]);
    else
    {
      int det = 0;
      
      // As the formula alternatives between adding and subtracting, the value will be multipied by it, 
      // and then this flag will be flipped (so alternating between +1 and -1), providing the desired behaviour.
      int multFlag = 1; 

      for (int i = 0; i < N; i++)
      {
          // Value the determinant of the respective submatrix is multiplied by.
          int detMultFactor = matrix[0][i]; 

          // Create subatrix of N-1 by N-1
          int[][] subMatrix = new int[N-1][];
          for (int j = 0; j < N-1; j++) subMatrix[j] = new int[N-1];

          // Always ignore first as this is the row used to multiply the following determinants.
          for (int row = 1; row < N; row++)
          {
              int currCol = 0;
              for (int col = 0; col < N; col++)
              {
                  // Same column as number determinant is multiplied by, so ignore.
                  if (col == i) continue;
                  subMatrix[row-1][currCol] = matrix[row][col];
                  currCol++;
              }
          }

          // Tally recursively
          det += multFlag * (detMultFactor * Determinant(subMatrix));

          multFlag *= -1;
      }

      return det;
    }      
  }
}

// https://www.codewars.com/kata/52a382ee44408cea2500074c