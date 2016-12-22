module Euler.Problem2

  open System.Numerics
  let fibonacci = 
    Seq.unfold(fun (a, b) -> Some(a, (b, a+b)))(0, 1)

  let GenerateFibonacciWithMaxValueLessThan (maxValue) =
    fibonacci
    |> Seq.skip(2)
    |> Seq.takeWhile(fun n -> n < maxValue)

  let Solve (maxValue) =
    let fibo = GenerateFibonacciWithMaxValueLessThan(maxValue)
    fibo
    |> Seq.filter(fun n -> n % 2 = 0)
    |> Seq.sum