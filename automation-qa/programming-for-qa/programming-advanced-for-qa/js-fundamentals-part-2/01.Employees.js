function employees(array) {
    
    class Employee{
        constructor(name, personalNumber){
            this.name = name
            this.personalNumber = personalNumber
        }

        printEmployeeInfo() {
            return `Name: ${this.name} -- Personal Number: ${this.personalNumber}`
        }
    }

    for (const name of array) {
        let personalNumber = name.length
        let currentEmployee = new Employee(name, personalNumber)

        console.log(currentEmployee.printEmployeeInfo())
    }
}