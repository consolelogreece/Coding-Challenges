function elevator(left, right, call){
  if ((call >= left) && (left > right) || (call <= left) && (left < right))
  {
    return "left";
  }
 return "right";
}

//https://www.codewars.com/kata/5c374b346a5d0f77af500a5a