function towns(inputArray) {
    
    class Town{
        constructor(name, lat, long) {
            this.name = name
            this.latitude = lat
            this.longitude = long
        }
    }

    for (const element of inputArray) {
        let [name, latitude, longitude] = element.split(" | ")

        let city = new Town(name, Number(latitude), Number(longitude))
        console.log(`{ town: '${city.name}', latitude: '${city.latitude.toFixed(2)}', longitude: '${city.longitude.toFixed(2)}' }`)
    }
}