function nextBigger(n){
  var nSplit = n.toString().split('').map(x => parseInt(x, 10))
  var nextBiggest = -1;
  for (var i = nSplit.length - 1; i >= 1; i--){
    if (nSplit[i] > nSplit[i-1]) {
      var sortingSplit = nSplit.splice(i - 1);
      var firstNo = sortingSplit[0];
      sortingSplit.sort()
      for (var j = 1; j < sortingSplit.length; j++) {
        if (sortingSplit[j] > firstNo) {
          firstNo = sortingSplit.splice(j, 1);
          sortingSplit.unshift(firstNo[0])
          nextBiggest = parseInt((nSplit.concat(sortingSplit)).join(''), 10)
        break;    
        }
      }
     break;
    }
  }
  return nextBiggest;
}

//https://www.codewars.com/kata/55983863da40caa2c900004e
