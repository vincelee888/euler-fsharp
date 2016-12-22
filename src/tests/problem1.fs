module Euler.Tests.Problem1
    open NUnit.Framework
    open FsUnit
    open Euler.Problem1

    [<Test>]
    let ``3 is multiple of 3`` () =
      Euler.Problem1.IsMultipleOf3Or5(3) |> should be True

    [<Test>]
    let ``5 is multiple of 5`` () =
      Euler.Problem1.IsMultipleOf3Or5(5) |> should be True

    [<Test>]
    let ``3 begets 3``() = 
      Euler.Problem1.Solve(3) |> should equal 3

    [<Test>]
    let ``5 begets 3 plus 5``() = 
      Euler.Problem1.Solve(5) |> should equal 8

    [<Test>]
    let ``10 begets 23``() = 
      Euler.Problem1.Solve(9) |> should equal 23
