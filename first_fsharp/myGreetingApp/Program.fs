open System

// Define a function to print a name
// above the main function

let printGreeting name =
    print "Hello %s from F# to you !" name

[<EntryPoint>]
let main ardv =
    // Call  new function!
    printGreeting "Dmitri"
    0 // return an integer exit code

