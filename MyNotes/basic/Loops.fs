module Loops  

  let loops (argv: string[]) = 
    printfn "-----------------------"
    printfn "---     LOOPS    ------"
    printfn "-----------------------"
    for i in 0..argv.Length-1 do
      let person = argv[i] 
      printfn "Hello %s from my F# program!" person
    printfn "Nice to meet you!!"
    0
  
  let sayHello person = 
      printfn "Hello %s from my F# program! " person

  let loopArrayIter (argv: string[]) =
   printfn "-----------------------"
   printfn "---LOOPS ARRAY ITER ---"
   printfn "-----------------------"
   Array.iter sayHello argv
   printfn "Nice to meet you."
   0