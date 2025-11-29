function trackWords(array) {
    let wordsToSearch = array.shift().split(" ")
    let outputWords = {}

    for (let word of wordsToSearch) {
        outputWords[word] = 0
    }

    for (let currentWord of array) {
        if (currentWord in outputWords) {
            outputWords[currentWord]++
        }
    }

    let entries = Object.entries(outputWords)
    entries.sort((a, b) => b[1] - a[1])

    for(let [word, count] of entries) {
        console.log(`${word} - ${count}`)
    }
}