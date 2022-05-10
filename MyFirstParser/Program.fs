open MyFirstParser.Query
open MyFirstParser.Books

let input = """
filterby Category = 'Fantasy'
orderby Rating asc 
take 1
"""
let books = getAll()
let result = parse input 

match result with 
  | Result.Ok res -> 
    let queryResult = execute res books 
    List.iter (fun i -> printfn "%O" i) queryResult
  | Result.Error res -> printfn "%O" res


