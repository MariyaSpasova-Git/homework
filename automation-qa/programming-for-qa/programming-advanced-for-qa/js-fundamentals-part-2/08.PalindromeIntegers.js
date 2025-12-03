function palindromeIntegers2(inputArray) {
    
    for (const element of inputArray) {
        console.log(element == element.toString().split('').reverse().join(''))
    }
}