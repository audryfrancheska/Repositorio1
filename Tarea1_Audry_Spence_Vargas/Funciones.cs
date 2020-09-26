using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1_Audry_Spence_Vargas
{
    class Funciones
    {
         static public int Area_Triangulo() 
        {
            string entrada = "";
            int bas = 0, altura = 0, resultado = 0;

            Console.WriteLine("***AREA DE UN TRIANGULO***");
            Console.WriteLine("Digite un valor para la base del triangulo a calcular: ");
            entrada = Console.ReadLine();
            bas = Convert.ToInt32(entrada);


            Console.WriteLine("Digite un valor para la altura del triangulo a calcular: ");
            entrada = Console.ReadLine();
            altura = Convert.ToInt32(entrada);

            resultado = (bas * altura)/2;

            //Mostramos los resultados
            Console.WriteLine("El resultado es {0}", resultado);
            Console.WriteLine("*****************************************************************");

            return resultado;
        }
        static public int Conversion_DolaresColones() 
        {
            string entrada = "";
            int precio_Dolar = 0, monto_Aconvertir = 0, resultado = 0;

            Console.WriteLine("***CONVERSION DE DOLARES A COLONES***");
            Console.WriteLine("Digite la cantidad de dolares que desea convertir a colones: ");
            entrada = Console.ReadLine();
            monto_Aconvertir = Convert.ToInt32(entrada);

            Console.WriteLine("Digite el precio del dolar: ");
            entrada = Console.ReadLine();
            precio_Dolar = Convert.ToInt32(entrada);

            resultado = precio_Dolar * monto_Aconvertir;

            //Mostramos los resultados
            Console.WriteLine("El resultado es {0}", resultado);
            Console.WriteLine("*****************************************************************");

            return resultado;
        }

        static public Boolean Comparando_Edades()
        {
            string entrada = "";
            int edad_Usuario1 = 0, edad_Usuario2 = 0;
            Boolean edad_Iguales = true;

            Console.WriteLine("***COMPARANDO EDADES***");
            Console.WriteLine("Digite la edad del Usuario #1:");
            entrada = Console.ReadLine();
            edad_Usuario1 = Convert.ToInt32(entrada);

            Console.WriteLine("Digite la edad del Usuario #2:");
            entrada = Console.ReadLine();
            edad_Usuario2 = Convert.ToInt32(entrada);

            if (edad_Usuario1 == edad_Usuario2)
            {
                Console.WriteLine("Las edades del Usuario1 {0} y Usuario2 son {1}:", edad_Iguales);
                return true;
            }
            else {
                Console.WriteLine("Las edades del Usuario1  {0} y Usuario2 son {1}:");
                return false;
            }

            

        }

    }
}
