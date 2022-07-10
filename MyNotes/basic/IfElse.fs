namespace Basic

module IfElse =
  let ifElse (argv: string[]) =
    printfn "-----------------------"
    printfn "---    IF-ELSE   ------"
    printfn "-----------------------"
    let person =
        if argv.Length > 0 then
            argv.[0]
        else
            "Anonymous Person"
    printfn "Hello %s from my F# program!" person
    0