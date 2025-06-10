using System.ComponentModel;

namespace _2._1
{

    


    internal class Program
    {

        #region definri var
        static int[] numeros;
        static int indice,numeroBuscar;

        #endregion
        static void ordenar()
        {
            for (int piv1 = 0; piv1 < numeros.Length - 1; piv1++)
            {
                for (int piv2 = piv1 + 1; piv2 < numeros.Length; piv2++)
                {
                    if (numeros[piv1] > numeros[piv2])
                    {
                        int aux = numeros[piv2];
                        numeros[piv2] = numeros[piv1];
                        numeros[piv1] = aux;



                    }
                }
            }
        }
        static void MostrarPantallaVectorOrdenado()
        {
            Console.WriteLine("Numeros ordenados, Presione una tecla para mostrarlos");
            Console.ReadKey();

            for (int e = 0; e < numeros.Length; e++)
            {

                Console.Write($"{e}:{numeros[e]}---");
            }
        }


        static void MostrarPantallaVectorLleno()
        {
            for (int e = 0; e < numeros.Length; e++)
            {

                Console.Write($"{e}:{numeros[e]} --- ");
            }
        }
        static void LlenarVector()
        {
            #region LLenar vector de numeros 
            for (int i = 0; i < numeros.Length; i++)
            {
                Random rnd = new Random();
                int numeroAleatorio;

                do
                {
                    numeroAleatorio = rnd.Next(0, 200);
                }
                while (VerificarExiste(numeros, i, numeroAleatorio));

                numeros[i] = numeroAleatorio;
                
            }
            #endregion
        }
        static bool VerificarExiste(int[]numeros, int indice,int valor)
        {

            for (int j = 0; j < indice; j++)
            {
                if (numeros[j] == valor)
                {
                    return true;
                }

            }
            return false;
        }
        static void MostrarPantallaNumeroEncontrado()
        {
            if (indice != -1)
            {
                Console.WriteLine($"Posicion {indice}:{numeroBuscar}");
            }
            else
            { Console.WriteLine($"El numero no se encontro {indice}"); }

        }
        static void buscarnumero()
        {
            Random rnd2 = new Random();

            numeroBuscar = rnd2.Next(0, 200);
            Console.WriteLine("");
            Console.WriteLine($"El numero que se va a buscar es {numeroBuscar}");

            indice = -1;
            for (int bus = 0; bus < numeros.Length && indice == -1; bus++)
            {
                if (numeros[bus] == numeroBuscar)
                {
                    indice = bus;
                }
            }
            

        }

        static void Main(string[] args)
        {
            


            #region iniciar var
            numeros = new int[100];

            #endregion

            LlenarVector();
            MostrarPantallaVectorLleno();
            Console.WriteLine("");
            Console.WriteLine("Presione una tecla para ordenar ");
            Console.ReadKey();
            Console.Clear();
            ordenar();
            MostrarPantallaVectorOrdenado();



            #region generar valor para buscar
            buscarnumero();

            MostrarPantallaNumeroEncontrado();


           
            

            Console.ReadKey();
            #endregion


        }
    }
}
