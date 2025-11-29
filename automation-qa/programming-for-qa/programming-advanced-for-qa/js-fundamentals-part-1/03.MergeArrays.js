function mergeArrays (array1, array2) {
    let resultArray = []

    for (let i = 0; i < array1.length; i++) {

        let element1 = array1[i]
        let element2 = array2[i]

        if(i % 2 == 0) {
            resultArray.push(Number(element1) + Number(element2))
        } else {
            resultArray.push(element1 + element2)
        }
    }

    console.log(resultArray.join(" - "))
}