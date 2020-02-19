module com.mousezero.fmt.core_test

open NUnit.Framework
open com.mousezero.fmt.core

[<Test>]
let Test1 () =
  Assert.AreEqual(5, createTradingTape())
