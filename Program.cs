using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion
{
    class Program
    {
        private static MusicPlayer musica;
        static void Main(string[] args)
        {
            Billetera billetera = new Billetera();
            List<Billetera> billeteras = new List<Billetera>();

            do
            {

                do
                {
                    Console.WriteLine("|------------------------MENÚ------------------------|");
                    Console.WriteLine("| [1]. Ingresar Dinero Inicial-----------------------|");
                    Console.WriteLine("| [2]. Ingresar un Gasto.----------------------------|");
                    Console.WriteLine("| [3]. Depositar toda la billetera en el banco-------|");
                    Console.WriteLine("| [4]. Consultar saldo de la billetera---------------|");
                    Console.WriteLine("| [5]. Consultar dinero total ahorrado en el banco---|");
                    Console.WriteLine("| [6]. Salir-----------------------------------------|");
                    Console.WriteLine("|---------------SELECCIONE UNA OPCIÓN----------------|");

                    billetera.opcion = int.Parse(Console.ReadLine());

                } while (billetera.opcion != 1 && billetera.opcion != 2 && billetera.opcion != 3 && billetera.opcion != 4 && billetera.opcion != 5 && billetera.opcion != 6);

                switch (billetera.opcion)
                {
                    case 1:
                        billetera.Ingresar();
                        billetera.NotificarTransaccion();

                        break;

                    case 2:
                        billetera.Gastar();
                        billetera.NotificarTransaccion();
                        break;

                    case 3:
                        billetera.Depositar();
                        billetera.NotificarTransaccion();
                        break;

                    case 4:
                        billetera.ImprimirDinero();
                        billetera.NotificarTransaccion();
                        break;

                    case 5:
                        billetera.TotalAhorrado();
                        billetera.NotificarTransaccion();
                        break;

                    case 6:
                        Console.WriteLine("Su sesión a finalizado.");
                        break;
                }
            } while (billetera.opcion != 7);
            }
    }
}

























//            int op = 0;
//            string numero, nombre, respuesta;
//            do
//            {
//                do
//                {
//                    Console.WriteLine("|-----------------MENÚ----------------|");
//                    Console.WriteLine("| [1] Agregar cancion a la playlist   |");
//                    Console.WriteLine("| [2] Listar canciones                |");
//                    Console.WriteLine("| [3] Buscar canciones                |");
//                    Console.WriteLine("| [4] Eliminar canción                |");
//                    Console.WriteLine("| [5] Reproducir canción              |");
//                    Console.WriteLine("| [6] Pausar canción                  |");
//                    Console.WriteLine("| [7] Avanzar canción                 |");
//                    Console.WriteLine("| [8] Retroceder canción              |");
//                    Console.WriteLine("| [9] Salir                           |");
//                    op = int.Parse(Console.ReadLine());
//                } while (op != 1 && op != 2 && op != 3 && op != 4 && op != 5 && op != 6 && op != 7 && op != 8 && op != 9);
//                switch (op)
//                {
//                    case 1:
//                        Console.WriteLine("Ingrese el número de la canción");
//                        numero = Console.ReadLine();
//                        Console.WriteLine("Ingrese el nombre de la canción");
//                        nombre = Console.ReadLine();
//                        Console.WriteLine("¿Desea ingresar esta canción?");
//                        respuesta = Console.ReadLine();
//                        if (respuesta == "si")
//                        {

//                            //MusicPlayer musica = new MusicPlayer(numero, nombre);
//                            MusicPlayer.Agregar(musica);
//                            Console.WriteLine("Cancion agregada");
//                        }
//                        else
//                        {
//                            if (respuesta == "no")
//                            {
//                                Console.WriteLine("La canción no se agregó");
//                            }
//                        }

//                        break;

//                    case 2:
//                        MusicPlayer.Listar();
//                        break;

//                    case 3:
//                        Console.WriteLine("--------------BUSCAR CANCION--------------");
//                        Console.WriteLine("Ingrese el número de la canción");
//                        respuesta = Console.ReadLine();
//                        musica = MusicPlayer.Buscar(respuesta);
//                        if (musica == null)
//                        {
//                            Console.WriteLine("La canción no existe");
//                        }
//                        else
//                        {
//                            MusicPlayer.Imprimir(musica);
//                        }

//                        break;

//                    case 4:
//                        Console.WriteLine("Ingrese el número de la canción");
//                        respuesta = Console.ReadLine();
//                        musica = MusicPlayer.Buscar(respuesta);

//                        if (musica == null)
//                        {
//                            Console.WriteLine("La canción no existe");
//                        }
//                        else
//                        {
//                            MusicPlayer.Eliminar(respuesta);
//                        }
//                        break;

//                    case 5:
//                        Console.WriteLine("Ingrese el nombre de la canción que desea reproducir");
//                        respuesta = Console.ReadLine();
//                        MusicPlayer.Reproducircancion(respuesta);
//                        Console.WriteLine($"Se está reproduciendo la canción: {respuesta}  ");
//                        break;


//                }

//            } while (op != 10);
//        }
//    }
//}
