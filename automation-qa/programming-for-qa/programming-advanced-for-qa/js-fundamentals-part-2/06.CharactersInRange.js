function solve (a, b) {
    
let start = Math.min(a.charCodeAt(), b.charCodeAt())
let end = Math.max(a.charCodeAt(), b.charCodeAt())

let charsArray = []

for (let i = start + 1; i < end; i++) {
    let currentChar = String.fromCharCode(i)
    charsArray.push(currentChar)
}

console.log(charsArray.join(" "))
}