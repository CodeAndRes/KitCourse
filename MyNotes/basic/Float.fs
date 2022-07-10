namespace StudentScores

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