
function sumPrimes(num) {
  var total = 0;
  var prime = true;
   for (var i = 0; i<num + 1;i++) {
     
     for (var j = 0; j < i; j++) {
       
         if (i % j == 0 && j !== 1 && j !== num) {
           prime = false;
           break;
         }
     
       }
     if (prime == true) {
       if (i !== 1) {
         total += i;
       }
       
       
     } else {
       prime = true;
     }
     } 
  return total;
}

sumPrimes(1000);
