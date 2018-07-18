function sumOfDivided(lst) {
  //sort list,
  lst.sort((a, b) => a - b) 
    console.log(lst)

  // find largest possible number that could work, so not doing more work than necessary.
  const maxPrimeOverall = function(){
    if (lst[lst.length - 1] <= 0) {
      // if the above condition is true, the last element in the array will actually be the smallest when converted to positive. 
      // So get first val, then convert to positive with *-1
      return lst[0] * -1 
    } else {
      return lst[lst.length - 1] 
    }
  }()
  
  
  // array to be returned
  let returnArr = [];
  
  // keeps track of sum
  let sum;

  // current integer in array being tested
  let int;
  
  // only add results to the array if this is true.
  let isAtleastOne;
  
  for (let i = 2; i < maxPrimeOverall; i++) {
    isAtleastOne = false;
    sum = 0;
    if (isPrime(i)) {
      for (int of lst) {
        // if false, result is a float and therefore not a factor.
        if ((int / i) % 1 === 0){ 
          sum += int;
          isAtleastOne = true;
        }
      }
     if (isAtleastOne) returnArr.push([i, sum])
    }
  } 
  return returnArr;
}
 
 
function isPrime(num) {
    for(let i = 2, s = Math.sqrt(num); i <= s; i++)
        if(num % i === 0) return false; 
    return num !== 1;
}

//https://www.codewars.com/kata/54d496788776e49e6b00052f