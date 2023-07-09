export function foldArray(array:number[], runs:number):number[]
{
  let returnArray:number[] = array.slice(0);
  let returnArrayLen:number = 0;
  for (var i = 0; i < runs; i++) {
    returnArrayLen = returnArray.length;
    for (var j = 0; j < Math.floor(returnArrayLen / 2); j++) {
      returnArray[j] += returnArray.pop() 
    }
  }
  return returnArray;
}

//https://www.codewars.com/kata/57ea70aa5500adfe8a000110
