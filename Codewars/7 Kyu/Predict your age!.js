function predictAge(age1,age2,age3,age4,age5,age6,age7,age8){
  let total = 0;
  for (let age of arguments) {
    total += (age * age);
  }
  return Math.floor((total ** 0.5) / 2);
}

//https://www.codewars.com/kata/5aff237c578a14752d0035ae