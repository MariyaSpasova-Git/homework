function storeProvision(currentStock, orderedStock){
    
    let store = {}

    for (let i = 0; i < currentStock.length; i+=2) {
        const productName = currentStock[i];
        const quantity = Number(currentStock[i+1])
        
        store[productName] = quantity
    }

    for (let i = 0; i < orderedStock.length; i+=2) {
        const productName = orderedStock[i];
        const quantity = Number(orderedStock[i+1])
        
        if(store.hasOwnProperty(productName)){
            store[productName] += quantity
        } else {
            store[productName] = quantity
        }
    }

    for (const key in store) {
        console.log(`${key} -> ${store[key]}`)    
    }
}