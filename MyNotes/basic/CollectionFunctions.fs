namespace Basic 
open System.IO

module CollectionFunctions =

  let printMeanScore (row : string) =
    let elements = row.Split('\t')
    printfn "%s" row
    
  let summarize filePath =
    let rows = File.ReadAllLines filePath
    let studentCount = (rows |> Array.length) - 1
    printfn "Student count %i" studentCount
    rows
    |> Array.skip 1 
    |> Array.iter printMeanScore

  let collectionFunction(argv:string[]) =
    printfn "---------------------------"
    printfn "---COLLECTION FUNCTIONS ---"
    printfn "---------------------------"
    if argv.Length = 1 then
      let filePath = argv[0]
      printfn "Procesing %s" filePath
      if File.Exists filePath then
        printfn "The file in %s Exists!!" filePath
        summarize filePath
        0
      else  
        printf "Error The file in %s doesn't exists!!" filePath
        2
    else
      printfn "Please specify a file"
      1  