namespace StudentScores

type Student = {
  Surename: string
  GivenName: string
  Id: string
  MeanScore: float
  MinScore: float
  MaxScore: float
}
module Student = 

  let nameParts (s: string) = 
      let elements = s.Split(',')
      match elements with 
        | [|surname; givenName|] -> surname.Trim(), givenName.Trim()
        | _ -> raise (System.FormatException(sprintf "Invalid name format \"%s\"" s))

  let fromString (s : string) =
      let elements = s.Split('\t')
      let name = elements[0]
      let sur, given = name |> nameParts
      let id = elements[1]

      let scores =
          elements
          |> Array.skip 2
          |> Array.map TestResult.fromString
          |> Array.choose TestResult.effectiveScore

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