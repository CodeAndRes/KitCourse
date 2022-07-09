
module ForwardPiping 

  open System
  
  let isValid person = 
    String.IsNullOrWhiteSpace person |> not
  
  let isAlowed person =
    person <> "Sokka"

  let forwardPiping(argv: string[]) =
    printfn "-----------------------"
    printfn "---FORWARD PIPING ---"
    printfn "-----------------------"
   // let validNames = argv |> Array.filter isValid
   // validNames |> Array.iter Loops.sayHello
    argv 
    |> Array.filter isValid 
    |> Array.filter isAlowed
    |> Array.iter Loops.sayHello
    printfn "Nice to meet you."
    0