using System;

namespace conversion_dolar_y_euro
{
    class Program
    {        
        static void menu(){
            int  op, cotizacion_dolar, cotizacion_euro, dolar, euro, peso_argentino;
            string op2, espacio_salida;
            
            Console.WriteLine(" 1. Conversion de Euro a Pesos Argentino");
            Console.WriteLine(" 2. Conversion de Dolar a Pesos Argentino");
            Console.WriteLine(" 3. Salir del programa");

            Console.WriteLine("elige una opcion");
            op = Convert.ToInt32(Console.ReadLine());
            
            
            switch (op)
            {
                case 1:
                    /* cotizacion_euro = 143;
                    Console.WriteLine("Cuantos Euros desea convertir a Pesos argentinos");
                    euro = Convert.ToInt32(Console.ReadLine());
                    peso_argentino = euro * cotizacion_euro;
                    Console.Clear();
                    Console.WriteLine("Los {0} (Euros) equivale a $ {1} (Pesos Argentinos) ", euro, peso_argentino); */
                    cotizacion_euro2();
                    
                    Console.Clear();
                    Console.WriteLine("Los {0} (Euros) equivale a $ {1} (Pesos Argentinos) ", euro, peso_argentino);
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("desea continuar:");
                    Console.WriteLine(" presione S-> si / N ->no");
                    op2 = Console.ReadLine();
                    if((op2=="s")||(op2=="S")){
                    Console.Clear();
                    menu ();
                    op = Convert.ToInt32(Console.ReadLine());
                    }else{
                    
                        Console.WriteLine("Muchas gracias, por usar el programa");
                    }
                    
                    break;
                case 2:
                    cotizacion_dolar = 287;
                    Console.WriteLine("Cuantos Dolares desea convertir a Pesos argentinos");
                    dolar = Convert.ToInt32(Console.ReadLine());
                    peso_argentino = dolar * cotizacion_dolar;
                    Console.WriteLine("Los {0} (Dolares) equivale a $ {1} (Pesos Argentinos) ", dolar, peso_argentino);
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("desea continuar:");
                    Console.WriteLine(" presione S-> si / N ->no");
                    op2 = Console.ReadLine();
                    if((op2=="s")||(op2=="S")){
                    Console.Clear();
                    menu ();
                    op = Convert.ToInt32(Console.ReadLine());
                    }
                    else {
                        Console.WriteLine("Muchas gracias, por usar el programa");
                    }
                    
                    break;
                case 3:
                    Console.WriteLine("Muchas gracias, por usar el programa");
                    espacio_salida=Console.ReadLine();
                    
                break;
                default:
                    Console.WriteLine("No corresponde a ninguna operacion. Seleccione una operacion valida");
                    Console.WriteLine("Desea volver al inicio o salir");
                    Console.WriteLine("Presione I -> inicio / S -> salir ");
                    op2= Console.ReadLine();
                    if ((op2=="i")||(op2=="I"))
                    {
                        Console.Clear();
                        menu();
                        op = Convert.ToInt32(Console.ReadLine());
                    }else
                    {
                        Console.WriteLine("Muchas gracias, por usar el programa");
                    }
                break;
                
            }
            
            
        }

        static int cotizacion_euro2(){
                    int cotizacion_euro = 143,euro,peso_argentino;
                    Console.WriteLine("Cuantos Euros desea convertir a Pesos argentinos");
                    euro = Convert.ToInt32(Console.ReadLine());
                    return peso_argentino = euro * cotizacion_euro;
                    
        }

        static void Main(string[] args)
        {
            
            Console.Clear();
            Console.WriteLine("Bienvenido a programa cotizacion:");
            menu();
            
        }
    }
}
