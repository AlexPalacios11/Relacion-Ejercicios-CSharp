namespace Ejercicio11
{
    struct Vector3
    {
        private int x;
        private int y;
        private int z;

        public int X { get => x; set => x = value; }
        public int Y { get => y;set => y = value; }
        public int Z { get => z;set => z = value; }

        public Vector3(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public Vector3() : this(0, 0, 0)
        {
        }
        public Vector3 Sumar(Vector3 vector)
        {
            return new Vector3(vector.X + X, vector.Y + Y, vector.Z + Z);
        }
        public double Distancia(Vector3 vector)
        {
            double x2 = Math.Pow(vector.X - X, 2);
            double y2 = Math.Pow(vector.Y - Y, 2);
            double z2 = Math.Pow(vector.Z - Z, 2);

            return Math.Sqrt(x2 + y2 + z2);
        }
    }
}
