namespace SomeFSharpLibrary

type Customer = { First : string; Last: string; SSN: uint32 option; AccountNumber : uint32; }

module Customers=
    val oskarOhlsson: Customer
    val fredrikKarlsson: Customer
    val all: Customer list