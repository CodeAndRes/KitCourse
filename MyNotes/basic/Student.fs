namespace StudentScores

type Student = {
  Surname: string
  GivenName: string
  Id: string
  SchoolName: string
  MeanScore: float
  MinScore: float
  MaxScore: float
}
module Student = 
  open System.Collections.Generic

  let nameParts (s: string) = 
      let elements = s.Split(',')
      match elements with 
        | [|surname; givenName|] -> 
            {| Surname = surname.Trim()
               GivenName = givenName.Trim() |}
        | [|surname|] -> 
            {| Surname = surname.Trim()
               GivenName = "(None)" |}
        | _ -> 
            raise (System.FormatException(sprintf "Invalid name format \"%s\"" s))

  let fromString (schoolCodes : IDictionary<int, string>)( s : string) =
      let elements = s.Split('\t')
      let name = elements[0] |> nameParts
      let id = elements[1]
      let schoolCode = elements[2] |> int
      let schoolName = schoolCodes[schoolCode]

      let scores =
          elements
          |> Array.skip 3
          |> Array.map TestResult.fromString
          |> Array.choose TestResult.effectiveScore

      let meanScore = scores |> Array.average
      let maxScore = scores |> Array.max  
      let minScore = scores |> Array.min
      {
        Surname = name.Surname
        GivenName = name.GivenName
        Id = id
        SchoolName = schoolName
        MeanScore = meanScore
        MaxScore = maxScore
        MinScore = minScore
      }

  let printSummary (student: Student) =
    printfn "%s\t%s\t%s\t%s\t%0.1f\t%0.1f\t%0.1f" 
      student.Surname student.GivenName student.Id student.SchoolName student.MeanScore 
      student.MaxScore student.MinScore
  
  let printGroupSummary (student: Student) =
    printfn "\t%s\t%s\t%0.1f\t%0.1f\t%0.1f" 
      student.GivenName student.Id student.MeanScore student.MaxScore 
      student.MinScore