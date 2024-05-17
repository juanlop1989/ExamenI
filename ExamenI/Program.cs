using ExamenI;


Console.WriteLine("**********************************************");
Console.WriteLine("******Examen I - Juan López - T32351200*******");
Console.WriteLine();



try

{
    Console.WriteLine("Ingrese nombre del alumno:");
    string nombreAlumno = Console.ReadLine();

    Console.WriteLine("Ingrese número de cuenta:");
    string numeroCuenta = Console.ReadLine();

    Console.WriteLine("Ingrese correo electrónico:");
    string email = Console.ReadLine();

    Console.WriteLine("Ingrese nombre de la clase:");
    string nombreAsignatura = Console.ReadLine();

    Console.WriteLine("Ingrese horario de la clase:");
    string horario = Console.ReadLine();

    Console.WriteLine("Ingrese nombre del docente:");
    string nombreDocente = Console.ReadLine();

    Console.WriteLine("Ingrese nota del primer parcial:");
    int n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese nota del segundo parcial:");
    int n2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese nota del tercer parcial:");
    int n3 = int.Parse(Console.ReadLine());

    Console.WriteLine();

    // Validar notas del primer y segundo parcial
    if (n1 > 30 || n2 > 30)
    {
        throw new Exception("La nota del primer o segundo parcial no puede ser mayor a 30");
    }

    // Validar nota del tercer parcial
    if (n3 > 40)
    {
        throw new Exception("La nota del tercer parcial no puede ser mayor a 40");
    }

    // Crear instancia de la clase Asignatura
    Asignatura asignatura = new Asignatura(nombreAlumno, numeroCuenta, email, n1, n2, n3, nombreAsignatura, horario, nombreDocente);

    // Imprimir los datos del alumno, la asignatura y las notas finales
    asignatura.Imprimir();
}

catch (Exception)
{
    Console.WriteLine("Una de las notas ingresadas no tiene el formato válido");
}