﻿#r "../Microsoft.Z3.dll"
#r "../Z3Fs/bin/Debug/Z3Fs.dll"

open Microsoft.Z3
open Microsoft.Z3.FSharp
open Common
open Bool
open Int
open Real

// Reference from http://rise4fun.com/Z3Py/simple

// Declare three Real variables
let x = Real("x")
let y =  Real("y")
let z =  Real("z");;

// Solve linear problem
Z3.Solve(x >=. 1.0,
         y >=. 1.0,
         z >=. 1.0,
         x =. y + z,
         x + y <=. 4.0)