function absentVowel(x){
    let vowels = "aeiou";
    for(var i = 0; i < vowels.length; i++) if (!x.includes(vowels[i])) return i;
}

// https://www.codewars.com/kata/56414fdc6488ee99db00002c