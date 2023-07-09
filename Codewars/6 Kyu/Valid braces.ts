export class Challenge {
  static validBraces(braces) {
      if (braces.length % 2 == 1) return false;
      let braceArray:string[] = braces.split('');
      let openBraceArr: string[] = [];
      
      for (let brace of braceArray) {
        switch (brace) {
        case "{":        
        case "[": 
        case "(":
          openBraceArr.push(brace);
          break;
          
        case "}":
          if (openBraceArr[openBraceArr.length - 1] === "{") {
              openBraceArr.pop();
          } else { 
            return false        
          }
          break;
          
        case "]":
          if (openBraceArr[openBraceArr.length - 1] === "[") {
              openBraceArr.pop();
          } else {
            return false  
          }
          break;
          
        case ")":
          if (openBraceArr[openBraceArr.length - 1] === "(") {
              openBraceArr.pop();
          } else {
            return false
          }
          break;
        }
      }
      return openBraceArr.length === 0;
  }
}

//https://www.codewars.com/kata/5277c8a221e209d3f6000b56