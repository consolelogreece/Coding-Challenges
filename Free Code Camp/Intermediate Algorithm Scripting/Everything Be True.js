
function truthCheck(collection, pre) {
  for (var i = 0; i < collection.length; i++) {
    
    console.log(i + ": " + collection[i][pre]);
    if (collection[i][pre] != undefined && collection[i][pre] != null && collection[i][pre] != 0 && collection[i][pre].toString() != "NaN") {
      
    } else {
      return false;
    }
}
  return true;
}
truthCheck([{"user": "Tinky-Winky", "sex": "male"}, {"user": "Dipsy"}, {"user": "Laa-Laa", "sex": "female"}, {"user": "Po", "sex": "female"}], "sex");