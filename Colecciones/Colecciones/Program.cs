using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Persona> turnos = new Queue<Persona>();
            Persona cliente;
           // int indice=0;
            bool agregarMas = true;
            string nom, apel, dni;
            string answer;

            while(agregarMas)
            {
                Console.Write("Ingrese Nombre: "); 
                nom = Console.ReadLine();
                Console.Write("Ingrese Apellido: "); 
                apel = Console.ReadLine();
                Console.Write("Ingrese DNI: "); 
                dni = Console.ReadLine();
                cliente = new Persona(nom,apel,dni);
                turnos.Enqueue(cliente);
                Console.Write("Continuar Cargando?...S or N: ");
                answer = Console.ReadLine();
                if (answer == "S") agregarMas = true;
                else agregarMas = false;
            }

            int i = 1;
            foreach(Persona value in turnos)
            {
                Console.WriteLine("Turno {0}: {1} {2} - DNI: {3}", i.ToString(), value.nombre, value.apellido, value.dni);
                i++;
            }
            Console.ReadKey();
    }
    }
}
    