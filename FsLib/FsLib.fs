module FcMixed.FsLib

let fsLibFn () =
    sprintf "calling into F# %s" (System.DateTimeOffset.UtcNow.ToString "yyyy-MM-ddTHH:mm:ssZ")
