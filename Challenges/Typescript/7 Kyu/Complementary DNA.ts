export class Kata {
  static dnaStrand(dna: string) {
    let newString:string = "";
      for (let char of dna) {
        switch(char) {
          case "T":
            newString += "A"
            break;  
          case "A":
            newString += "T"
            break;  
          case "G":
            newString += "C"
            break;  
          case "C":
            newString += "G"
            break;  
        }
      }
    return newString;
  }
}

//https://www.codewars.com/kata/554e4a2f232cdd87d9000038