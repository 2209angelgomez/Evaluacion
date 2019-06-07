using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion
{
    public class Billetera
    {
        public double inicial { get; set; }
        public int gasto { get; set; }
        public int saldo { get; set; }
        public double banco { get; set; }
        public double ahorro { get; set; }
        public int opcion { get; set; }

        public void Ingresar()
        {
            Console.WriteLine("Ingrese el dinero inicial");
            inicial = int.Parse(Console.ReadLine());
        }
        public void Gastar()
        {
            if (inicial > 0)
            {
                Console.WriteLine("Ingrese la cantidad de dinero a gastar ");
                gasto = int.Parse(Console.ReadLine());
                inicial = inicial - gasto;
                ahorro = gasto * 0.10;
                inicial = inicial - ahorro;
                banco = banco + ahorro;
            }
            else
            {
                Console.WriteLine("Actualmente no hay dinero en la billetera");
            }
        }
        public void Depositar()
        {
            if (inicial > 0)
            {
                banco = banco + inicial;
                inicial = 0;
            }
        }
        public void ImprimirDinero()
        {
            Console.WriteLine("Cantidad de dinero actualmente en la billetera:");
            Console.WriteLine(inicial);
        }
        public void TotalAhorrado()
        {
            Console.WriteLine("El total ahorrado en el banco es: ");
            Console.WriteLine("$ " + banco);
        }
        public void NotificarTransaccion()
        {
            if (opcion == 1)
            {
                Console.WriteLine("::::Notificación::::");
                Console.WriteLine("Ha ingresado un saldo inicial de: $ " + inicial);
            }
            else if (opcion == 2)
            {
                Console.WriteLine("::::Notificación::::");
                Console.WriteLine("Ha gastado un monto de: $" + gasto);
            }
            else if (opcion == 3)
            {
                Console.WriteLine("::::Notificación::::");
                Console.WriteLine("El dinero de su billetera ha sido depositado en el banco");
            }
            else if (opcion == 4)
            {
                Console.WriteLine("::::Notificación::::");
                Console.WriteLine("Se realizó una consulta del saldo de la billetera");
            }
            else if (opcion == 5)
            {
                Console.WriteLine("::::Notificación::::");
                Console.WriteLine("Se realizó una consulta del saldo del banco");
            }
        }

    }
}