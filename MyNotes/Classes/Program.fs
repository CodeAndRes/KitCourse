open System
open Classes

[<EntryPoint>]
let main argv =
  let namePrompt = ConsolePrompt("PLease enter your name")
  let name = namePrompt.GetValue()
  printfn "Hello %s" name
  0
