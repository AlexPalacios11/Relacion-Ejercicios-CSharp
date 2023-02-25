namespace Ejercicio08
{
    abstract class Empleado
    {
        protected const int PLUS = 300;

        private string nombre;
        private int edad;
        private int salario;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Salario { get => salario; set => salario = value; }

        public Empleado(string nombre, int edad, int salario)
        {
            this.nombre= nombre;
            this.edad= edad;
            this.salario= salario;
        }
        public override string ToString()
        {
            return $"Nombre: {nombre}\nEdad: {edad}\nSalario: {salario}\n";
        }
        public abstract void AplicarPlus();


    }
}
