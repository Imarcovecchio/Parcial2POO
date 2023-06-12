namespace Biblioteca;
public abstract class Persona
    {
        public string Nombre { get; }
        public string Apellido { get; }
        public string DNI { get; }

        protected Persona(string nombre, string apellido, string dni)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
        }

        public abstract string Identificarse();
    }