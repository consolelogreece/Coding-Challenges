function XO(str) {
  var ohs = 0;
  var ex = 0;
  str.toLowerCase().split('').forEach(function(char) {
    if (char == "x") {ex += 1}
    else if (char == "o") {ohs += 1}
  });
  return (ohs == ex);
}
