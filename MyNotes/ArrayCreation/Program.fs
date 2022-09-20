open System

[<EntryPoint>]
let main argv =
  
  let isEven x = 
    x % 2 = 0

  let todayIsThursday() =
      DateTime.Now.DayOfWeek = DayOfWeek.Sunday

  let numbers = 
    [|
        if todayIsThursday() then 42
        for i in 0..9 do 
          let x = i * i 
          if x |> isEven then
            x
        999
    |]  
  
  printfn "%A" numbers 
  
  let integers = 
    [|
      1..100
    |]

  let sumSquares =
    integers
    |> Array.map (fun number -> number * number)
    |> Array.sum

  printfn "%A" sumSquares

  let total =
    [| for i in 1..100 ->  i * i|]
    |> Array.sum
  printfn "The total is : %i" total

  let integers2 = 
    Array.init 100 (fun number -> number * number)
    |> Array.sum
  
  printfn "%i" integers2

  0
