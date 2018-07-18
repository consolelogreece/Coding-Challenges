 function updateInventory(arr1, arr2) {
    // convert array to object for quicker lookups
    let currentInvObject = mapArrToObj(arr1);

    // add new order to current inv
    for (let el of arr2) {
        let productName = el[1];
        let productAmount = el[0];
        if (currentInvObject.hasOwnProperty(productName)) {
            currentInvObject[productName] += productAmount;
        } else {
            currentInvObject[productName] = productAmount;
        }
    }

    let newInv = [];

    // convert object back into array
    for (let key in currentInvObject) {
        newInv.push([currentInvObject[key], key])
    } 

    // sort array alphabetically
    newInv.sort(function(a, b){
        if(a[1] < b[1]) return -1;
        if(a[1] > b[1]) return 1;
        return 0;
    })
    return newInv; 

}

function mapArrToObj(arr) {
    return arr.reduce((obj, el) => {
        obj[el[1]] = el[0];
        return obj
        }, {}
    );
}
