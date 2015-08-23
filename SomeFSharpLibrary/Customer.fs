namespace SomeFSharpLibrary
open System

type Customer = { First : string; Last: string; SSN: uint32 option; AccountNumber : uint32; }

module Customers=
    let oskarOhlsson = {First="Oskar"; Last="Ohlsson"; SSN=None; AccountNumber= uint32(1)}
    let fredrikKarlsson = {First="Fredrik"; Last="Karlsson"; SSN=Some(uint32(123565465)); AccountNumber= uint32(1)}
    let all=[ 
        oskarOhlsson
        fredrikKarlsson
   ]