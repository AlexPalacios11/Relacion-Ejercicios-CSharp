using System.ComponentModel;

namespace Ejercicio03
{
    internal class Password
    {
        private const int LONGITUD_DEFAULT = 8;

        private int longitud;
        private string contrasena;

        public int Longitud { get => longitud; set => longitud = value; }
        public string Contrasena { get => contrasena; }

        public Password(int longitud)
        {
            this.longitud = longitud;
            this.contrasena = GenerarPassword();
        }
        public Password() : this(LONGITUD_DEFAULT)
        {
        }
        public bool EsFuerte()
        {
            int mayuscula = 0;
            int minuscula = 0;
            int numero = 0;

            for (int i = 0; i<longitud;i++)
            {
                if (char.IsNumber(contrasena[i])) numero++;
                else if (char.IsLower(contrasena[i])) minuscula++;
                else if (char.IsUpper(contrasena[i])) mayuscula++;
            }

            return mayuscula > 2 && minuscula > 1 && numero > 5;
        }
        private string GenerarPassword()
        {
            Random random = new Random();
            string result = "";

            for (int i = 0; i < longitud; i++)
            {
                result += (char)random.Next('0', 'z');
            }


            return result;
        }
    }
}
