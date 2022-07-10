namespace StudentScores
open System.IO

module StudentsScoresProgram =         
    
  let processFunction (argv: string[]) =
      if argv.Length = 1 then
          let filePath = argv.[0]
          if File.Exists filePath then
              printfn "Processing %s" filePath
              Summarize.summarize filePath
              0
          else
              printfn "File not found: %s" filePath
              2
      else
          printfn "Please specify a file."
          1