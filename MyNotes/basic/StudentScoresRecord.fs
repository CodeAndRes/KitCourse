module RecordType
  open System.IO

  type Student = {
    Surename: string
    GivenName: string
    Id: string
    MeanScore: float
    MinScore: float
    MaxScore: float
  }

  module Float =
    let tryFromString s =
      if s = "N/A" then
        None
      else
        Some (float s)

    let tryFromStringOr n s =
        s
        |> tryFromString
        |> Option.defaultValue n
           
  module Student = 

    let namePart i (s: string) = 
        let elements = s.Split(',')
        elements.[i].Trim()

    let fromString (s : string) =
        let elements = s.Split('\t')
        let name = elements[0]
        let given = namePart 1 name
        let sur = namePart 0 name
        let id = elements[1]

        let scores =
            elements
            |> Array.skip 2
            |> Array.map (Float.tryFromStringOr 50.0)

        let meanScore = scores |> Array.average
        let maxScore = scores |> Array.max  
        let minScore = scores |> Array.min
        {
          Surename = sur
          GivenName = given
          Id = id
          MeanScore = meanScore
          MaxScore = maxScore
          MinScore = minScore
        }

    let printSummary (student: Student) =
      printfn "%s\t %s\t %s\t%0.1f\t%0.1f\t%0.1f" student.Surename student.GivenName student.Id student.MeanScore student.MaxScore student.MinScore

  let summarize filePath = 
      let rows = File.ReadAllLines filePath
      let studentCount = (rows |> Array.length) - 1
      printfn "Student count: %i" studentCount
      rows
      |> Array.skip 1
      |> Array.map Student.fromString
    //  |> Array.sortByDescending (fun student -> student.MeanScore)
      |> Array.sortBy (fun student -> student.Surename)
      |> Array.iter Student.printSummary
  
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