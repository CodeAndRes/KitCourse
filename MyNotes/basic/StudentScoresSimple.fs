
module Simple
  open System.IO

  let printMeanScore (row : string) =
      let elements = row.Split('\t')
      let name = elements[0]
      let id = elements[1]

      let floatElements =
          elements
          |> Array.skip 2
          |> Array.map float

      let maxScore = 
          floatElements
          |> Array.max  

      let minScore =
          floatElements
          |> Array.min

      let meanScore = 
          elements
          |> Array.skip 2
      //   |> Array.map float
      //   |> Array.average
          |> Array.averageBy float

      printfn "%s\t%s\t%0.1f\t%0.1f\t%0.1f" name id meanScore maxScore minScore

  let summarize filePath = 
      let rows = File.ReadAllLines filePath
      let studentCount = (rows |> Array.length) - 1
      printfn "Student count: %i" studentCount
      rows
      |> Array.skip 1
      |> Array.iter printMeanScore

  let processFunction (argv: string[]) =
      if argv.Length = 1 then
          let filePath = argv.[0]
          if File.Exists filePath then
              printfn "Processing %s" filePath
              summarize filePath
              0
          else
              printfn "File not found: %s" filePath
              2
      else
          printfn "Please specify a file."
          1
