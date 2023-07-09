function high(x){
  // ascii code starts at 97 for a, therefore offest is 96.
 const offset = 96;
 let wordArray = x.toLowerCase().split(' ')
  let highestScore = 0;
  let highestScoreString = '';
  for (let word of wordArray) {
    let score = 0;
    for (let char of word) {
      score += char.charCodeAt(0) - offset;
    }
    if (score > highestScore) {
      highestScore = score;
      highestScoreString = word;
    }
  }
  
  return highestScoreString;
}

//https://www.codewars.com/kata/57eb8fcdf670e99d9b000272