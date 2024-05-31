namespace FirstConsole;

public class Teacher : Person
{
    public string name;
    public int classroom;
    public int age;

    public Teacher(string _name, int _classroom, int _age)
    {
        name = _name;
        classroom = _classroom;
        age = _age;
    }

    public void TomarExamen()
    {
        Console.WriteLine($"El profesor {name} está tomando examen al aula {classroom}...");
    }
}
