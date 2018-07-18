function getMiddle(s) {
  var length = s.length;
  return (length % 2 == 0) ? s.slice(((length/2) - 1), ((length/2) +1)) : s[Math.floor(length/2)]
}

//https://www.codewars.com/kata/56747fd5cb988479af000028