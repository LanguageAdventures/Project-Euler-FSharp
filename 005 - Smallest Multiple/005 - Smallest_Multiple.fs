let simplify =
    let arr = [|2L..20L|]
    for i = 0 to Array.length arr-2 do
        for j = i+1 to Array.length arr-1 do
            arr.[j] <- if arr.[j]%arr.[i] = 0L then arr.[j]/arr.[i] else arr.[j]
    arr

printfn "%i" (simplify |> Seq.fold (*) 1L)