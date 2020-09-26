using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1_Audry_Spence_Vargas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**Eliga la opcion que desea ejecutar***" +
                "\n1.Area de un triangulo"  +
                "\n2.Conversion dolares-colones" +
                "\n3.Comparando edades" +
                "\n4.Coversion grados centrigrados-grados fahrenheit" +
                "\n5.Segundos de un lustro" +
                "\n6.Segundos de la luz, sol-marte" +
                "\n7.Calculo de vueltas de una llanta" +
                "\n8.Calculo de la longitud de la sombra de un edificio" +
                "\n9.Cantidad de meses transcurridos desde una fecha de nacimento" +
                "\n10.Promedio de un alumno"+
                "\n11.Salir"+
                "\n*****************************************************************"
                );



            int opcion = 0;

            opcion = Convert.ToUInt16(Console.ReadLine());

            switch (opcion) {
                case 1:
                    //Area de un triangulo
                    Funciones.Area_Triangulo();
                    Main(args);
                    break;
                case 2:
                    //Conversion dolares-colones
                    Funciones.Conversion_DolaresColones();
                    Main(args);
                    break;
                case 3:
                    //Comparando edades
                    Funciones.Comparando_Edades();
                    Main(args);
                    break;
                case 4:

                    break;
                case 5:

                    break;
                case 6:

                    break;
                case 7:

                    break;
                case 8:

                    break;
                case 9:

                    break;
                case 10:

                    break;
                case 11:
                    //Salir
                    break;

                default:
                    Console.WriteLine("***No se ha seleccionado una opcion validad***");
                        break;
            }

            Console.ReadKey();
        }





    }
}
