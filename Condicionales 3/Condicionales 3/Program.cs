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



            ////Escribe un programa que pida al usuario tres números y que diga si uno de ellos es 20 menos que uno de los otros.
            //int num1, num2, num3;
            //Console.WriteLine("introduzca un numero");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("introduzca un numero");
            //num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("introduzca un numero");
            //num3 = Convert.ToInt32(Console.ReadLine());
            //if (num1 < (num2 + 20))
            //{
            //    Console.WriteLine(num1 + " es 20 menos que " + num2);
            //}
            //else if (num1 < (num3 + 20))
            //{
            //    Console.WriteLine(num1 + " es 20 menos que " + num3);
            //}
            //if (num2 < (num1 + 20))
            //{
            //    Console.WriteLine(num2 + " es 20 menos que " + num1);
            //}
            //if (num2 < (num3 + 20))
            //{
            //    Console.WriteLine(num2 + " es 20 menos que " + num3);
            //}
            //if (num3 < (num1 + 20))
            //{
            //    Console.WriteLine(num3 + " es 20 menos que " + num1);
            //}
            //if (num3 < (num2 + 20))
            //{
            //    Console.WriteLine(num3 + " es 20 menos que " + num2);
            //}


            ////Escribe un programa que pida dos valores del usuario y 
            ////Si los dos valores son iguales muestre 0
            ////Si los dos valores tienen el mismo resto al dividir entre 6 mostrar el más pequeño
            ////Si no que muestre el más grande de los dos
            //int num1, num2;
            //Console.WriteLine("introduzca un numero");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("introduzca un numero");
            //num2 = Convert.ToInt32(Console.ReadLine());
            //if (num1 == num2)
            //{
            //    Console.WriteLine(0);
            //}
            //else
            //{
            //    if ((num1 % 6) == (num2 % 6))
            //    {
            //        if (num1 < num2)
            //        {
            //            Console.WriteLine(num1);
            //        }
            //        else
            //        {
            //            Console.WriteLine(num2);
            //        }
            //    }
            //    else
            //    {
            //        if (num1 > num2)
            //        {
            //            Console.WriteLine(num2);
            //        }
            //        else
            //        {
            //            Console.WriteLine(num2);
            //        }
            //    }
            //}


            ////Escribe un programa que pida dos números enteros entre 25 y 75 y 
            ////que diga si hay un dígito en común entre los dos números.

            //int num1, num2;
            //Console.WriteLine("introduzca un numero entre 25 y 75");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("introduzca otro numero entre 25 y 75");
            //num2 = Convert.ToInt32(Console.ReadLine());

            //if (((num1 / 10) == (num2 / 10)) || ((num1 / 10) == (num2 % 10)) || ((num1 % 10) == (num2 / 10)) || ((num1 % 10) == (num2 % 10)))
            //{
            //    Console.WriteLine("Hay dos digitos iguales");
            //}
            //else
            //{
            //    Console.WriteLine("no hay digitos iguales");
            //}


            ////Ejercicio n, entrada, saldo y cliente Vip.
            ////Vamos a escribir varios programas que saludan al usuario al iniciar. 
            ////El usuario tiene asociadas 3 variables, una que indica si ha pagado la entrada, 
            ////una que indica si es cliente VIP y la otro el saldo que tiene (positivo para saldo de más, negativo para deuda).
            ////Haz un programa por cada punto:
            ////Comprobar si se ha pagado la entrada.Si se ha pagado, 
            ////mostramos mensaje "Bienvenido",si no mostrar mensaje "Tienes que pagar la entrada".

            //bool entrada, vip, saldo;
            //string respuesta;
            //Console.WriteLine("Ha pagado la entrada? responda SI o NO y pulse enter");
            //respuesta = Convert.ToString(Console.ReadLine());
            //if (respuesta == "SI")
            //{
            //    entrada = true;
            //    if (entrada)
            //    {
            //        Console.WriteLine("Bienvenido");
            //        Console.ReadLine();
            //    }
            //}
            //else if (respuesta == "NO")
            //{
            //    entrada = false;
            //    if (entrada == false)
            //    {
            //        Console.WriteLine("Paga la entrada");
            //        Console.ReadLine();
            //    }
            //}

            //////A todos se les dice "Bienvenido", pero si es cliente VIP después de "Bienvenido" 
            //////también se le dice "Que pase un buen día"
            //string respuesta2;
            //Console.WriteLine("Es Usted cliente VIP? responda SI o NO y pulse enter");
            //respuesta2 = Convert.ToString(Console.ReadLine());
            //if (respuesta2 == "SI")
            //{
            //    vip = true;
            //    if (vip)
            //    {
            //        Console.WriteLine("Bienvenido, que pase un buen día");
            //        Console.ReadLine();
            //    }
            //}
            //else if (respuesta2 == "NO")
            //{
            //    vip = false;
            //    if (vip == false)
            //    {
            //        Console.WriteLine("Bienvenido");
            //        Console.ReadLine();
            //    }
            //}

            //////Si no tiene deudas, le damos la bienvenida.En caso contrario no hacemos nada.
            //string respuesta3;
            //Console.WriteLine("Como tiene el saldo? responda Positivo o Negativo y pulse enter");
            //respuesta3 = Convert.ToString(Console.ReadLine());
            //if (respuesta3 == "Positivo")
            //{
            //    saldo = true;
            //    if (saldo)
            //    {
            //        Console.WriteLine("Bienvenido");
            //        Console.ReadLine();
            //    }
            //}
            //else if (respuesta3 == "Negativo")
            //{
            //    saldo = false;
            //    if (saldo == false)
            //    {
            //        Console.WriteLine();
            //        Console.ReadLine();
            //    }
            //}

            //////Solo damos la bienvenida en el caso de cliente vip y el saldo sea mayor que 0

            //if (respuesta2 == "SI")
            //{
            //    vip = true;
            //    if (vip)
            //    {
            //        if (respuesta3 == "Positivo")
            //        {
            //            saldo = true;
            //            if (saldo)
            //            {
            //                Console.WriteLine("Bienvenido");
            //                Console.ReadLine();
            //            }
            //        }
            //        else if (respuesta3 == "Negativo")
            //        {
            //            saldo = false;
            //            if (saldo == false)
            //            {
            //                Console.WriteLine();
            //                Console.ReadLine();
            //            }
            //        }
            //    }
            //}
            //else if (respuesta2 == "NO")
            //{
            //    vip = false;
            //    if (vip == false)
            //    {
            //        Console.WriteLine();
            //        Console.ReadLine();
            //    }
            //}


            ////Resultado de carrera. Hacer varios programas en los que se le pregunta al usuario el puesto en el que acabó. 
            ////Después:
            ////Si el valor de puesto es 1 mostramos mensaje con "Ganaste", si no "Lo importante es participar”.
            //int puesto;
            //Console.WriteLine("¿En qué puesto has quedado en la carrera? Inserte numero");
            //puesto = Convert.ToInt32(Console.ReadLine());
            //if (puesto == 1)
            //{
            //    Console.WriteLine("Ganaste");
            //}
            //else
            //{
            //    Console.WriteLine("Lo importante es participar");
            //}


            ////Si el valor de puesto es 1, mostramos mensaje con "Medalla de oro", si el valor de puesto es 2, 
            ////mostramos el mensaje con "Medalla de plata", si es 3 "Medalla de bronce" 
            ////y al resto "Lo importante es participar.
            //int puesto;
            //Console.WriteLine("¿En qué puesto has quedado en la carrera? Inserte numero");
            //puesto = Convert.ToInt32(Console.ReadLine());
            //if (puesto == 1)
            //{
            //    Console.WriteLine("Medalla de oro");
            //}
            //else if (puesto == 2)
            //{
            //    Console.WriteLine("Medalla de plata");
            //}
            //else if (puesto == 3)
            //{
            //    Console.WriteLine("Medalla de bronce");
            //}
            //else
            //{
            //    Console.WriteLine("Lo importante es participar");
            //}

            ////Con switch: Si el valor de puesto es 1, mostramos mensaje con "Medalla de oro", 
            ////si el valor de puesto es 2, mostramos el mensaje con "Medalla de plata", si es 3 "Medalla de bronce" 
            ////y al resto "Lo importante es participar.
            //int puesto;
            //Console.WriteLine("¿En qué puesto has quedado en la carrera? Inserte numero");
            //puesto = Convert.ToInt32(Console.ReadLine());
            //switch (puesto)
            //{
            //    case 1:
            //        Console.WriteLine("Medalla de oro");
            //        break;
            //    case 2:
            //        Console.WriteLine("Medalla de plata");
            //        break;
            //    case 3:
            //        Console.WriteLine("Medalla de bronce");
            //        break;
            //    default:
            //        Console.WriteLine("Lo importnte es participar");
            //        break;
            //}

            ////Los puestos 1, 2 y 3 ven el mensaje "Sube al podium", el resto ven el mensaje "Se acabó la carrera".
            ////Hazlo usando un if/else
            //int puesto;
            //Console.WriteLine("¿En qué puesto has quedado en la carrera? Inserte numero");
            //puesto = Convert.ToInt32(Console.ReadLine());
            //if ((puesto >= 1) && (puesto <= 3))
            //{
            //    Console.WriteLine("Sube al podium");
            //}
            //else
            //{
            //    Console.WriteLine("Se acabo la carrera");
            //}

            ////usando switch
            //int puesto;
            //Console.WriteLine("¿En qué puesto has quedado en la carrera? Inserte numero");
            //puesto = Convert.ToInt32(Console.ReadLine());
            //switch (puesto)
            //{
            //    case 1:
            //        Console.WriteLine("Sube al podio");
            //        break;
            //    case 2:
            //        Console.WriteLine("Sube al podio");
            //        break;
            //    case 3:
            //        Console.WriteLine("Sube al podio");
            //        break;
            //    default:
            //        Console.WriteLine("Lo importnte es participar");
            //        break;
            //}


            ////Si la edad es igual o inferior a 8 mostramos mensaje "Pasa al tobogán", 
            ////si no mostramos "Eres demasiado mayor para usar el tobogán"
            //int edad;
            //Console.WriteLine("diga su edad para entrar en el tobogán");
            //edad = Convert.ToInt32(Console.ReadLine());
            //if (edad <= 8)
            //{
            //    Console.WriteLine("Pasa al tobogán");
            //}
            //else
            //{
            //    Console.WriteLine("Eres demasiado mayor para usar el tobogan");
            //}


            ////Comprobar un string que tenga el valor del día de la semana (lunes, martes, ...). 
            ////Mostrar en pantalla el día que dice que es si es entre lunes y viernes (Por ejemplo "Hoy es lunes") 
            ////y si es fin de semana mostrar "Es fin de semana" Con switch y con if else.

            //string diasemana;
            //Console.WriteLine("introduce el dia de la semana");
            //diasemana = Console.ReadLine();
            //switch (diasemana)
            //{
            //    case "lunes":
            //        Console.WriteLine("Hoy es Lunes");
            //        break;
            //    case "martes":
            //        Console.WriteLine("Hoy es Martes");
            //        break;
            //    case "miercoles":
            //        Console.WriteLine("Hoy es Miercoles");
            //        break;
            //    case "jueves":
            //        Console.WriteLine("Hoy es jueves");
            //        break;
            //    case "viernes":
            //        Console.WriteLine("Hoy es Viernes");
            //        break;
            //    default:
            //        Console.WriteLine("Es fin de semana");
            //        break;
            //}

            //string diasemana;
            //Console.WriteLine("introduce el dia de la semana");
            //diasemana = Console.ReadLine();
            //if (diasemana == "lunes")
            //{
            //    Console.WriteLine("Hoy es lunes");
            //}
            //else if (diasemana == "martes")
            //{
            //    Console.WriteLine("Hoy es martes");
            //}
            //else if (diasemana == "miercoles")
            //{
            //    Console.WriteLine("Hoy es miercoles");
            //}
            //else if (diasemana == "jueves")
            //{
            //    Console.WriteLine("Hoy es jueves");
            //}
            //else if (diasemana == "viernes")
            //{
            //    Console.WriteLine("Hoy es viernes");
            //}
            //else
            //{
            //    Console.WriteLine("Es fin de semana");
            //}


            //A partir de un valor de número entero, mostrar el mensaje "El valor absoluto de -7 es 7". 
            //Si es menor que cero mostrar el valor en positivo, si es positivo o cero mostrar ese mismo valor. 
            int num1;
            Console.WriteLine("insertarnumero");
            num1 = Convert.ToInt32(Console.ReadLine());


            Console.ReadLine();



        }





    }
}
