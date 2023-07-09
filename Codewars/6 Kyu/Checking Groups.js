 function groupCheck(s) {
     var track = {
         '(': 0,
         '[': 0,
         '{': 0,
         ')': 0,
         ']': 0,
         '}': 0

     }

     for (var i = 0; i < s.length; i++) {
         const char = s.charAt(i);
         switch (char) {
             case '(':
             case '[':
             case '{':
                 track[char]++;
                 break;

             case ')':
                 if (track['('] === 0) {
                     return false
                 } else {
                     track['(']--
                 }
                 break;

             case ']':
                 if (track['['] === 0) {
                     return false
                 } else {
                     track['[']--
                 }
                 break;

             case '}':
                 if (track['{'] === 0) {
                     return false
                 } else {
                     track['{']--
                 }
                 break;

         }
     }

     if (track['('] === 0 && track['['] === 0 && track['{'] === 0) return true
     return false

 }