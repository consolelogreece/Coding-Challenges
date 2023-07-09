function validSolution(board){
   for (var i = 0; i < 9; i++) {

      //////////////////////////////////////////////////////// check each row ///////////////////////////////////////////////////////
      let digitCountRowObj = {'1':0, '2':0, '3':0, '4':0, '5':0, '6':0, '7':0, '8':0, '9':0};                                      //
      for (var j = 1; j <= 9; j++ ) {                                                                                              //
        if (digitCountRowObj[board[i][j]] > 0 || board[i][j] === 0 ) return false;                                                 //
        else digitCountRowObj[board[i][j]]++                                                                                       //
      ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //////////////////////////////////////////////////////// check each column //////////////////////////////////////////////////
        let digitCountColObj = {'1':0, '2':0, '3':0, '4':0, '5':0, '6':0, '7':0, '8':0, '9':0};                                    //
        for (var k = 0; k < 9; k++ ) {                                                                                             //
          if (digitCountColObj[board[k][i]] > 0 || board[k][i] === 0 ) return false;                                               //
          else digitCountColObj[board[k][i]]++                                                                                     //
        }                                                                                                                          //
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
      }
   }

     //////////////////////////////////////////////////////// check each 3x3 square /////////////////////////////////////////////////
    for (var i = 0; i < 9; i +=3 ){                                                                                                //
        for (var k = 0; k < 9; k +=3) {                                                                                            //
          let digitCountSquareObj = {'1':0, '2':0, '3':0, '4':0, '5':0, '6':0, '7':0, '8':0, '9':0};                               //
                                                                                                                                   //  
          if (digitCountSquareObj[board[i][k]] > 0 || board[i][k] === 0 ) return false;                                            //
          else digitCountSquareObj[board[i][k]]++;                                                                                 //
                                                                                                                                   //
          if (digitCountSquareObj[board[i][k+1]] > 0 || board[i][k+1] === 0 ) return false;                                        //
          else digitCountSquareObj[board[i][k+1]]++;                                                                               //
                                                                                                                                   //
          if (digitCountSquareObj[board[i][k+2]] > 0 || board[i][k+2] === 0 ) return false;                                        //
          else digitCountSquareObj[board[i][k+2]]++;                                                                               //
                                                                                                                                   //
          if (digitCountSquareObj[board[i+1][k]] > 0 || board[i+1][k] === 0 ) return false;                                        //
          else digitCountSquareObj[board[i+1][k]]++;                                                                               //
                                                                                                                                   //
          if (digitCountSquareObj[board[i+1][k+1]] > 0 || board[i+1][k+1] === 0 ) return false;                                    //
          else digitCountSquareObj[board[i+1][k+1]]++;                                                                             //
                                                                                                                                   //
          if (digitCountSquareObj[board[i+1][k+2]] > 0 || board[i+1][k+2] === 0 ) return false;                                    //
          else digitCountSquareObj[board[i+1][k+2]]++;                                                                             //
                                                                                                                                   //
          if (digitCountSquareObj[board[i+2][k]] > 0 || board[i+2][k] === 0 ) return false;                                        //
          else digitCountSquareObj[board[i+2][k]]++;                                                                               //
                                                                                                                                   //
          if (digitCountSquareObj[board[i+2][k+1]] > 0 || board[i+2][k+1] === 0 ) return false;                                    //
          else digitCountSquareObj[board[i+2][k+1]]++;                                                                             //
                                                                                                                                   //
          if (digitCountSquareObj[board[i+2][k+2]] > 0 || board[i+2][k+2] === 0 ) return false;                                    //
          else digitCountSquareObj[board[i+2][k+2]]++;                                                                             //
        }                                                                                                                          //
    }                                                                                                                              //
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    return true;
}

//https://www.codewars.com/kata/529bf0e9bdf7657179000008