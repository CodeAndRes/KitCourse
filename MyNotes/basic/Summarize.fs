namespace StudentScores
open System.IO

module Summarize =
  let readAndCount filePath = 
        let rows = File.ReadAllLines filePath
        let studentCount = (rows |> Array.length) - 1
        printfn "Student count: %i" studentCount
        rows
        |> Array.skip 1
        |> Array.map Student.fromString


  let summarize filePath = 
        readAndCount filePath
        |> Array.sortBy (fun student -> student.Surename)
        |> Array.iter Student.printSummary

  let sumarizeGroup filePath = 
        let groupedBySurename = 
          readAndCount filePath
          |> Array.groupBy (fun student  -> student.Surename) 
        
        groupedBySurename
        |> Array.sortBy fst
        |> Array.iter (fun (surename, students) ->  
          printfn " "
          printfn "%s:" surename 
          students
          |> Array.sortBy(fun student -> student.GivenName)  
          |> Array.iter Student.printGroupSummary
        )