function printCommonElements(array1, array2) {
    for (let element of array1) {
        if(array2.includes(element)){
            console.log(element)
        }
    }
}

