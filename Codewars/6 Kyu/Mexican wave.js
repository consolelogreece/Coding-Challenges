function wave(word){  
  let arr = [];
  word = word.split('')
  for (var i = 0; i < word.length; i++) {
    if (word[i] === " ") continue;
    let wrdcpy = word.slice(0);
    wrdcpy[i] = wrdcpy[i].toUpperCase();
    arr.push(wrdcpy.join(''))
  }
  return arr;
}

//https://www.codewars.com/kata/58f5c63f1e26ecda7e000029