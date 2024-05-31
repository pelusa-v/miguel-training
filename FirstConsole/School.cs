namespace FirstConsole;

public class School
{
    private const int _DefaultClassroom = 500;
    private const string _DefaultTeacher = "Jorge";
    private const int _DefaultTeacherAge = 50;
    public string name;
    public int number;
    public Teacher teacher;
    public List<Student> students;

    public School(string _name, int _number)
    {
        name = _name;
        number = _number;

        teacher = new Teacher(_DefaultTeacher, _DefaultClassroom, _DefaultTeacherAge);
        students = new List<Student>()
        {
            new Student("Alberto", 14, "712771271", ""),
            new Student("Juan", 14, "712771271", ""),
            new Student("Rosa", 14, "712771271", ""),
            new Student("Micaela", 13, "712771271", ""),
            new Student("Pepe", 14, "712771271", ""),
            new Student("Juan2", 14, "712771271", ""),
        };
    }

    public void EmpezarExamenes()
    {
        Console.WriteLine("La etapa de exámenes ha comenzado");
        
        teacher.TomarExamen();
        foreach (var student in students)
        {
            student.DarExamen();
        }
    }
}
