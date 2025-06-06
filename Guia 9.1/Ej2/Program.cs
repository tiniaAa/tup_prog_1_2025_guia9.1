namespace Ej2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region definir variables 
            int[] libretas;
            double[] notas;
            string[] alumnos;
            int res, contador,lib_may,lib_men ;
            double nota,acumulador,nota_may,nota_men,prom;
            string nom,nom_may,nom_men;

            #endregion
            #region inicializar variables 
            libretas = new int[100];
            notas = new double[100];
            alumnos = new string[100];
            contador = 0;
            acumulador = 0;
            nota_may = 0;
            lib_may = 0;

            nota_men = 0;
            lib_men = 0;

            nom_men = "s";
            nom_may = "s";

            #endregion
            Console.WriteLine("Desea cargar libretas ?\n1=si\n2=no");
            res = Convert.ToInt32(Console.ReadLine());

            while (res==1)
            {
                Console.Write("Ingrese nombre del alumno ");
                nom = Console.ReadLine();
                alumnos[contador] = nom;
                Console.Write($"Ingrese la nota de la libreta de {nom}");
                libretas[contador] = contador;
                nota=Convert.ToDouble(Console.ReadLine());
                notas[contador] = nota;

                contador++; 

                Console.WriteLine("Desea cargar otra libreta ?\n1=si\n2=no");
                res = Convert.ToInt32(Console.ReadLine());

            }
            
            if (contador > 0)
            {
                for (int i = 0; i < contador; i++)
                {
                    acumulador += notas[i];
                    
                    if (notas[i]>nota_may || i==0)
                    {
                        nota_may = notas[i];
                        nom_may = alumnos[i];
                        lib_may = libretas[i];
                    }
                    if (notas[i]<nota_men || i == 0)
                    {
                        nota_men = notas[i];
                        nom_men = alumnos[i];
                        lib_men = libretas[i];

                    }

                }

                prom = 1.0 * acumulador / contador;
                Console.WriteLine($"El promedio de las libretas es de {prom}");
                Console.WriteLine($"El alumno con la menor nota es {nom_men} con la libreta {lib_men+1} y nota de {nom_men}");
                Console.WriteLine($"El aulmno con la mayor nota es {nom_may} con la libreta {lib_may+1} y con nota de {nota_may}");


            }
            else
            {
                Console.WriteLine("No se cargaron libretas ");
            }





        }
    }
}
