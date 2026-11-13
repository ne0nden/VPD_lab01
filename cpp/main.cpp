#include <iostream>
#include <iomanip>
#include <string>
#include <sstream>
#include <windows.h>


int main()
{
    SetConsoleCP(CP_UTF8);
    SetConsoleOutputCP(CP_UTF8);

    const std::string student_name_ru = "Горлов Владимир";
    const std::string student_name_en = "Gorlov Vladimir";
    const int student_number = 8;
    const std::string group_name = "М3О-109БВ-26";
    const std::string language_name = "C++";

    std::ostringstream oss;
    oss << group_name << "/" << std::setw(2) << std::setfill('0') << student_number;
    const std::string student_id = oss.str();

    const int control_value = 304 * student_number;

    std::cout << "Hello to 304 from " << student_name_en
              << ", number " << student_number
              << ", group " << group_name << "!\n";

    std::cout << "Привет, 304! Это " << student_name_ru
              << ", номер " << student_number
              << ", группа " << group_name << "!\n";

    std::cout << "Student ID: " << student_id
              << " | Language: " << language_name
              << " | Control: " << control_value << "\n";

    return 0;
}