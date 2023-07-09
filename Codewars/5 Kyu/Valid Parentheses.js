function validParentheses(parens){
  let parenthArray = parens.split('');
  if (parenthArray.length % 2 === 1 || parenthArray[0] === ")") return false;
  let openBraceArr = [];
  for (let parenth of parenthArray) {
    if (parenth === "(") {
      openBraceArr.push("(")
    } else {
      if (openBraceArr.length === 0) return false;
      openBraceArr.pop();
    }
  }
  return openBraceArr.length === 0;
}

//https://www.codewars.com/kata/52774a314c2333f0a7000688