package main

import "fmt"

func main() {
	var studentNameRu string = "Горлов Владимир"
	var studentNameEn string = "Gorlov Vladimir"
	var studentNumber int = 8
	var groupName string = "М3О-109БВ-26"
	var languageName string = "Go"

	studentID := fmt.Sprintf("%s/%02d", groupName, studentNumber)
	controlValue := 304 * studentNumber

	fmt.Printf("Hello to 304 from %s, number %d, group %s!\n", studentNameEn, studentNumber, groupName)
	fmt.Printf("Привет, 304! Это %s, номер %d, группа %s!\n", studentNameRu, studentNumber, groupName)
	fmt.Printf("Student ID: %s | Language: %s | Control: %d\n", studentID, languageName, controlValue)
	fmt.Printf("Length of student_name_en: %d\n", len(studentNameEn))
}
