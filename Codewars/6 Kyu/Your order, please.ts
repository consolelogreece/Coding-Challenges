export function order(words:String):String{
  let wordArray: string[] = words.split(' ');
    
   return wordArray.sort((a, b) => {
    let nA:number;
    let nB:number;
    let charCode:number;
    
    for (let i = 0; i < a.length; i++){
      charCode = a.charCodeAt(i);
      if (57 >= charCode && charCode >= 48) {
        nA = charCode - 48;
        break;
      }
    }
    
    for (let i = 0; i < b.length; i++) {
        charCode = b.charCodeAt(i);
        if (57 >= charCode && charCode >= 48) {
          nB = charCode - 48;
          break;
        }
      }
      
     return nA - nB; 
   }).join(' ')
}

//https://www.codewars.com/kata/55c45be3b2079eccff00010f