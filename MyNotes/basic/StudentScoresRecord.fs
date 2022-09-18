namespace StudentScores
open System
open System.IO

module StudentsScoresProgram =         
    
  let processFunction (argv: string[]) =
      if argv.Length = 1 then
          let filePath = argv.[0]
          if File.Exists filePath then
              printfn "Processing %s" filePath
              try
                  //Summarize.summarize filePath
                  Summarize.sumarizeGroup filePath
                  0
              with
              | :? FormatException as e ->
                  printfn "Error: %s" e.Message
                  printfn "   The file was not in the expected format."   
                  1   
              | :? IO.IOException as e ->
                  printfn "Error: %s" e.Message
                  printfn "   The file was IO problem!!"   
                  2   
              | _ as e ->
                  printfn "   Unexpected error: %s!!" e.Message   
                  3   
          else
              printfn "File not found: %s" filePath
              4
      else
          printfn "Please specify a file."
          5