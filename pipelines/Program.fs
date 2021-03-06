﻿module PipelinesAndComposition = 

    let square x = x*x
    let addOne x = x*x

    let isOdd x = x%2<> 0

    let numbers = [1;2;3;4;5]

    let squareOddValuesAndAddOne values =
        let odds = List.filter isOdd values
        let squares = List.map square odds
        let result = List.map addOne squares 
        result

    printfn "processing %A through 'squareOddValuesAndAddOne' produces: %A" numbers (squareOddValuesAndAddOne numbers)

    let squareOddValuesAndAddOneNested values =
        List.map addOne (List.map square (List.filter isOdd values))

    printfn "processing %A through 'squareOddValuesAndAddOneNested' produces: %A" numbers (squareOddValuesAndAddOneNested numbers)

    
    /// pipeline style 

    let squareOddValuesAndAddOnePipeline values =    
        values
        |>List.filter isOdd
        |>List.map square
        |>List.map addOne

    printfn "processing %A through 'squareOddValuesAndAddOnePipeline' produces: %A" numbers (squareOddValuesAndAddOnePipeline numbers)

    /// shorter way

    let squareOddValuesAndAddOneShorterPipeline values =
        values
        |>List.filter isOdd
        |>List.map(fun x -> x |> square |> addOne)

    printfn "processing %A through 'squareOddValuesAndAddOneShorterPipeline' produces: %A" numbers (squareOddValuesAndAddOneShorterPipeline numbers)     














