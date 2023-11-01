using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notas_Menu
{
    internal class Program
    {
        static Notas notas = new Notas();

        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("================================");
                Console.WriteLine("Casos con arreglos");
                Console.WriteLine("================================");
                Console.WriteLine("1: Registrar notas");
                Console.WriteLine("2: Hallar la nota mayor");
                Console.WriteLine("3: Hallar la nota menor");
                Console.WriteLine("4: Encontrar una nota");
                Console.WriteLine("5: Modificar una nota");
                Console.WriteLine("6: Ver notas registradas");
                Console.WriteLine("7: Salir");
                Console.WriteLine("================================");
                Console.Write("Ingrese una opción: ");

                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        notas.RegistrarNota();
                        break;
                    case 2:
                        notas.HallarNotaMayor();
                        break;
                    case 3:
                        notas.HallarNotaMenor();
                        break;
                    case 4:
                        notas.EncontrarNota();
                        break;
                    case 5:
                        notas.ModificarNota();
                        break;
                    case 6:
                        notas.VerNotas();
                        break;
                    case 7:
                        return;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
    }
}
