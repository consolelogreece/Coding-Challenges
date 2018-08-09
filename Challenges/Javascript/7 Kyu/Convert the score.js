function scoreboard(string) {

  const scoreMap = ["nil", "one","two","three","four","five","six","seven","eight","nine"];
  
  const parsedString = string.split(" ");
  
  const scores = parsedString.slice(parsedString.length - 2);
  
  return [scoreMap.indexOf(scores[0]), scoreMap.indexOf(scores[1])]
}

//https://www.codewars.com/kata/5b6c220fa0a661fbf200005d