using System;

internal record Student(
    string NameRu,
    string NameEn,
    int Number,
    string Group,
    string Language
);

internal class Program
{
    private static void Main()
    {
        Student student = new(
            NameRu: "Горлов Владимир",
            NameEn: "Gorlov Vladimir",
            Number: 8,
            Group: "М3О-109БВ-26",
            Language: "C#"
        );

        string studentId = $"{student.Group}/{student.Number:D2}";
        int controlValue = 304 * student.Number;

        Console.WriteLine($"Hello to 304 from {student.NameEn}, number {student.Number}, group {student.Group}!");
        Console.WriteLine($"Привет, 304! Это {student.NameRu}, номер {student.Number}, группа {student.Group}!");
        Console.WriteLine($"Student ID: {studentId} | Language: {student.Language} | Control: {controlValue}");
    }
}