namespace Classes

open System

type ConsolePrompt(message : string) =
  do
    if String.IsNullOrWhiteSpace(message) then 
        raise <| ArgumentException("Null or empty","message") 
  let trimmedMessage = message.Trim()

  member this.GetValue() =
      printf "%s: " trimmedMessage
      let input = Console.ReadLine()
      input