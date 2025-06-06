namespace Ej1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region def var
            int numero,contador,num_may,num_men,indice_may,indice_men;
            int[] numeros;
            double acumulador, prom;
            #endregion

            #region inic var
            numeros = new int[100];
            acumulador = 0;
            contador = 0;
            num_may = 0;
            indice_may = 0;
            num_men = 0;
            indice_men = 0;

            #endregion

            #region carga de numeros 
            Console.WriteLine("Ingrese un numero a guardar (-1 para cortar)");
            numero = Convert.ToInt32(Console.ReadLine());

            while (numero !=-1)
            {

                numeros [contador] = numero;
                contador++;
                

                Console.WriteLine("Ingrese el siguiente  numero a guardar (-1 para cortar)");
                numero = Convert.ToInt32(Console.ReadLine());
            }
            #endregion


            #region recorrer vector
            for (int i=0; i < contador; i++)
            {
                acumulador += numeros[i];
                if (numeros[i]>num_may || i==0)
                {
                    num_may = numeros[i];
                    indice_may = i;
                }
                if (numeros[i]<num_men || i==0)
                {
                    num_men=numeros[i];
                    indice_men=i;
                }

            }
            #endregion



            if (contador > 0)
            {
                #region mostrar

                for (int e = 0; e < contador; e++)
                {
                    Console.Write($"{e}:{numeros[e],-3}");
                }
                prom = 1.0 * acumulador / contador;
                Console.WriteLine($"El promedio es {prom}");
                Console.WriteLine($"El mayor es {num_may} en la posicion {indice_may}= {indice_may}:{num_may}");
                Console.WriteLine($"El menor es {num_men} en la posicion {indice_men}= {indice_men}:{num_men}");
                #endregion

            }
            else
            {
                Console.WriteLine("No se ingresaron numeros");
            }


           

        }
    }
}
