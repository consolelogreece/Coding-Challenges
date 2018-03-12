function smallestCommons(arr) {
    var lowest, highest, k = 0;
    if (arr[1] - arr[0] > 0) {
        lowest = arr[0];
        highest = arr[1];
    } else {
        lowest = arr[1];
        highest = arr[0];
    }
    var test = true;
    var lowestCommon = arr[0] * arr[1];

    while (true) {
      
        for (var i = lowest; i < highest + 1; i++) {
            if (lowestCommon % i !== 0) {
                test = false;
                break;
            }
        }



        if (test == true) {
            return lowestCommon;
        } else {
            test = true;
            lowestCommon += lowest;

        }



    }


}


smallestCommons([1, 13]);