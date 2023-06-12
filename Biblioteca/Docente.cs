namespace Biblioteca
{
    public class Docente : Persona
    {
        public Docente(string Nombre, string Apellido, string DNI) : base(Nombre, Apellido, DNI)
        {
        }

        public override string Identificarse()
        {
            return $"{Nombre} {Apellido} - DNI: {DNI}";
        }
    }
}