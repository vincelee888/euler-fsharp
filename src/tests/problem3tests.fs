module Euler.Tests.Problem3
    open NUnit.Framework
    open FsUnit
    open Euler.Problem3

    let ``prime number is only divisible by one and itself`` () =
      IsPrime 1L |> should equal True
      IsPrime 5L |> should equal True
      IsPrime 8L |> should equal False

    let ``solution`` () = 
      Solve 13195L |> should equal 29L