namespace FirstConsole;

public class School2
{
    public string name;
    public int number;
    public Teacher teacher;
    public List<Student> students;

    public School2(string _name, int _number, Teacher _teacher, List<Student> _students)
    {
        name = _name;
        number = _number;
        teacher = _teacher;
        students = _students;
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
