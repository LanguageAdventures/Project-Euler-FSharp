let fibber = Seq.unfold(fun(a, b) -> Some(a+b, (b, a+b))) (0, 1)
printfn "%i" (fibber 
                |> Seq.takeWhile(fun n -> n<4000000) 
                |> Seq.filter(fun n -> n%2 = 0) 
                |> Seq.sum)
