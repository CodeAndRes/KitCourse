open Basic
open StudentScores

[<EntryPoint>]
let main argv =
  // IfElse.ifElse argv |> ignore
  // Loops.loops argv |> ignore 
  // Loops.loopArrayIter argv |> ignore
  // ForwardPiping.forwardPiping argv |> ignore
  // CollectionFunctions.collectionFunction [|"Samples/StudentScores.txt"|] |> ignore
  // CurryingParameters.processFunction argv |> ignore
  // Simple.processFunction  [|"Samples/StudentScores.txt"|] |> ignore
  StudentsScoresProgram.processFunction  [|"Samples/StudentScoresNA.txt"|] 
  //CurryingParameters.processFunction argv