namespace StudentScores
open System.IO

module SchoolCodes = 
    let load (filePath : string) = 
        File.ReadLines filePath
        |> Seq.skip 1
        |> Seq.map (fun row ->
          let elements = row.Split('\t')
          let id = elements.[0] |> int
          let name = elements.[1]
          id, name )