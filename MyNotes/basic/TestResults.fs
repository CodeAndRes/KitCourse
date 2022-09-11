namespace StudentScores

type TestResults = 
    | Absent
    | Excused
    | Voided
    | Scored of float

module TestResult = 
    let fromString s = 
        if s = "A" then
            Absent
        elif s = "E" then 
            Excused
        else  
            let value = s |> float
            Scored value

// With Some and None results, because not including E in the count 
    let effectiveScore (testResult : TestResults) = 
        match testResult with 
        | Absent -> Some 0.0
        | Excused 
        | Voided -> None
        | Scored score -> Some score