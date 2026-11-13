fn main() {
    let student_name_ru: &str = "Горлов Владимир";
    let student_name_en: &str = "Gorlov Vladimir";
    let student_number: u32 = 8;
    let group_name: &str = "М3О-109БВ-26";
    let language_name: &str = "Rust";

    let student_id: String = format!("{group_name}/{student_number:02}");
    let control_value: u32 = 304 * student_number;

    println!("Hello to 304 from {student_name_en}, number {student_number}, group {group_name}!");
    println!("Привет, 304! Это {student_name_ru}, номер {student_number}, группа {group_name}!");
    println!("Student ID: {student_id} | Language: {language_name} | Control: {control_value}");
    println!("Student ID: {student_id}");
    println!("Length of student_name_en: {}", student_name_en.len());
}