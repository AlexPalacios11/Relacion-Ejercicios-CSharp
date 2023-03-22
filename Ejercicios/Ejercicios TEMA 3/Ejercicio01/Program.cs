namespace Ejercicio01;

class Program
{
    static void Main(string[] args)
    {
        int[,] matriz1 = new int[3, 3] { { 1, 2, 3 }, { 0, 1, 0 }, { 3, 2, 1 } };
        int[,] matriz2 = new int[3, 2] { { 1, -1 }, { 0, 2 }, { -2, 0 } };
        int[,] matriz3 = new int[3, 3] { { 1, 4, 0 }, { -6, 5, 2 }, { 4, 1, 8 } };

        SumaMatrices(matriz1, matriz3);
        Console.WriteLine();
        Traspuesta(matriz2);
        Console.WriteLine();
        MultiplicacionMatrices(matriz1, matriz2);



        //-------------------------------------------------------------------

        static void MostrarMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i,j] + "\t");
                }
                Console.WriteLine();
            }
        }
        //-------------------------------------------------------------------

        static void SumaMatrices(int[,] matriz1, int[,] matriz2)
        {          
            if (matriz1.GetLength(0) != matriz2.GetLength(0) || matriz1.GetLength(1) != matriz2.GetLength(1) )
            {
                throw new Exception("No se puede realizar la operación");
            }
            else
            {
                int[,] result = new int[matriz1.GetLength(0), matriz1.GetLength(1)];

                for (int i = 0; i < matriz1.GetLength(0); i++) 
                {
                    for (int j = 0; j < matriz1.GetLength(1); j++)
                    {
                        result[i,j] = matriz1[i,j] + matriz2[i,j];
                    }
                }
                MostrarMatriz(result);
            }
        }

        //------------------------------------------------------------------------

        static void Traspuesta(int[,] matriz)
        {
            int[,] result = new int[matriz.GetLength(1), matriz.GetLength(0)];

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j] = matriz[j, i];
                }
            }
            MostrarMatriz(result);
        }

        //-------------------------------------------------------------------

        static void MultiplicacionMatrices(int[,] matriz1, int[,] matriz2)
        {
            if (matriz1.GetLength(1) != matriz2.GetLength(0))
            {
                throw new Exception("No se puede realizar la operación");
            }           
            else
            {
                int[,] result = new int[matriz1.GetLength(0), matriz2.GetLength(1)];

                for (int i = 0; i < result.GetLength(0); i++)
                {
                    for (int j = 0; j < result.GetLength(1); j++)
                    {
                        for (int k = 0; k < matriz1.GetLength(1); k++)
                        {
                            result[i, j] += matriz1[i, k] * matriz2[k, j];
                        }
                    }
                }
                MostrarMatriz(result);
            }
            
        }
    }
}