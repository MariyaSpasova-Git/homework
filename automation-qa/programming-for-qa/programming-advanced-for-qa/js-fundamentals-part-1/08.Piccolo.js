function printParkedCarNumbers(carInput){
    let parkedCars = []
    
    for (const carInfo of carInput) {
        let action = carInfo.split(', ')[0]
        let carNumber = carInfo.split(', ')[1]

        if (action === 'IN'){
            if(!parkedCars.includes(carNumber)){
                parkedCars.push(carNumber)
            }
        } else if (action === 'OUT'){
                let carIndexToRemove = parkedCars.indexOf(carNumber)

                if (carIndexToRemove !== -1){
                    parkedCars.splice(carIndexToRemove, 1)
                }
        }
    }

    if (parkedCars.length > 0){
        parkedCars.sort()

        for (const carNumber of parkedCars) {
            console.log(carNumber)
        }
    } else {
        console.log("Parking Lot is Empty")
    }
}