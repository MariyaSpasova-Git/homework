function printPartyGuests(input){
    let guestList = []

    while(input[0] !== "PARTY"){
        let guestsNumber = input.shift()
        guestList.push(guestsNumber)
    }

    input.shift()

    for (const commingGuest of input) {
        if(guestList.includes(commingGuest)){
            let guestIndexToRemove = guestList.indexOf(commingGuest)
            guestList.splice(guestIndexToRemove, 1)
        }
    }

    let vipGuestsList = guestList.filter(guest => !isNaN(guest[0]))
    let regularGuestsList = guestList.filter(guest => isNaN(guest[0]))

    console.log(guestList.length)
    console.log(vipGuestsList.join("\n"))
    console.log(regularGuestsList.join("\n"))
}