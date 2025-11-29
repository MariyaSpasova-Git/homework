function rotateArray (array, rotationsNumber){

    for (let i = 0; i < rotationsNumber; i++) {
        let firstElement = array.shift();
        array.push(firstElement);
    }

    console.log(array.join(" "))
}