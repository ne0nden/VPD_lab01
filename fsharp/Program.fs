open System

type Student = {
    NameRu: string
    NameEn: string
    Number: int
    Group: string
    Language: string
}

[<EntryPoint>]
let main _ =
    let student = {
        NameRu = "Горлов Владимир"
        NameEn = "Gorlov Vladimir"
        Number = 8
        Group = "М3О-109БВ-26"
        Language = "F#"
    }

    let studentId = sprintf "%s/%02d" student.Group student.Number
    let controlValue = 304 * student.Number

    printfn "Hello to 304 from %s, number %d, group %s!" student.NameEn student.Number student.Group
    printfn "Привет, 304! Это %s, номер %d, группа %s!" student.NameRu student.Number student.Group
    printfn "Student ID: %s | Language: %s | Control: %d" studentId student.Language controlValue

    let wordLengths =
        student.NameEn.Split([| ' ' |], StringSplitOptions.RemoveEmptyEntries)
        |> Array.map (fun word -> word.Length)

    let totalLength = wordLengths |> Array.sum
    let wordsCount = wordLengths |> Array.length

    printfn "Words count: %d | Total characters without spaces: %d" wordsCount totalLength

    0