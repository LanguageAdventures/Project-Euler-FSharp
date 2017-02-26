let diver(n : int64) =
    let rec div n d =
        if n = d then n
        else if n%d = 0L then
            div (n/d) d
        else
            div n (d+2L)
    div n 3L
    
printfn "%i" (diver 600851475143L)