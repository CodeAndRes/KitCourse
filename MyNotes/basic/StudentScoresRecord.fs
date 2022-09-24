namespace StudentScores
open System
open System.IO

module StudentsScoresProgram =         
    
  let processFunction (argv: string[]) =
      if argv.Length = 2 then
          let schoolCodesFilePath = argv[0]
          let filePath = argv.[1]
          if not (File.Exists filePath) then
              printfn "File not found: %s"  filePath
              1
          elif not (File.Exists schoolCodesFilePath) then    
              printfn "File not found: %s"  schoolCodesFilePath
              
              2
          else
              printfn "Processing %s (school codes: %s)" filePath schoolCodesFilePath
              try
                  Summarize.summarize schoolCodesFilePath filePath
                  //Summarize.sumarizeGroup filePath
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
          printfn "Please specify a file."
          4