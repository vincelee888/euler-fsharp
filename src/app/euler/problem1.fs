module Euler.Problem1

  let IsMultipleOf3Or5 (x) =
    x % 3 = 0 || x % 5 = 0

  let Solve (input) = 

    seq { 0 .. input }
    |> Seq.filter (IsMultipleOf3Or5)
    |> Seq.sum