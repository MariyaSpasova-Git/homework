function movies(inputArray){

    let allMovies = []

    for (const cmdArg of inputArray) {

        if(cmdArg.startsWith('addMovie')){
            let movieName = cmdArg.substring(9)
            allMovies.push({name: movieName})

        } else if (cmdArg.includes('directedBy')){
            let [movieName, directorName] = cmdArg.split(' directedBy ')
            let movie = allMovies.find( m => m.name === movieName)
            
            if (movie){
                movie.director = directorName
            }

        } else if (cmdArg.includes('onDate')){
            let [movieName, movieDate] = cmdArg.split(' onDate ')
            let movie = allMovies.find( m => m.name === movieName)

            if (movie){
                movie.date = movieDate
            }
        }
    }

    for (const movie of allMovies) {
        if (movie.name && movie.director && movie.date){
            console.log(JSON.stringify(movie))
        }
    }
}