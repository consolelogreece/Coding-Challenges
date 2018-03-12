var num = 0;
function sumFibs(num) {
  var total = 1;
  var curfib= 0, next = 1, curfibholder;
  while (true) {
    curfibholder = next;
    next += curfib;
    curfib = curfibholder;
    if (next <= num) {
      if ((next % 2) !== 0) {
        total += next;
      }
      
    } else {
      break;
    }
  }
  return total;
}

sumFibs(75025);