open StudentScores

[<EntryPoint>]
let main argv =
  //StudentsScoresProgram.processFunction  [|"Samples/SchoolCodes.txt"; "Samples/StudentScoresSchool.txt"|] 
  StudentsScoresProgram.processFunction  [|"Samples/SchoolCodes.txt"; "Samples/StudentScoresSchoolExtraCodes.txt"|] 
