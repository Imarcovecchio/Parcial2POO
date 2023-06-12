namespace Biblioteca
{
     public class Curso
    {
        //6)   La clase “Curso” que no necesita ser instanciada para utilizar implementará una colección interna de tipo Generic List de Alumno. Asimismo, 
        //contendrá una instancia de Docente e implementará un método MostrarListado (que recorrerá la colección de Alumnos y llamará al método abonar), 
        //Docente (que devolverá la instancia de Docente) y CantidadPago (que devolverá un entero que representará la cantidad de alumnos que abonaron). 
        //Implementará un método “Agregar” que recibirá como parámetro una Persona. Al arribar dicha instancia, en el método se evaluará si se trata de un Docente 
        //(en cuyo caso se asignará al curso) o un Alumno, en cuyo caso se agregará a la colección.  
        //7) Si se vuelve a Agregar un docente al Curso, debe lanzar una excepción que indique que ya tiene un docente asignado y lo debe atrapar el programa.

        private List<Alumno> alumnos;
        private Docente docente;

        public Curso(Docente docente)
        {
            alumnos = new List<Alumno>();
            this.docente = docente;
        }

        public void Agregar(Persona persona)
        {
            if (persona is Docente)
            {
                if (docente != null)
                {
                    throw new Exception("Ya se ha asignado un docente al curso.");
                }
                else
                {
                    docente = (Docente)persona;
                }
            }
            else if (persona is Alumno)
            {
                alumnos.Add((Alumno)persona);
            }
        }

        public void MostrarListado()
        {
            foreach (var alumno in alumnos)
            {
                alumno.Abonar();
            }
        }

        public Docente ObtenerDocente()
        {
            return docente;
        }

        public int CantidadPago()
        {
            int cantidadPago = 0;
            foreach (var alumno in alumnos)
            {
                if (!(alumno is AlumnoBecario))
                {
                    cantidadPago++;
                }
            }
            return cantidadPago;
        }
}
}