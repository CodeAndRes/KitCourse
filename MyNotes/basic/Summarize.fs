namespace StudentScores
open System.IO

module Summarize =
  let readAndCount filePath = 
        let rows = 
            File.ReadLines filePath
            |> Seq.cache
        let studentCount = (rows |> Seq.length) - 1
        printfn "Student count: %i" studentCount
        rows
        |> Seq.skip 1
        |> Seq.map Student.fromString


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