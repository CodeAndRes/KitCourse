namespace StudentScores
open System.IO

module Summarize =
  let readAndCount schoolCodesFilePath filePath = 
        let rows = 
            File.ReadLines filePath
            |> Seq.cache
        let studentCount = (rows |> Seq.length) - 1
        printfn "Student count: %i" studentCount
        let schoolCodes = SchoolCodes.load schoolCodesFilePath
        rows
        |> Seq.skip 1
        |> Seq.map (Student.fromString schoolCodes)


  let summarize filePath = 
        readAndCount filePath
        |> Seq.sortBy (fun student -> student.Surename)
        |> Seq.iter Student.printSummary

  let sumarizeGroup filePath = 
        let groupedBySurename = 
          readAndCount filePath
          |> Seq.groupBy (fun student  -> student.Surename) 
        
        groupedBySurename
        |> Seq.sortBy fst
        |> Seq.iter (fun (surename, students) ->  
          printfn " "
          printfn "%s:" surename 
          students
          |> Seq.sortBy(fun student -> student.GivenName)  
          |> Seq.iter Student.printGroupSummary
        )