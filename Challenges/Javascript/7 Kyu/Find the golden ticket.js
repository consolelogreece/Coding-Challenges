function finder(box) {
  for(var i = 0; i < box.length; i++)
    if(box[i][0]) return i;
  
  return "There is no golden ticket!";
}

// https://www.codewars.com/kata/59828f1954419acdff00002e