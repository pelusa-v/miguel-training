namespace FirstConsole;

public class Student : Person
{
    public string name;
    public int age;
    public string codigo;
    public string lastName;

    public Student(string _name, int _age, string _codigo, string _lastName)
    {
        name = _name;
        age = _age;
        codigo = _codigo;
        lastName = _lastName;
    }

    public void DarExamen()
    {
        Console.WriteLine($"El estudiante {name} está dando examen...");
        Respirar();
    }
}


// public class Student
// {
//     public string name;
//     public int age;
//     public string dni;
//     public bool Valid { get; set; }

//     public Student(string _name, int _age, string _dni)
//     {
//         name = _name;
//         age = _age;
//         dni = _dni;
//         Valid = _age < 17;
//     }


//     // private bool valid;

//     // // Getter
//     // public bool GetValid()
//     // {
//     //     return valid;
//     // }

//     // // Setter
//     // public void SetValid(bool _valid)
//     // {
//     //     Console.WriteLine($"El valor de valid se está modificando a {_valid}");
//     //     valid = _valid;
//     // }
// }
