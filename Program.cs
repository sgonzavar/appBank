using System;

namespace consoleAppBank
{
    class Program
    {
        static void Main(string[] args)
        {
            string card = "", password = "", numc = "";
            int cont = 0, option= 0;
            double balance = 10000, mon = 0, a, dep = 0, desc = 0;

            startMenu(card, password,cont );


            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("*********************************************");
                    Console.WriteLine("** CAJERO AUTOMATICO **");
                    Console.WriteLine("*********************************************");
                    Console.WriteLine("\nSeleccione la operación que desea realizar :");
                    Console.WriteLine("1.- Transeferencia de balance.");
                    Console.WriteLine("2.- Consulta de balance.");
                    Console.WriteLine("3.- Depósito de efectivo.");
                    Console.WriteLine("4.- Salir.");
                    Console.WriteLine("------------------------------------------------");

                    Console.Write("Ingrese su opción : ");
                    option= int.Parse(Console.ReadLine());
                    
                    if (option< 1 || option> 4)
                    {
                        Console.WriteLine("Has ingresado una opción inválida.");
                        Console.ReadLine();
                        cont++;
                        if (cont == 3)
                        {
                            Console.WriteLine("Has errado más de 3 veces en escojer una opción.");
                            goto final;
                        }
                    }
                } while (option< 1 || option> 4);

                switch (op)
                {
                    case 1://transeferencia
                        Console.Clear();
                        Console.WriteLine("*********************************************");
                        Console.WriteLine("** CAJERO AUTOMATICO **");
                        Console.WriteLine("*********************************************");
                        Console.WriteLine("TRANSFERENCIA DE balance A TERCEROS.");
                        Console.Write("\nIngrese el número de cuenta : ");
                        numc = Console.ReadLine();

                        Console.Write("Ingrese el mónto a transeferir : ");
                        mon = int.Parse(Console.ReadLine());
                        
                        a = (balance - mon);
                        
                        if (a > 0)
                        {
                            Console.WriteLine("Se transfirió con éxito el mónto de S/.{0} a la cuenta número {1}", mon, numc);
                            balance = (balance - mon);
                        }
                        else
                        {
                            Console.WriteLine("---------------------------------");
                            Console.WriteLine("** ADVERTENCIA : La operación no se puede realizar porque el mónto ingresado excede su balance actual. * *");
                        }
                        Console.WriteLine("\n\n** Su balance actual es S/ {0} **", balance);
                        Console.WriteLine("\nPresione 1 para realizar otra operación.");
                        Console.WriteLine("Presione 2 para retirar su cardeta.");
                        Console.WriteLine("---------------------------------");
                        Console.Write("Ingrese su opción : ");
                        
                        option= int.Parse(Console.ReadLine());
                        
                        if (option== 1)
                        {
                            break;
                        }
                        if (option== 2)
                        {
                            goto fin;
                        }
                        break;
                    case 2://consulta
                        Console.Clear();
                        Console.WriteLine("*********************************************");
                        Console.WriteLine("** CAJERO AUTOMATICO **");
                        Console.WriteLine("*********************************************");
                        Console.WriteLine("CONSULTA DE balanceS.");
                        Console.WriteLine("\nSu balance actual es : S/{0}", balance);
                        Console.WriteLine("-----------------------------------------------------------------");
                        Console.WriteLine("** Se le ha descontado el 0.01% de su balance actual por esta operación * *");

                        balance = (balance - (balance * 0.01));
                        desc = (desc += (balance * 0.01));
                        Console.WriteLine("\n\n** Su balance actual es S/ {0} **",
                        balance);
                        Console.WriteLine("\nPresione 1 para realizar otra operación.");

                        Console.WriteLine("Presione 2 para retirar su cardeta.");
                        Console.WriteLine("---------------------------------");
                        Console.Write("Ingrese su opción : ");
                        option= int.Parse(Console.ReadLine());
                        
                        if (option== 1)
                        {
                            break;
                        }
                        if (option== 2)
                        {
                            goto fin;
                        }
                        break;
                    case 3://depósito
                        Console.Clear();
                        Console.WriteLine("*********************************************");
                        Console.WriteLine("** CAJERO AUTOMATICO **");
                        Console.WriteLine("*********************************************");
                        Console.WriteLine("DEPOSITO DE EFECTIVO.");
                        Console.WriteLine("\n** No deberá superar los S/ 5000 por operación.");
                        Console.Write("\nIngrese la cantidad a depositar : ");
                        
                        dep = int.Parse(Console.ReadLine());
                        
                        if (dep > 0 && dep <= 5000)
                        {
                            Console.WriteLine("Se realizó con éxito el depósito de S/ {0} a su cuenta.", dep);
                            balance = (balance + dep);
                        }
                        else
                        {
                            Console.WriteLine("---------------------------------");
                            Console.WriteLine("** ADVERTENCIA : La operación no se puede realizar porque el mónto ingresado excede el máximo permitido por operación. * *");
                        }
                        Console.WriteLine("\n\n** Su balance actual es S/ {0} **", balance);
                        Console.WriteLine("\nPresione 1 para realizar otra operación.");
                        Console.WriteLine("Presione 2 para retirar su cardeta.");
                        Console.WriteLine("---------------------------------");
                        Console.Write("Ingrese su opción : ");
                        
                        option= int.Parse(Console.ReadLine());
                        
                        if (option== 1)
                        {
                            break;
                        }
                        if (option== 2)
                        {
                            goto fin;
                        }
                        break;
                    case 4://salir
                        goto final;
                        break;
                }
            } while (option!= 4);
        fin:
        final:
            Console.WriteLine("\n******************************************"
           );
            Console.WriteLine("Retire su cardeta.");
            Console.Write("Gracias por su visita. Hasta pronto.....");
            Console.ReadLine();
        }

        private static void startMenu(string card, string password, int cont)
        {
            while (card != "0000" || password != "0000")
            {
                Console.Clear();
                Console.WriteLine("*********************************************");
                Console.WriteLine("** CAJERO AUTOMATICO **");
                Console.WriteLine("*********************************************");
                Console.Write("\nIngrese su número de cardeta : ");
                card = Console.ReadLine();
                Console.Write("Ingrese la clave de su cardeta : ");
                password = Console.ReadLine();

                if (card != "1234567890" || password != "1234")
                {
                    cont++;
                    if (cont == 3)
                    {
                        Console.WriteLine("Clave errada más de 3 veces. Tu cardeta está retenida.");

                        Console.ReadLine();
                    }
                }
            }
        }
    }

}