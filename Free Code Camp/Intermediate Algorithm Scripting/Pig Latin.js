
function translatePigLatin(str) {
  var splitWord = str.split('');
  var check;
  var count;
  var newWord = "";
  for (var i = 0; i < splitWord.length; i++) {
    check = splitWord[i].toUpperCase();
    if (check != "A" && check != "E" && check != "I" && check != "O" && check != "U") {
      continue;
    } else {
      count = i;
      break;
    }
    
  }
  if (count == 0){
    return (str + "way");
  } else {
  newWord = (str.substring(count, splitWord.length) + str.substring(0, count) + "ay");
  return newWord;
  }
}
function pigIt(str){
  var each = str.split(' ');
  var stringval = "";
  for (var i = 0; i < str.length; i++) {
    stringval += (translatePigLatin(each[i]));
  }
  return stringval;
}