function validatePIN (pin) {
   if ((pin.length !== 4 && pin.length !==6) || pin.match(/\D/g)) {
    return false;
  }
  return true;
}