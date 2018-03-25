function findUniq(arr) {
  console.log(arr);
  var current = arr[0];                       // sets variable 'current' to first item in array.
  var last = arr[1];                          // sets variable 'last' to second item in array.
  for (var i = 2; i < arr.length; i++) {      // loop through array starting from index [2], as [0] and [1] are already set.
    if (last !== current) {                   // check if 'last' is equal to 'current', if not, we have found the odd number. 
      if (arr[i] == last) {                   // if arr[i] is equal to last, then neither are unique, so 'current' must be unique.
        return current                        
      } else {                                // otherwise, last must be unique.
        return last;
      }
    }
  last = current                              // set 'last' variable to the current value stored in 'current' variable.
  current = arr[i]                            // set 'current' variable to the current value in the for loop, i.e. arr[i].
  }
  return arr[arr.length - 1]  // if the unique number is at the end, the above algorithm won't catch it,
}                             // the instructions state that there will always be a unique number, so we don't have to worry about returning
                              // a false value. If there wasn't always a number, this would have to be changed.
