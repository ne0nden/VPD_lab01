public class Main {
    public static void main(String[] args) {
        final String studentNameRu = "Горлов Владимир";
        final String studentNameEn = "Gorlov Vladimir";
        final int studentNumber = 8;
        final String groupName = "М3О-109БВ-26";
        final String languageName = "Java";

        final String studentId = String.format("%s/%02d", groupName, studentNumber);
        final int controlValue = 304 * studentNumber;

        System.out.printf("Hello to 304 from %s, number %d, group %s!%n", studentNameEn, studentNumber, groupName);
        System.out.printf("Привет, 304! Это %s, номер %d, группа %s!%n", studentNameRu, studentNumber, groupName);
        System.out.printf("Student ID: %s | Language: %s | Control: %d%n", studentId, languageName, controlValue);
    }
}