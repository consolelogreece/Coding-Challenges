function steamrollArray(arr) {
    var finalarry = [];
    steamrolltheArray(arr);
    return finalarry;
    function steamrolltheArray(arr) {
        for (var i = 0; i < arr.length; i++) {
            if (Array.isArray(arr[i])) {
                steamrolltheArray(arr[i]);
            } else {
                finalarry.push(arr[i]);
            }
        }
        return finalarry;
    }
}
steamrollArray([1, [2], [3, [[4]]]]);
