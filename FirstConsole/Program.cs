// See https://aka.ms/new-console-template for more information
using FirstConsole;

Console.WriteLine("Hello, World!");

// WITHOUT DI
var school = new School("Colegio nacional 2", 2);
school.EmpezarExamenes();


Console.WriteLine("----------------------------");

// WITH DI
var teacher = new Teacher("Jorge", 500, 50);
var students = new List<Student>()
{
    new Student("Alberto", 14, "712771271", ""),
    new Student("Juan", 14, "712771271", ""),
    new Student("Rosa", 14, "712771271", ""),
    new Student("Micaela", 13, "712771271", ""),
    new Student("Pepe", 14, "712771271", ""),
    new Student("Juan2", 14, "712771271", ""),
};

var school2 = new School2("Colegio nacional 2", 2, teacher, students);
school2.EmpezarExamenes();
