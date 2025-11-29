function printTopIntegers(array) {
    let outputArray = []

    for(let i = 0; i < array.length; i++) {
        let currentElement = array[i]
        let isTopInteger = true

        for (let j = i+1; j < array.length; j++) {
            if(currentElement <= array[j]) {
            isTopInteger = false
            break
            }
        }

        if(isTopInteger) {
            outputArray.push(currentElement)
            }
    }
    console.log(outputArray.join(" "))
}