module PipelinesAndComposition = 

    let square x = x*x
    let addOne x = x*x

    let isOdd x = x%2<> 0

    let numbers = [1;2;3;4;5]

    let squareOddValuesAndAddOne values =

    let odds = List.filter isOdd values
    let squares = List.map square odds
    let result = List.map addOnew squares 
    result

    printfn "processing %A through 'squareOddValuesAndAddOne'

    let squareOddValuesAndAddOneNested values =
        List.map addOne (List.map square (List.filter isOdd values))

    printfn "processing %A through 'squareOddValuesAndAddOneNested' produces: %A" numbers (squareOddValuesAndAddOneNested numbers)

    





