//https://learn.freecodecamp.org/coding-interview-prep/algorithms/find-the-symmetric-difference

 function sym() {
  let uniques = [];
  // each argument is an array
  [...arguments].forEach(set => {
    // remove duplicates
    set = new Set(set);
    set.forEach(el => {
      let elementIndex = uniques.indexOf(el);
      // -1 means element is unique
      if (elementIndex === -1) {
        uniques.push(el)
      } else {
        // not -1 means element is not unique, so remove from uniques array.
        uniques.splice(elementIndex, 1)
      }
    })
  })
  return uniques;
}
