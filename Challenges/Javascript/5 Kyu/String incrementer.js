function incrementString (strng) {
  console.log(strng)
  var splitstring = strng.split("");
  var word = splitstring.filter(val => isNaN(val))
  var numarr = splitstring.filter(val => !isNaN(val));
  var numlen = numarr.length;
  if (numlen === 0) return word.join('') + "1";
  
  
  var incremented = false;

  for (var i = numlen-1; i >= 0; i--) {
    if (numarr[i] < 9) {
      numarr[i]++; 
      incremented = true;
    } else {
      numarr[i] = 0;
    }
    if (incremented) break;
  }

  if (incremented) return word.concat(numarr).join('');
  return word.join('') + '1' + '0'.repeat(numlen)
  
 
}

//https://www.codewars.com/kata/54a91a4883a7de5d7800009c