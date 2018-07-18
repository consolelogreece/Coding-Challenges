
function toWeirdCase(string){
  var returnstring = '';
  var array = string.split(" ");
  array.forEach(function(entry) {
    for (var i = 0; i < entry.length; i++) {
      if ((i & 1) == 0 ){                              // if last bit is 1, integer must be odd.
        returnstring += entry[i].toUpperCase();
      } else {
        returnstring += entry[i].toLowerCase();
      } 
    }
  returnstring += ' ';
  });
  return returnstring.trim();
}