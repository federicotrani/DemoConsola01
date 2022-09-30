using System;

namespace DemoConsola01
{
    class Program
    {
        static void Main(string[] args)
        {
          string opcion = "";
          int resultadoMultiplicacion=0;
          int otraVariable = 0;

            Console.ForegroundColor = ConsoleColor.Green;      

            while(opcion != "x"){
              Console.Clear();
              System.Console.WriteLine("MENU de USUARIO");
              System.Console.WriteLine("S - OPERACION SUMA");
              System.Console.WriteLine("R - OPERACION RESTA");
              System.Console.WriteLine("M - OPERACION MULTIPLICACION");
              System.Console.WriteLine("D - OPERACION DIVISION");
              System.Console.WriteLine("X - TERMINAR PROGRAMA");

              opcion = Console.ReadLine();

              switch(opcion){                
                
                case "s" or "S":
                  operacionSumar(18, 23);
                  break;
                case "r" or "R":
                  System.Console.WriteLine("Seleccionamos RESTA");
                  Console.ReadKey();
                  break;
                case "m" or "M":
                  resultadoMultiplicacion = 56 + otraVariable + operacionMutiplicar(55, 89);
                  break;
                case "d" or "D":
                  System.Console.WriteLine("Seleccionamos DIVISION");
                  Console.ReadKey();
                  break;
                default:
                  System.Console.WriteLine("Opción NO VALIDA");
                  Console.ReadKey();
                  break;
              }             
            }

            System.Console.WriteLine("Salimos del programa...");
            Console.ReadKey();
        }

        static void operacionSumar(int valorUno, int valorDos){
          int resultado = 0;
          resultado = valorUno + valorDos;
          Console.Clear();
          System.Console.WriteLine("Resultado {0}", resultado);
          Console.ReadKey();
        }
    
        static int operacionMutiplicar(int numPrimero, int numSegundo){

          int resultadoMultiplicacion = numPrimero *numSegundo;

          return resultadoMultiplicacion;
        }
    }
}
