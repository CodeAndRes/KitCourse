open System

[<EntryPoint>]
let main argv =
  printfn "Test"
  // IfElse.ifElse argv |> ignore
  // Loops.loops argv |> ignore 
  // Loops.loopArrayIter argv |> ignore
  // ForwardPiping.forwardPiping argv |> ignore
  // let param = String ["Samples/StudentScores.txt"] 
  // CollectionFunctions.collectionFunction [|"Samples/StudentScores.txt"|]
  // Simple.processFunction  [|"Samples/StudentScores.txt"|]
  // RecordType.processFunction  [|"Samples/StudentScores.txt"|]
  // RecordType.processFunction  [|"Samples/StudentScoresNA.txt"|]
  CurryingParameters.processFunction argv