namespace StudentScores
open System.IO

module Summarize = 
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

// With Some and None results, because not including E in the count

  let Summarize filePath = 
        let rows = File.ReadAllLines filePath
        let studentCount = (rows |> Array.length) - 1
        printfn "Student count: %i" studentCount
        rows
        |> Array.skip 1
        |> Array.map Student.fromString
      //  |> Array.sortByDescending (fun student -> student.MeanScore)
        |> Array.sortBy (fun student -> student.Surename)
        |> Array.iter Student.printSummary
        