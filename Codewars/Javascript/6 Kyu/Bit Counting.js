var countBits = function(n) {
  var bin = n.toString(2);
  var count = 0;
  for (var i = 0; i < bin.length; i++) {
    if (bin[i] == 1) {
      count++;
    }
  }
  return count;
};