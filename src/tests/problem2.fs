module Euler.Tests.Problem2
    open NUnit.Framework
    open FsUnit
    open Euler.Problem2

    [<Test>]
    let ``term n is sum of term (n - 2) + (n - 1)`` () =
      let fibo = Euler.Problem2.GenerateFibonacciWithMaxValueLessThan(4)
      fibo |> should equal [1; 2; 3]

