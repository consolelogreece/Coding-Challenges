function generator(sequencer, ...rest) {
  let context = sequencer(...rest)
  return {
    next: function(){
      return context();
    }
  }
}

function dummySeq() {
  return function() {
    return "dummy";
  };
}

function factorialSeq() {
  let count = 0;
  let currNo = 0;
  return function(){
    if (count === 0) {
      count++;
      currNo++;
    } else {
      currNo *= count;
      count++;
    }
    return currNo; 
  }
}

function fibonacciSeq() {
  let curr = 0;
  let prev = 1;
  let placeHolder = 0;
  return function(){
    placeHolder = curr;
    curr += prev;
    prev = placeHolder;
    return curr;
  }
}



function rangeSeq(start, step) {
   let currentNumber = start - step;
   return function(){
     return currentNumber += step;
   }
}

function primeSeq() {
  
  let currPrimeNo = 1;
    
  function isPrime(num) {
    var sqrtnum=Math.floor(Math.sqrt(num));
      var prime = num != 1;
      for(var i=2; i<sqrtnum+1; i++) { // sqrtnum+1
          if(num % i == 0) {
              prime = false;
              break;
          }
      }
      return prime;
  }
 
 return function(){
    currPrimeNo ++;
    
    while(!isPrime(currPrimeNo)) {
      currPrimeNo += 1;  
    }
    return currPrimeNo;
  }
  
}

function partialSumSeq() {
  let sum = 0;
  let currentArgIndex = 0;
  let argLen = arguments.length;
  let contextArgs = arguments;
  
  return function(){
    if (currentArgIndex === argLen) throw new err("END OF SEQUENCE")
    
    sum += contextArgs[currentArgIndex];
    
    currentArgIndex++;
    
    return sum;
  }
}

//https://www.codewars.com/kata/53c29a6abb5187180d000b65