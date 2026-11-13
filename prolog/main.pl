:- encoding(utf8).

student("Горлов Владимир", "Gorlov Vladimir", 8, "М3О-109БВ-26", "Prolog").

calc_student_data(ControlValue, StudentId) :-
    student(_, _, Number, Group, _),
    ControlValue is 304 * Number,
    format(string(StudentId), '~w/~|~`0t~d~2+', [Group, Number]).

print_info :-
    student(NameRu, NameEn, Number, Group, Language),
    calc_student_data(ControlValue, StudentId),
    format('Hello to 304 from ~w, number ~w, group ~w!~n', [NameEn, Number, Group]),
    format('Привет, 304! Это ~w, номер ~w, группа ~w!~n', [NameRu, Number, Group]),
    format('Student ID: ~w | Language: ~w | Control: ~w~n', [StudentId, Language, ControlValue]),
    string_length(NameEn, Len),
    format('Length of student_name_en: ~w~n', [Len]).

main :-
    print_info.