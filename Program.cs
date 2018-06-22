using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroBI
{
    class Program
    {
        static void Main(string[] args)
        {
            int deposito1 = 250;
            int deposito, retiro;
            int pin;
            int opcion=0;
            Console.WriteLine("Ingrese su tarjeta y su pin");

            try
            {

                pin = int.Parse(Console.ReadLine());
                
                                   
               
                 if (pin==1792)
                {
                    Console.WriteLine("seleccione una opción diferente de 9");
                    
                     
                    while (opcion!=9)
                    {
                        Console.WriteLine("Ingrese una opción del menú \n"); 
                        Console.WriteLine("1.  Consulta de saldos \n"); 
                        Console.WriteLine("2.  Déposito monetario \n");
                        Console.WriteLine("3. Retiro Monetario \n"); 
                       
                        Console.WriteLine("9. Salir"); 
                        Console.WriteLine();

                        try
                        {
                            opcion = int.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {

                            opcion = 1;
                        }
                        
                        switch (opcion)
                        {
                            case   1://Consulta de saldos
                                Console.WriteLine("Su saldo es de: " + deposito1);
                                
                                break;
                            case 2://deposito monetario
                                Console.WriteLine("Ingrese cuanto dinero quiere depositar.");
                                deposito= int.Parse(Console.ReadLine());
                                deposito1 += deposito;
                                Console.WriteLine("Ahora su saldo es de: Q" + deposito1);
                                
                                break;
                            case 3://retiro de dinero
                                Console.WriteLine("Ingrese la cantidad que desea retirar");
                                retiro = int.Parse(Console.ReadLine());
                                if (retiro > deposito1 )
                                {
                                    Console.WriteLine("No se puede realizar la operación. Fondos insuficientes");
                                }
                                else
                                {
                                    Console.WriteLine("Tome su dinero del cajero");
                                    deposito1= deposito1-retiro;
                                    Console.WriteLine("Ahora su saldo es de Q:" + deposito1);
                                }
                                
                                break;
                            case 9:
                                Environment.Exit(0);
                                break;
                            
                        }
                    }
                }
               
            }
            catch (Exception)
            {

                Console.WriteLine("Ingrese su pin");
            } 
            


            Console.ReadLine();
        }
    }
}
