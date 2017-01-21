module Euler.Problem3

  let AppendSelf x = 
    match x with
    | 1L -> []
    | _ -> [x]

  let GetFactors x =
    let max = int64(sqrt(float x))
    let append = AppendSelf(x)
    let range = List.append [1L .. max] append
    List.filter (fun f -> x % f = 0L) range

  let IsPrime x =
    let factors = GetFactors(x)
    match factors with
    | [1L; x] -> true
    | _ -> false

  let Solve x =
    let max = int64(sqrt(float x))
    [1L .. max]
    |> List.filter (fun f -> x % f = 0L)
    |> List.filter (fun f -> IsPrime(f))
    |> List.max