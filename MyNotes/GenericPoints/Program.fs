open System
open GenericPoints

[<EntryPoint>]
let main argv =

    printfn "****************************************"
    printfn "***     With   float                 ***"
    printfn "****************************************"
    let pFloat1 = { X = 1.0; Y = 2.0 }
    let pFloat2 = pFloat1 |> Point.moveBy 3.0 4.0
    printfn "pFloat1: \n%A \npFloat2: \n%A" pFloat1 pFloat2
    printfn " "

    // Uncomment this code to test your generic version...

    printfn "****************************************"
    printfn "***     With   Integers              ***"
    printfn "****************************************"
    let pInt1 = { X = 1; Y = 2 }
    let pInt2 = pInt1 |> Point.moveBy 3 4
    printfn "pInt: \n%A \npInt2: \n%A" pInt1 pInt2
    printfn " "
    
    printfn "****************************************"
    printfn "***     With   float F               ***"
    printfn "****************************************"
    let pSingle1 = { X = 1.0f; Y = 2.0f }
    let pSingle2 = pSingle1 |> Point.moveBy 3.0f 4.0f
    printfn "pSingle: \n%A \npSingle2: \n%A" pSingle1 pSingle2
    printfn " "
    // ...end

    printfn "****************************************"
    printfn "***     With   strings               ***"
    printfn "****************************************"
    let pString1 = { X = "a"; Y = "b" }
    let pString2 = pString1 |> Point.moveBy "c" "d"
    printfn "pString1: \n%A \npString2: \n%A" pString1 pString2
    printfn " "

    // printfn "****************************************"
    // printfn "***     With   float F               ***"
    // printfn "****************************************"
    // // let pFloat3 = pFloat2 |> Point.scaleBy 2.0
    // let pInt3 = pInt2 |> Point.scaleBy 2
    // let pSingle3 = pSingle2 |> Point.scaleBy 2.0f
    // let pString3 = pString2 |> Point.scaleBy "factor"
    // printfn " "
    
    0
