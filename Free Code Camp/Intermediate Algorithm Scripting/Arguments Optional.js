
function addTogether(){
  var a = arguments[0];
  if (arguments.length < 2 && typeof a == "number") {
    return function() {
      if (typeof arguments[0] =="number") {
          return arguments[0] + a;
      } else {
        return undefined;
      }
      
  };
  } else {
    var b = arguments[1];
    if (typeof a !== "number" || typeof b !== "number") {
      return undefined;
    }
    
    return a+b;  
    
  }
  
  

}

addTogether(3434)(213);
