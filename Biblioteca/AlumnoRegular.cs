namespace Biblioteca
{
    public class AlumnoRegular : Alumno
    {
        public AlumnoRegular(string nombre, string apellido, string dni, string legajo) : base(nombre, apellido, dni, legajo)
        {
        }

        public override void Abonar()
        {
            Console.WriteLine("Abonar valor cuota: 1000");
        }
    }
}