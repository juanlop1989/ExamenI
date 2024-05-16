using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenI
{
    public class Asignatura : Alumno, IAsignatura
    {
        public string nombreAsignatura;
        public string horario;
        public string nombreDocente;
        public int n1;
        public int n2;
        public int n3;

      

        public Asignatura(string nombreAlumno, string numeroCuenta, string email, int n1, int n2, int n3, string nombreAsignatura, string horario, string nombreDocente)
            : base(nombreAlumno, numeroCuenta, email)
        {
            this.nombreAsignatura = nombreAsignatura;
            this.horario = horario;
            this.nombreDocente = nombreDocente;
            this.n1 = n1;
            this.n2 = n2;
            this.n3 = n3;
        }

        //public Asignatura(string nombreAlumno, string numeroCuenta, string email, int n1, int n2, int n3, string? nombreAsignatura, string? horario, string? nombreDocente) : base(nombreAlumno, numeroCuenta, email)
        //{
        //}

        public string NombreAsignatura { get => nombreAsignatura; set => nombreAsignatura = value; }
        public string Horario { get => horario; set => horario = value; }
        public string NombreDocente { get => nombreDocente; set => nombreDocente = value; }
        public int N1 { get => n1; set => n1 = value; }
        public int N2 { get => n2; set => n2 = value; }
        public int N3 { get => n3; set => n3 = value; }

        public double CalcularNotaFinal()
        {
            return n1 + n2 + n3;
        }

        public double CalcularNotaFinal(double nota1, double nota2, double nota3)
        {
            return nota1 + nota2 + nota3;
        }

        public void Imprimir()
        {
            Console.WriteLine("*************************");
            Console.WriteLine("Nombre del estudiante: " + NombreAlumno);
            Console.WriteLine("Número de cuenta: " + NumeroCuenta);
            Console.WriteLine("Correo electrónico: " + Email);
            Console.WriteLine("Nombre de la clase: " + NombreAsignatura);
            Console.WriteLine("Horario: " + Horario);
            Console.WriteLine("Nombre del docente: " + NombreDocente);
            Console.WriteLine("Nota Final: " + CalcularNotaFinal() + " - " + MensajeNotaFinal(CalcularNotaFinal()));
            Console.WriteLine("Nota Final: " + CalcularNotaFinal(N1, N2, N3) + " - " + MensajeNotaFinal(CalcularNotaFinal(N1, N2, N3)));
            Console.WriteLine("*************************");
        }

        public string MensajeNotaFinal(double notaFinal)
        {
            if (notaFinal >= 0 && notaFinal <= 59)
            {
                return "Reprobado";
            }
            else if (notaFinal >= 60 && notaFinal <= 79)
            {
                return "Bueno";
            }
            else if (notaFinal >= 80 && notaFinal <= 89)
            {
                return "Muy Bueno";
            }
            else if (notaFinal >= 90 && notaFinal <= 100)
            {
                return "Sobresaliente";
            }
            else
            {
                return "Nota inválida";
            }
        }
    }
}
