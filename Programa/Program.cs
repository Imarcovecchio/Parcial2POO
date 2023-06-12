using System;
using Biblioteca;

namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Docente docente = new Docente("Juan", "Marcovecchio", "12345678");

            Curso curso = new Curso(docente);

            AlumnoRegular alumnoRegular1 = new AlumnoRegular("Juan", "Perez", "11111111", "A001");
            AlumnoRegular alumnoRegular2 = new AlumnoRegular("Maria", "Gomez", "22222222", "A002");
            AlumnoRegular alumnoRegular3 = new AlumnoRegular("Pedro", "Lopez", "33333333", "A003");

            AlumnoBecario alumnoBecario1 = new AlumnoBecario("Ana", "Martinez", "44444444", "B001");
            AlumnoBecario alumnoBecario2 = new AlumnoBecario("Luis", "Rodriguez", "55555555", "B002");

            curso.Agregar(alumnoRegular1);
            curso.Agregar(alumnoRegular2);
            curso.Agregar(alumnoRegular3);
            curso.Agregar(alumnoBecario1);
            curso.Agregar(alumnoBecario2);

            Console.WriteLine("Cantidad de alumnos que pagan: " + curso.CantidadPago());

            Console.WriteLine("Datos del docente:");
            Console.WriteLine(curso.ObtenerDocente().Identificarse());

            Console.ReadLine();
        }
    }
}
