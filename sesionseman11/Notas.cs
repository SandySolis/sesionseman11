using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notas_Menu
{
    public class Notas
    {
        public List<int> notas = new List<int>();

        public void RegistrarNota()
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("================================");
                Console.WriteLine("Registrar una nota");
                Console.WriteLine("================================");
                Console.Write("Ingresa la nota Nro {0}: ", notas.Count + 1);
                int nota = Convert.ToInt32(Console.ReadLine());
                notas.Add(nota);
                Console.WriteLine("================================");
                Console.WriteLine("1: Registrar otra nota");
                Console.WriteLine("2: Regresar");
                Console.Write("Ingrese una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());
            } while (opcion == 1);
        }
        public void HallarNotaMayor()
        {
            int opcion = 0;
            do
            {
                int notaMayor = -1;
                foreach (int nota in notas)
                {
                    if (nota > notaMayor)
                        notaMayor = nota;
                }
                Console.WriteLine("================================");
                Console.WriteLine("La nota mayor");
                Console.WriteLine("================================");
                Console.WriteLine("La nota mayor es: {0}", notaMayor);
                for (int i = 0; i < notas.Count; i++)
                {
                    if (notas[i] == notaMayor)
                        Console.Write("[{0}] ", notas[i]);
                    else
                        Console.Write("{0} ", notas[i]);
                }
                Console.WriteLine("\n================================");
                Console.WriteLine("1: Regresar");
                Console.Write("Ingrese una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());
            } while (opcion != 1);
        }
        public void HallarNotaMenor()
        {
            int opcion = 0;
            do
            {
                int notaMenor = Int32.MaxValue;
                foreach (int nota in notas)
                {
                    if (nota < notaMenor)
                        notaMenor = nota;
                }
                Console.WriteLine("================================");
                Console.WriteLine("La nota menor");
                Console.WriteLine("================================");
                Console.WriteLine("La nota menor es: {0}", notaMenor);
                for (int i = 0; i < notas.Count; i++)
                {
                    if (notas[i] == notaMenor)
                        Console.Write("[{0}] ", notas[i]);
                    else
                        Console.Write("{0} ", notas[i]);
                }
                Console.WriteLine("\n================================");
                Console.WriteLine("1: Regresar");
                Console.Write("Ingrese una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());
            } while (opcion != 1);
        }
        public void EncontrarNota()
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("================================");
                Console.WriteLine("Buscar nota");
                Console.WriteLine("================================");
                Console.Write("Ingrese la nota a buscar: ");
                int notaBuscada = Convert.ToInt32(Console.ReadLine());
                int posicion = notas.IndexOf(notaBuscada);
                if (posicion != -1)
                {
                    Console.WriteLine("La nota está en la posición {0}", posicion + 1);
                    for (int i = 0; i < notas.Count; i++)
                    {
                        if (i == posicion)
                            Console.WriteLine("{0} -> [{1}]", i + 1, notas[i]);
                        else
                            Console.WriteLine("{0} -> {1}", i + 1, notas[i]);
                    }
                }
                else
                    Console.WriteLine("La nota no se encuentra en la lista de notas.");
                Console.WriteLine("================================");
                Console.WriteLine("1: Regresar");
                Console.Write("Ingrese una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());
            } while (opcion != 1);
        }
        public void ModificarNota()
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("================================");
                Console.WriteLine("Modificar nota");
                Console.WriteLine("================================");
                Console.Write("Ingrese la posición: ");
                int posicion = Convert.ToInt32(Console.ReadLine()) - 1;

                if (posicion >= 0 && posicion < notas.Count)
                {
                    Console.Write("Ingrese el nuevo valor: ");
                    int nuevoValor = Convert.ToInt32(Console.ReadLine());

                    int notaAnterior = notas[posicion];
                    notas[posicion] = nuevoValor;

                    Console.WriteLine("================================");
                    Console.WriteLine("Antes:");
                    for (int i = 0; i < notas.Count; i++)
                        if (i == posicion)
                            Console.Write("[{0}] ", notaAnterior);
                        else
                            Console.Write("{0} ", notas[i]);
                    Console.WriteLine("\nDespués:");
                    for (int i = 0; i < notas.Count; i++)
                        if (i == posicion)
                            Console.Write("[{0}] ", notas[i]);
                        else
                            Console.Write("{0} ", notas[i]);
                    Console.WriteLine("\n================================");
                    Console.WriteLine("1: Regresar");
                    Console.Write("Ingrese una opción: ");
                    opcion = Convert.ToInt32(Console.ReadLine());
                }
                else
                    Console.WriteLine("Posición inválida.");
            } while (opcion != 1);
        }
        public void VerNotas()
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("================================");
                Console.WriteLine("Notas Registradas");
                Console.WriteLine("================================");
                Console.WriteLine("Notas actuales:");
                for (int i = 0; i < notas.Count; i++)
                    Console.Write("{0} ", notas[i]);
                Console.WriteLine("\nSiguiente posición será: {0}", notas.Count + 1);
                Console.WriteLine("================================");
                Console.WriteLine("1: Regresar");
                Console.Write("Ingrese una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());
            } while (opcion != 1);
        }
    }
}