namespace SomeFSharpLibrary
open System

type Customer = { First : string; Last: string; SSN: uint32 option; AccountNumber : uint32; }

module Customers=
    let oskarOhlsson = {First="Oskar"; Last="Ohlsson"; SSN=None; AccountNumber= 1u}
    let fredrikKarlsson = {First="Fredrik"; Last="Karlsson"; SSN=Some(123565465u); AccountNumber= 1u}
    let all= [ 
        oskarOhlsson
        fredrikKarlsson
   ]