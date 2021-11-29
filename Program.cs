using System;

namespace Calculadora
{
    public class Mensajes
    {
        public const string operaciones = "  _______________________________________________________________________________________________________________  \n" +
                                          " |                                                                                                               | \n" +
                                          " |                                                  SOY UNA CALCULADORA                                          | \n" +
                                          " |_______________________________________________________________________________________________________________| \n" +
                                          " |                                                  ELIGE UNA OPERACION:                                         | \n" +
                                          " |_______________________________________________________________________________________________________________| \n" +
                                          " |                           |                           |                           |                           | \n" +
                                          " |  1  : SUMA                |  5  : ELEVAR              |  9 : FRACCION             |  13 : NUMERO EULER        | \n" +
                                          " |___________________________|___________________________|___________________________|___________________________| \n" +
                                          " |                           |                           |                           | \n" +
                                          " |  2  : RESTA               |  6  : ELEVAR X AL ²       | 10 : EXPONENCIAR          | \n" +
                                          " |___________________________|___________________________|___________________________| \n" +
                                          " |                           |                           |                           | \n" +
                                          " |  3  : MULTIPLICACION      |  7  : ELEVAR 2^X          | 11 : RAIZ CUADRADA        | \n" +
                                          " |___________________________|___________________________|___________________________| \n" +
                                          " |                           |                           |                           | \n" +
                                          " |  4  : DIVISION            |  8  : ELEVAR 10^X         | 12 : NUMERO PI            | \n" +
                                          " |___________________________|___________________________|___________________________|";
        public const string pnum = "Escribe 1 numero";
        public const string operacionD = "Lo sentimos, no ha elegido una operación valida";
        public const string div0 = "Lo sentimos no se puede dividir entre 0";
        public const string resul = "El resultado es: ";
        public const string nPi = "3,1415926535897932384626433832795";
        public const string nE = "2,7182818284590452353602874713527";
        public const string continuar = "¿Quieres continuar? Si: Pulsa s | No: Pulse cualquier otra tecla ";
    }
    class Program
    {
        static void Main(string[] args)
        {
            string salida = "";
            double num1 = 0;
            double num2 = 0;
            int operacion = 0;

            //Introduccion del programa
            Console.Title = "Calculadora. Por Francisco Javier Gañan Escobar";
            do
            {
                //Elegir la operación deseada
                Funciones.print(Mensajes.operaciones + Environment.NewLine);
                operacion = Convert.ToInt32(Console.ReadLine());

                if (operacion != 12 && operacion != 13)
                {
                    //Peticion del primer numero
                    Funciones.print(Mensajes.pnum);
                    num1 = Convert.ToDouble(Console.ReadLine());

                    if (operacion != 6 && operacion != 7 && operacion != 8 && operacion != 9 && operacion != 11 && operacion != 14)
                    { 
                        //Peticion del segundo numero
                        Funciones.print(Mensajes.pnum);
                        num2 = Convert.ToDouble(Console.ReadLine());
                    }
                }
                //Llamada a la Calculadora
                Funciones.calc(operacion, num1, num2, Mensajes.resul, Mensajes.operacionD, Mensajes.div0, Mensajes.nPi, Mensajes.nE);

                //Mensaje de Salida
                Funciones.print(Environment.NewLine + Mensajes.continuar);
                salida = Console.ReadLine();
                Console.Clear();
            } while (salida == "s");
        }  
    }
    public class Funciones
    {
        //--------------------CALCULADORA------------------------
        public static void calc(int operacion, double num1, double num2, string resul, string operacionD, string div0, string nPi, string nE)
        {
            double resultado = 0;
            switch (operacion)
            {
                case 1:
                    resultado = suma(num1, num2);
                    break;
                case 2:
                    resultado = resta(num1, num2);
                    break;
                case 3:
                    resultado = multiplicacion(num1, num2);
                    break;
                case 4:
                    resultado = division(num1, num2, div0);
                    break;
                case 5:
                    resultado = elevar(num1, num2);
                    break;
                case 6:
                    resultado = elevarCuadrado(num1);
                    break;
                case 7:
                    resultado = elevar2ax(num1);
                    break;
                case 8:
                    resultado = elevar10ax(num1);
                    break;
                case 9:
                    resultado = fraccion(num1);
                    break;
                case 10:
                    resultado = exp(num1, num2);
                    break;
                case 11:
                    resultado = raizCuadrara(num1);
                    break;
                case 12:
                    resultado = numPi();
                    break;
                case 13:
                    resultado = numE();
                    break;
                case 14:
                    resultado = log(num1);
                    break;
                default:
                    print(operacionD);
                    break;
            }
            print(resul + resultado);
        }
        //********************SUMA*****************************
        public static double suma(double n1, double n2)
        {
            double resultado = n1 + n2;
            return (resultado);
        }
        //********************RESTA*****************************
        public static double resta(double n1, double n2)
        {
            double resultado = n1 - n2;
            return (resultado);
        }
        //********************MULTIPLICACION********************
        public static double multiplicacion(double n1, double n2)
        {
            double resultado = n1 * n2;
            return (resultado);
        }
        //********************DIVISION**************************
        public static double division(double n1, double n2, string div0)
        {
            double resultado = n1 / n2;
            if (n1 == 0)
            {
                print(div0);
            }
            else if (n2 == 0)
            {
                print(div0);
            }
            return (resultado);
        }
        //********************ELEVAR********************
        public static double elevar(double n1, double n2)
        {
            double resultado = Math.Pow(n1, n2);
            return (resultado);
        }
        //********************ELEVAR AL CUADRADO********************
        public static double elevarCuadrado(double n2)
        {
            double n1 = n2;
            double resultado = Math.Pow(n2, n1);
            return (resultado);
        }
        //********************ELEVAR 2 A X********************
        public static double elevar2ax(double n2)
        {
            double resultado = Math.Pow(2, n2);
            return (resultado);
        }
        //********************ELEVAR 10 A X********************
        public static double elevar10ax(double n2)
        {
            double resultado = Math.Pow(10, n2);
            return (resultado);
        }
        //********************FRACCION**************************
        public static double fraccion(double n2)
        {
            double resultado = Math.Round(n2);
            return (resultado);
        }
        //********************EXPONENCIAR********************
        public static double exp(double n1, double n2)
        {
            for (double n=0;n<n2;n++)
            {
                double numexp = n1 * 10;
                n1 = numexp;
            }
            return (n1);
        }
        //********************RAIZ CUADRARA********************
        public static double raizCuadrara(double n1)
        {
            double resultado = Math.Sqrt(n1);
            return (resultado);
        }
        //********************NUMERO PI********************
        public static double numPi()
        {
            double resultado = Math.PI;
            return (resultado);
        }
        //********************NUMERO EULER********************
        public static double numE()
        {
            double resultado = Math.E;
            return (resultado);
        }
        //********************LOGARITMO********************
        public static double log(double n1)
        {
            double resultado = Math.Log(n1);
            return (resultado);
        }
        //********************IMPRIMIR**************************
        public static void print(string resultado)
        {
            Console.WriteLine(resultado);
        }
    }
}