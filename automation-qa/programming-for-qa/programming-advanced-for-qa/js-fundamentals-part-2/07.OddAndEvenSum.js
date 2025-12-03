function oddAndEvenSum(number) {
    
    let evenSum = 0
    let oddSum = 0
    let digitsArray = number.toString().split('')

    for (const digit of digitsArray) {
        let currentDigit = Number(digit)

        if (currentDigit % 2 === 0) {
            evenSum += currentDigit
        } else {
            oddSum += currentDigit
        }
    }

    console.log(`Odd sum = ${oddSum}, Even sum = ${evenSum}`)
}