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

            //// Ejemplo notas
            //double nota;
            //Console.WriteLine("introducir valor examen: ");
            //nota = Convert.ToDouble(Console.ReadLine());
            //// si no se añade la condicón de >= 0 enla de suspenso, entraran los numeros negativos aquí y no en el else
            //if (nota < 5 && nota >= 0) { Console.WriteLine("Suspenso"); }
            //else if (nota >= 5 && nota < 6) { Console.WriteLine("Aprobado"); }
            //else if (nota >= 6 && nota < 7) { Console.WriteLine("Bien"); }
            //else if (nota >= 7 && nota < 9) { Console.WriteLine("Notable"); }
            //else if (nota >= 9 && nota == 10) { Console.WriteLine("Sobresaliente"); }
            //else { Console.WriteLine("Esto no es una nota, tramposo"); }
            //Console.ReadLine();


            //// pedir una altura en metros y un peso y obtener el IMC segun tabla
            //// recordar que en el codigo los decimales se ponen con ".", pero en la consola en español se usa ","
            //double altura, peso, imc;
            //Console.WriteLine("introducir valor altura en metros con una , : ");
            //altura = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("introducir valor peso: ");
            //peso = Convert.ToDouble(Console.ReadLine());
            //imc = peso / Math.Pow(altura, 2);
            //if (imc < 16.00) { Console.WriteLine("Infrapeso: Delgadez Severa: " + imc);
            //}
            //else if (imc >= 16.00 && imc < 17.00)
            //{
            //    Console.WriteLine("Infrapeso: Delgadez moderada: " + imc);
            //}
            //else if (imc >= 17.00 && imc < 18.50)
            //{
            //    Console.WriteLine("Infrapeso: Delgadez aceptable: " + imc);
            //}
            //else if (imc >= 18.50 && imc < 25.00)
            //{
            //    Console.WriteLine("Peso Normal: " + imc);
            //}
            //else if (imc >= 25.00 && imc < 30.00)
            //{
            //    Console.WriteLine("Sobrepeso: " + imc);
            //}
            //else if (imc >= 30.00 && imc < 35.00)
            //{
            //    Console.WriteLine("Obeso tipo I: " + imc);
            //}
            //else if (imc >= 35.00 && imc <= 40.00)
            //{
            //    Console.WriteLine("Sobrepeso Tipo III: " + imc);
            //}
            //else if (imc > 40.00)
            //{
            //    Console.WriteLine("Sobrepeso tipo III: " + imc);
            //}
            //else { Console.WriteLine("Esto no es un imc");
            //}
            //Console.ReadLine();


            //Ejercicios rápidos condicionales

            ////Ejercicio 1, pide dos numeros y da suma, multiplicación,...
            //double num1, num2;
            //Console.WriteLine("escriba un numero");
            //num1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("escriba un numero");
            //num2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("La multiplicación entre " + num1 + " y " + num2 + " es " + (num1 * num2));
            //Console.WriteLine("la suma entre " + num1 + " y " + num2 + " es " + (num1 + num2));
            //Console.WriteLine("la resta entre " + num1 + " y " + num2 + " es " + (num1 - num2));
            //Console.WriteLine("la media de es " + ((num1 + num2) / 2));
            //Console.WriteLine("el maximo es " + Math.Max(num1, num2));
            //Console.WriteLine("el minimo es " + Math.Min(num1, num2));
            //Console.ReadLine();


            ////Ejercicio 2, Escribe un programa que pida al usuario 3 números. 
            ////Si el resultado de la suma de los dos primeros es igual al tercer número, mostrarlo en pantalla, 
            ////si no mostrar que el tercero no es la suma de los dos anteriores
            //double num1, num2, num3;
            //Console.WriteLine("escriba un numero");
            //num1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("escriba un numero");
            //num2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("escriba un numero");
            //num3 = Convert.ToDouble(Console.ReadLine());
            //if ((num1 +num2) == num3)
            //{
            //    Console.WriteLine(num3);
            //}
            //else
            //{
            //    Console.WriteLine(num3 + " no es la suma de los dos anteriores");
            //}

            ////Escribe un programa que convierta los segundos a horas, minutos y segundos
            //int segundos, minutos;
            //Console.WriteLine("introduzca segundos");
            //segundos = Convert.ToInt32(Console.ReadLine());
            //minutos = (segundos % 3600)/60;
            //Console.WriteLine("horas: " + (segundos / 3600));
            //Console.WriteLine("minutos: " + minutos);
            //Console.WriteLine("Segundos: " + (segundos % 60));


            ////Ejemplo de if anidados

            //int num1 = 5, num2 = 6, num3 = 7;

            //if (num1 < num2)
            //{
            //    if (num2 < num3)
            //{

            //}
            //else if ()
            //{
            //    if ()
            //}



            //Escribe un programa que pida al usuario tres números y que diga si uno de ellos es 20 menos que uno de los otros.
            int num1, num2, num3;
            Console.WriteLine("introduzca un numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("introduzca un numero");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("introduzca un numero");
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 < (num2 + 20))
            {
                Console.WriteLine(num1 + " es 20 menos que " + num2);
            }
            else if (num1 < (num3 + 20))
            {
                Console.WriteLine(num1 + " es 20 menos que " + num3);
            }
            if (num2 < (num1 + 20))
            {
                Console.WriteLine(num2 + " es 20 menos que " + num1);
            }

            Console.ReadLine();
            ////Ejercicio n, entrada, saldo y cliente Vip.
            //bool entrada, vip, saldo;
            //Console.WriteLine("Ha pagado la entrada?");
            //entrada = Convert.ToBoolean(Console.ReadLine());
            //vip = Convert.ToBoolean(Console.ReadLine());
            //saldo = Convert.ToBoolean(Console.ReadLine());
            //if (entrada == true)
            //{
            //    Console.WriteLine("Bienvenido");
            //}
            //else
            //{
            //    Console.WriteLine("Paga la entrada");
            //}
            //Console.ReadLine();



        }





    }
}
