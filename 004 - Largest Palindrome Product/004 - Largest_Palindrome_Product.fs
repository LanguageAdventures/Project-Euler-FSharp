open System.Linq

let isPalindromic n =
    let s = n.ToString().ToCharArray()
    s = Array.rev s
 
let products =  [for x in 100..999 do
                 for y in 100..999 do
                    yield x*y]

printfn "%i" (products |> Seq.filter isPalindromic |> Seq.max)
