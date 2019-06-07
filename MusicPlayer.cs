using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion
{
    class MusicPlayer
    {
        public string Numero { get; set; }
        public string Nombre { get; set; }
        public double Reproducir { get; set; }
        public double Reproducir2 { get; set; }



        public MusicPlayer(string numero, string nombre, double reproducir, double reproducir2)
        {
            Nombre = nombre;
            Numero = numero;
            Reproducir = reproducir;
            Reproducir2 = reproducir2;
        }

        public static List<MusicPlayer> Musica = new List<MusicPlayer>();

        public static void Agregar(MusicPlayer musica)
        {
            Musica.Add(musica);
        }

        public static void Listar()
        {
            Console.WriteLine("Total de canciones : {0}", Musica.Count());
            Console.WriteLine("|----------LISTADO DE CANCIONES----------|");
            foreach (MusicPlayer musica in Musica)
            {

            }
        }
        public static void Imprimir(MusicPlayer musica)
        {
            Console.WriteLine("___________________________________________");
            Console.WriteLine("Número : {0} | Nombre: {1} ", musica.Numero, musica.Nombre);
            Console.WriteLine("___________________________________________");
        }

        //BUSCAR
        public static MusicPlayer Buscar(string numero)
        {
            foreach (MusicPlayer musica in Musica)
            {
                if (musica.Numero.Equals(numero))
                {
                    return musica;
                }
            }
            return null;
        }

        //ELIMINAR
        public static bool Eliminar(string numero)
        {
            MusicPlayer musica = Buscar(numero);
            if (Musica != null)
            {
                Musica.Remove(musica);
                return true;
            }
            return false;
        }

        //CAMBIAR NOMBRE
        public static bool ModificarNombre(string numero, string nombre)
        {
            foreach (MusicPlayer musica in Musica)
            {
                if (musica.Nombre.Equals(numero))
                {
                    musica.Nombre = nombre;
                    return true;
                }
            }
            return false;
        }

        public static bool Reproducircancion(string nombre)
        {
            foreach (MusicPlayer musica in Musica)
            {
                if (musica.Nombre.Equals(nombre))
                {
                    musica.Nombre = nombre;
                    return true;
                }
            }
            return false;
        }


        public virtual void Avanzar()
        {
            Console.WriteLine("¿Desea reproducir la siguiente canción? [si] [no]");
            var result = Console.ReadLine();
            if (result == "si" && result == "SI")
            {
                for (int i = 0; i < Reproducir; i++)
                {
                    Console.WriteLine($"Se está reproduciendo la canción {i} ");
                }
                Console.WriteLine($"El vehiculo llegó a la velocidad de {Reproducir}");
            }
        }

        public virtual void Reroceder()
        {
            Console.WriteLine("¿Desea reproducir la canción anterior? [si] [no]");
            var result = Console.ReadLine();
            if (result == "si")
            {
                for (int i = 100; i >= 0; i--)
                {
                    Console.WriteLine($"Se está reproduciendo la canción {i} ");
                }
                Console.WriteLine($"El vehiculo llegó a la velocidad de {Reproducir2}");
            }
        }
    }
}

