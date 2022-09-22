using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce cuantas columnas tienen las matrices que desea sumar: ");
            int respuesta1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce cuantas filas tienen las matrices que desea sumar: ");
            int respuesta2 = int.Parse(Console.ReadLine());

            Matriz matrizUnoClase = new Matriz();
            int[] matrizUno = matrizUnoClase.setMatriz(respuesta1, respuesta2);
            int[] matrizDos = matrizUnoClase.setMatriz(respuesta1, respuesta2);
            int[] matrizTres = matrizUnoClase.setMatriz(respuesta1, respuesta2);


            Random aleatorio = new Random();

            for (int i = 0; i < matrizUno.Length; i++)
            {
                matrizUno[i] = aleatorio.Next(100);
                matrizDos[i] = aleatorio.Next(100);
            }

            SumarMatrices(matrizTres, matrizUno, matrizDos, respuesta2);
        }

        static void SumarMatrices(int[] matriz, int[] matrizPrim, int[] matrizSeg, int filas)
        {
            for (int i = 0; i < matriz.Length; i++)
            {
                matriz[i] = matrizPrim[i] + matrizSeg[i];
            }

            Console.WriteLine("El resultado de sumar las dos matrices es:");
            for (int i = 0; i < matriz.Length; i++)
            {
                if (i != 0 && i % filas == 0)
                {
                    Console.WriteLine(" ");
                }
                Console.Write(matriz[i] + "|");
            }
        }
    }
}

class Matriz
{
    private int[] matrizUno;
    private int[] matrizDos;
    private int[] matrizTres;
    private int filas = 0;

    public Matriz()
    {

    }

    public int[] setMatriz (int respuesta1, int respuesta2)
    {
        int [] matrizUno = new int[respuesta1 * respuesta2];
        return matrizUno;
    }

    public void SumarMatrices(int[] matriz, int[] matrizPrim, int[] matrizSeg, int filas)
    {
        for (int i = 0; i < matriz.Length; i++)
        {
            matriz[i] = matrizPrim[i] + matrizSeg[i];
        }

        Console.WriteLine("El resultado de sumar las dos matrices es:");    
        for (int i = 0; i < matriz.Length; i++)
        {
            if (i != 0 && i % filas == 0)
            {
                Console.WriteLine(" ");
            }
            Console.Write(matriz[i] + "|");
        }
    }
}
