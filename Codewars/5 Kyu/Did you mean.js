function Dictionary(words) {
  this.words = words;
}

Dictionary.prototype.findMostSimilar = function(term) {
  let lowestCostVal, lowestCostWord, cost;

  this.words.forEach(word => {
    let longest, shortest;
    if (term.length > word.length){
        longest = term;
        shortest = word;
    } else {
        longest = word;
        shortest = term;
    }

   //rows
    let table = [[]];
    for (var i = 0; i <= longest.length; i++) {
      table[0][i] = i;
    }

     //columns
    for (var i = 0; i <= shortest.length; i++) {
      table.push([i]);
    }
    
    for (var nRow = 1; nRow <= shortest.length; nRow++) {
      for (var nCol = 1; nCol <= longest.length; nCol++) {
        table[nRow][nCol] = (function() {                   
                              if (longest[nRow] == shortest[nCol]) {
                                return table[nRow-1][nCol-1];
        
                              } else {
                                return (Math.min(table[nRow-1][nCol-1], table[nRow][nCol-1], table[nRow-1][nCol])) + 1;
                              }
                            })();
      }
    }

    cost = table[shortest.length][longest.length]
    if (lowestCostVal === undefined) {
      lowestCostVal = cost;
      lowestCostWord = word;
    }
    else if (lowestCostVal > cost) { 
      lowestCostVal = cost;
      lowestCostWord = word;
      
    }
    
  })
  return lowestCostWord;

}

//https://www.codewars.com/kata/5259510fc76e59579e0009d4
