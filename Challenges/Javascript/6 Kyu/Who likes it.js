function likes(names) {
  switch (names.length) {
    case 0:
    return "no one likes this";
    break;  //Break not necessary as 'return' stops function anyway
    case 1:
    return (names[0] + " likes this");
    break;  //Break not necessary as 'return' stops function anyway
    case 2:
    return (names[0] + " and " + names[1] + " like this");
    break;  //Break not necessary as 'return' stops function anyway
    case 3:
    return (names[0] + ", " + names[1] + " and " + names[2] + " like this");
    break;  //Break not necessary as 'return' stops function anyway
    default:
    return (names[0] + ", " + names[1] + " and " + (names.length - 2) + " others like this");
  }
}