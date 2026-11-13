#!/usr/bin/env bash

student_name_ru="Горлов Владимир"
student_name_en="Gorlov Vladimir"
student_number=8
group_name="М3О-109БВ-26"
language_name="Bash"

student_id=$(printf "%s/%02d" "$group_name" "$student_number")
control_value=$((304 * student_number))

echo "Hello to 304 from ${student_name_en}, number ${student_number}, group ${group_name}!"
echo "Привет, 304! Это ${student_name_ru}, номер ${student_number}, группа ${group_name}!"
echo "Student ID: ${student_id} | Language: ${language_name} | Control: ${control_value}"

words_count=$(printf "%s" "$student_name_en" | wc -w | tr -d ' ')
chars_count=$(printf "%s" "$student_name_en" | wc -m | tr -d ' ')

echo "Length of student_name_en: ${chars_count} | Words count: ${words_count}"