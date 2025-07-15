



namespace EvalucionCombustible.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double litros;
            double sumaTotalSuper = 0;
            double sumaTotalPremium = 0;
            double cantidadCargasTotal = 0;
            double galonesUsa, galonesUk;
            for(int i = 1; i <= 7; i++)
            {
                bool siguiente = true;
                double cantCargaPorDia = 0;
                double sumaCargasPorDia = 0;
                Console.WriteLine($"Hoy es el dia {i}({CualDiaEs(i)})");
                MenuCombusible();
                double tipoCombustible = GetDouble("Elija la opcion");
                switch (tipoCombustible)
                {
                    case 1:
                        do
                        {

                            litros = GetIntLitros("Ingrese la cantidad de litros");
                            cantCargaPorDia++;
                            sumaCargasPorDia = sumaCargasPorDia + litros;
                            sumaTotalSuper += litros;
                            cantidadCargasTotal++;
                            galonesUk = litros * 0.21997;

                            galonesUsa = litros * 0.26417;

                            Console.WriteLine("La cantidad de suma diaria es de ", sumaCargasPorDia);
                            Console.WriteLine("La cantidad de cargas son ", cantCargaPorDia);
                            Console.WriteLine("Quiere continuar");
                            Console.WriteLine("S - Si");
                            Console.WriteLine("N- No");
                            string opcion = Console.ReadLine();
                            if (opcion == "n")
                            {
                                siguiente = true;
                            }
                        } while (siguiente == false);
                        break;
                    case 2:
                        do
                        {

                            litros = GetIntLitros("Ingrese la cantidad de litros");
                            cantCargaPorDia++;
                            sumaCargasPorDia = sumaCargasPorDia + litros;
                            sumaTotalPremium += litros;
                            cantidadCargasTotal++;
                            galonesUk = litros * 0.21997;

                            galonesUsa = litros * 0.26417;

                            Console.WriteLine("La cantidad de suma diaria es de ", sumaCargasPorDia);
                            Console.WriteLine("La cantidad de cargas son ", cantCargaPorDia);
                            Console.WriteLine("Quiere continuar");
                            Console.WriteLine("S - Si");
                            Console.WriteLine("N- No");
                            string opcion = Console.ReadLine();
                            if (opcion == "n")
                            {
                                siguiente = true;
                            }
                        } while (siguiente == false);
                        break;
                }
                Console.WriteLine("El total de cargas es ", cantidadCargasTotal);
                Console.WriteLine("El total de combustible es: ", sumaTotalPremium);
                Console.WriteLine("El total de combustible es: ", sumaTotalSuper);

                Console.WriteLine();


            }
        }

        

        private static void MenuCombusible()
        {
            Console.WriteLine("Ingrese la opcion segun el tipo de combustible a ingresar");
            Console.WriteLine("1-Super");
            Console.WriteLine("2-Premium");
        }
        private static double GetIntLitros(string mensaje)
        {
            do
            {
                Console.Write(mensaje);
                if (double.TryParse(Console.ReadLine(), out double nro) && (nro>=5) &&(nro<=50))
                {
                    return nro;
                }
                else
                {
                    Console.WriteLine("Valor ingresado no valido, vuelva a ingresar");
                }
            } while (true);


        }
        private static double GetDouble(string mensaje)
        {
            do
            {
                Console.Write(mensaje);
                if (double.TryParse(Console.ReadLine(), out double nro))
                {
                    return nro;
                }
                else
                {
                    Console.WriteLine("Valor ingresado no valido, vuelva a ingresar");
                }
            } while (true);


        }

        private static object CualDiaEs(int i)
        {
            switch (i)
            {
                case 1:
                    return "Lunes";
                    
                case 2:
                    return "Martes";
                   
                case 3:
                    return "Miercoles";
                    
                case 4:
                    return "jueves";
                case 5:
                    return "Viernes";
                case 6:
                    return "Sabado";
                    case 7:
                    return "Domingo";
                default:
                    return "";
            }
           
        }
    }
}
