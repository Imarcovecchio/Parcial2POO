namespace Biblioteca
{
     public class Alumno : Persona
    {
        public string Legajo { get; }

        public Alumno(string nombre, string apellido, string dni, string legajo) : base(nombre, apellido, dni)
        {
            Legajo = legajo;
        }

        public virtual void Abonar()
        {
            Console.WriteLine("No debe abonar cuota");
        }

        public override string Identificarse()
        {
            return $"{Nombre} {Apellido} - Legajo: {Legajo}";
        }
    }

}