using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionales_3
{
    class Program
    {
        static void Main(string[] args)
        {

            ////// introducir dos numeros e indicar si son o no iguales. Colocar las variables siempre en el inicio por buenas practicas
            //int num1, num2;
            //Console.WriteLine("introduce un valor");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //num2 = Convert.ToInt32(Console.ReadLine());
            //if (num1 == num2)
            //{ Console.WriteLine("Los numeros son iguales"); }
            //else
            //{ Console.WriteLine("Los numeros son diferentes"); }
            //Console.ReadLine();


            //// Pedir un numero y decir si es par o no
            //int num1;
            //Console.WriteLine("introducir numero: ");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //if (num1 % 2 == 0)
            //{ Console.WriteLine("el numero es par"); }
            //else
            //{ Console.WriteLine("el numero es impar"); }
            //Console.ReadLine();


            ////Pedir un numero del 1-7 y decir a que día de la semana corresponde
            //int num1;
            //Console.WriteLine("introduce un día");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //if (num1 == 1)
            //{
            //    Console.WriteLine("Lunes");
            //}
            //else if (num1 == 2)
            //    {
            //    Console.WriteLine("Martes");
            //}
            //else if (num1 == 3)
            //{
            //    Console.WriteLine("Miercoles");
            //}
            //else if (num1 == 4)
            //{
            //    Console.WriteLine("Jueves");
            //}
            //else if (num1 == 5)
            //{
            //    Console.WriteLine("Viernes");
            //}
            //else if (num1 == 6)
            //{
            //    Console.WriteLine("Sabado");
            //}
            //else if (num1 == 7)
            //{
            //    Console.WriteLine("Domingo");
            //}
            //else
            //{
            //    Console.WriteLine("No es un dia de la semana");
            //}
            //Console.ReadLine();

            //// pedir un numero numero del 1-12 y que aparezca el día del mes.
            //int num1;
            //Console.WriteLine("introducir numero mes: ");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //switch (num1)
            //{ case 1:
            //        Console.WriteLine("el mes es Enero");
            //        break;
            //    case 2:
            //        Console.WriteLine("el mes es Febrero");
            //        break;
            //    case 3:
            //        Console.WriteLine("el mes es Marzo");
            //        break;
            //    case 4:
            //        Console.WriteLine("el mes es Abril");
            //        break;
            //    case 5:
            //        Console.WriteLine("el mes es Mayo");
            //        break;
            //    case 6:
            //        Console.WriteLine("el mes es Junio");
            //        break;
            //    case 7:
            //        Console.WriteLine("el mes es Julio");
            //        break;
            //    case 8:
            //        Console.WriteLine("el mes es Agosto");
            //        break;
            //    case 9:
            //        Console.WriteLine("el mes es Septiembre");
            //        break;
            //    case 10:
            //        Console.WriteLine("el mes es Octubre");
            //        break;
            //    case 11:
            //        Console.WriteLine("el mes es Noviembre");
            //        break;
            //    case 12:
            //        Console.WriteLine("el mes es Diciembre");
            //        break;
            //    default:
            //        Console.WriteLine("No es un mes");
            //        break;
            //}
            //Console.ReadLine();

            // Ejemplo notas
            double nota;
            Console.WriteLine("introducir valor examen: ");
            nota = Convert.ToDouble(Console.ReadLine());
            // si no se añade la condicón de >= 0 enla de suspenso, entraran los numeros negativos aquí y no en el else
            if (nota < 5 && nota >= 0) { Console.WriteLine("Suspenso"); }
            else if (nota >= 5 && nota < 6) { Console.WriteLine("Aprobado"); }
            else if (nota >= 6 && nota < 7) { Console.WriteLine("Bien"); }
            else if (nota >= 7 && nota < 9) { Console.WriteLine("Notable"); }
            else if (nota >= 9 && nota == 10) { Console.WriteLine("Sobresaliente"); }
            else { Console.WriteLine("Esto no es una nota, tramposo"); }
            Console.ReadLine();



            //Ejercicios rápidos


        }



        // Pedir el peso y altura, e indicar su Indice de Masa Corporal según tablas OMS

    }
}
