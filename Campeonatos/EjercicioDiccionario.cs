using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campeonatos
{
    public class EjercicioDiccionario
    {
        public static void ClubesTitulos()
        {
            string equipo = string.Empty;
            int campeonatos = 0;
            var titulosXEquipo = new Dictionary<string, int>();
            Console.WriteLine("Ingrese los equipos del campeonato. ");
            Console.WriteLine("Y cuando quiera dejar de ingresar coloque la palabra Basta");
            do
            {
                Console.WriteLine("Ingrese un equipo");
                equipo = Console.ReadLine();

                if (equipo != "Basta")
                {
                    Console.WriteLine("Ingrese la cantidad de campeonatos: ");
                    campeonatos = Convert.ToInt32(Console.ReadLine());
                    titulosXEquipo.Add(equipo, campeonatos);
                }
            }
            while (equipo != "Basta");

            foreach (KeyValuePair<string, int> titulos in titulosXEquipo.OrderBy(x => x.Value))  //Lambda
            {
                Console.WriteLine($"El equipo {titulos.Key} tiene {titulos.Value} titulos ");
            }
        }
    }
}
