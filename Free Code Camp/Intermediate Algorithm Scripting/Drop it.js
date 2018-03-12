function dropElements(arr, func) {
  var number = -1;
  
  for (var i = 0; i < arr.length; i++) {
    if (func(arr[i]) == false) {
       arr.shift();
        i -= 1;
    } else {
      break;
    }
  }
  return arr;

  

}

dropElements([1, 2, 3, 4], function(n) {return n > 5;});
