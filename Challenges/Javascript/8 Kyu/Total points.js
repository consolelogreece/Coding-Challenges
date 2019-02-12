function points(games) {
   let score = 0;
   for(let i = 0; i < games.length; i++)
   {
     if (games[i][0] > games[i][2]) score+=3;
     if (games[i][0] === games[i][2]) score++;
   }
   return score;
}

//https://www.codewars.com/kata/5bb904724c47249b10000131