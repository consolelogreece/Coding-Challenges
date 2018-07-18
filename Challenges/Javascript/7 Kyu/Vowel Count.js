function getCount(str) {
  var vowelsCount = 0;
  str.toLowerCase().split("").forEach(function(char){(char === 'a' || char === 'e' || char === 'i' || char === 'o' || char === 'u') ? vowelsCount++ : null})
  return vowelsCount;
}

//https://www.codewars.com/kata/54ff3102c1bad923760001f3