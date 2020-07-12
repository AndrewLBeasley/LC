const firstNonRepeating = (str) => {

    //loop over string
    //get the first instance of a character
    //check against next character
    //return character


    for (var i = 0; i < str.length; i++) {
        if (str.indexOf(string[i]) == i && str.indexOf(str[i], i + 1) == -1) {
            return str[i];
        }
    }
    return null;
}


const smallestSubArray = (arr, x) => {
    //add start and end until you get x. 
    //save length of smallest sub array once you hit x.
    //return smallest value.    

    let minLength = arr.length + 1;

    for (let start = 0; start < arr.length; start++) {

        //set current sum to the value of start
        let currentSum = arr[start];

        //is the start larger than x?
        if (arr[start] > x) {
            return 1;
        }

        //establish end as start +1
        for (let end = start + 1; end < arr.length; end++) {
            currentSum += arr[end];

            //if the current sum is greater than x, and the current subarray is greater than the previous, set new min
            if (currentSum > x && (end - start + 1) < minLength) {
                minLength = (end - start + 1);
            }
        }
    }

    return minLength;
}

const KSrecursive = (items, c) => {
    //n is number of items
    //c is capacticy 

    let currentItem = items[items.length - 1];
    let result;

    if (items.length == 0 || c == 0) {
        //base case
        //either you have no items or you have no capacity     

        result = 0;
    } else if (currentItem.weight > c) {
        //the weight of the current item is greater than the KS capacity

        items = items.splice(currentItem)
        return KSrecursive(items, c);
    } else {
        items = items.slice(currentItem)
        let weightOne = KS(items, c);
        let weightTwo = currentItem.value + KS(items, c - currentItem.weight)

        return Math.max(weightOne, weightTwo);
    }

    return result;
}

const KSdynamic = (items, c) => {
    //n is number of items
    //c is capacticy 

    let currentItem = items[items.length - 1];
    let result;
    let tempResult;

    //if the function is called again, but a successful result has already been saved, return the saved result. 
    if(tempResult.length > 0)
        return tempResult;

    if (items.length == 0 || c == 0) {
        //base case
        //either you have no items or you have no capacity     

        result = 0;
    } else if (currentItem.weight > c) {
        //the weight of the current item is greater than the KS capacity

        items = items.splice(currentItem)
        return KSrecursive(items, c);
    } else {
        items = items.slice(currentItem)
        let weightOne = KS(items, c);
        let weightTwo = currentItem.value + KS(items, c - currentItem.weight)

        result = Math.max(weightOne, weightTwo);
        tempResult = result;
        return result;
    }

    return result;
}

//find range
for (let i = 10; i <= 12; i++) {
    console.log(i)
}

let ten = 10;
ten = ten.toString();


// Given a range of numbers [x, y] and an integer q. Multiply all the numbers in the range by q and return the count of all the numbers which have no same digits as the corresponding product obtained.
const rangeMultiplier = (x, y, q) => {
    let range = [];

    for (let i = x; i <= y; i++) {
        range.push(i)
    }

    let count = 0;

    range.forEach((num, i, arr) => {
        let numstring = num.toString();

        numstring.indexOf(num * q) < 0 ? count++ : null;
    })

    return count;
}
