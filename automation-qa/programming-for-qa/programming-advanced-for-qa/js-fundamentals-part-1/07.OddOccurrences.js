function oddOccurrences(text){
    let words = text.toLowerCase().split(' ')
    let outputWords = {}

    for (const word of words) {
        if(outputWords[word]){
            outputWords[word]++
        } else {
            outputWords[word] = 1
        }
    }

    let outputArray = []

    for (const key in outputWords) {
        if(outputWords[key] % 2 !== 0){
            outputArray.push(key)
        }  
    }

    console.log(outputArray.join(' '))
}