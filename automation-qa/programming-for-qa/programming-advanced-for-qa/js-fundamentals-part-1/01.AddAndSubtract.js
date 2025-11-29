function addAndSubtract(numbersArray) {

    let originalarraySum = 0
    let modifiedArraySum = 0

    for (let i = 0; i < numbersArray.length; i++) {
        originalarraySum += numbersArray[i]
        
        if (numbersArray[i] % 2 === 0) {
            numbersArray[i] +=i
        } else {
            numbersArray[i] -=i
        }

        modifiedArraySum += numbersArray[i]
    }

    console.log(numbersArray)
    console.log(originalarraySum)
    console.log(modifiedArraySum)
}