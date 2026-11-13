interface Student {
    nameRu: string;
    nameEn: string;
    number: number;
    group: string;
    language: string;
}

const student: Student = {
    nameRu: "Горлов Владимир",
    nameEn: "Gorlov Vladimir",
    number: 8,
    group: "М3О-109БВ-26",
    language: "TypeScript",
};

const studentId: string = `${student.group}/${String(student.number).padStart(2, "0")}`;
const controlValue: number = 304 * student.number;

console.log(`Hello to 304 from ${student.nameEn}, number ${student.number}, group ${student.group}!`);
console.log(`Привет, 304! Это ${student.nameRu}, номер ${student.number}, группа ${student.group}!`);
console.log(`Student ID: ${studentId} | Language: ${student.language} | Control: ${controlValue}`);