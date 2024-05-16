using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenI
{
    public class Alumno
    {
        public string nombreAlumno;
        public string numeroCuenta;
        public string email;

        public Alumno(string nombreAlumno, string numeroCuenta, string email)
        {
            this.nombreAlumno = nombreAlumno;
            this.numeroCuenta = numeroCuenta;
            this.email = email;
        }

        public string NombreAlumno { get => nombreAlumno; set => nombreAlumno = value; }
        public string NumeroCuenta { get => numeroCuenta; set => numeroCuenta = value; }
        public string Email { get => email; set => email = value; }
    }
}
