function deleteNth(arr,n){
  var count = {};
  var newArray = [];
  for (var i = 0; i < arr.length; i++) {

    if (!count.hasOwnProperty(arr[i])) {      // if an entry in the count object doesn't exist for the current number, create one and set it to 0.
      count[arr[i]] = 0;
    }  

    count[arr[i]] += 1;                       // increment the count for the current number by 1.

    if (count[arr[i]] <= n) {                 // check there isnt too many duplicates in the newArray. if there isn't, add it to newArray.
      newArray.push(arr[i]);               
    }
  }
  return newArray                             // return the array.
}