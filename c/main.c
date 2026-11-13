#include <stdio.h>
#include <windows.h>

int main(void)
{
    SetConsoleCP(CP_UTF8);
    SetConsoleOutputCP(CP_UTF8);

    const char *student_name_ru = "Горлов Владимир";
    const char *student_name_en = "Gorlov Vladimir";
    int student_number = 8;
    const char *group_name = "М3О-109БВ-26";
    const char *language_name = "C";

    int control_value = 304 * student_number;

    printf("Hello to 304 from %s, number %d, group %s!\n", student_name_en, student_number, group_name);
    printf("Привет, 304! Это %s, номер %d, группа %s!\n", student_name_ru, student_number, group_name);
    printf("Student ID: %s/%02d | Language: %s | Control: %d\n", group_name, student_number, language_name, control_value);

    return 0;
}