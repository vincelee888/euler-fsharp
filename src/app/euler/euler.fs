module Euler

  let IsMultipleOf3Or5 (x) =
    x % 3 = 0 || x % 5 = 0

  let Problem1 (input) = 

    seq { 0 .. input }
    |> Seq.filter (IsMultipleOf3Or5)
    |> Seq.sum