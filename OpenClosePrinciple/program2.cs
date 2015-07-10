using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenClosePrinciple
{
    class program2
    {
        static void Main(string[] args)
        {
            //constantes sueldoDiario
              const decimal SueldoNovel = 300;
              const decimal SueldoJr = 400;
              const decimal SueldoSr = 550;
              List<Programador> listaProgramadores = new List<Programador>();
              var pedro = new ProgramadorNovel( SueldoNovel,15) { Codigo = 1, Nombre = "Pedro Pérez"};
              listaProgramadores.Add(pedro);
              var paco = new ProgramadorNovel(SueldoNovel, 15) { Codigo = 2, Nombre = "Paco López"};
              listaProgramadores.Add(paco);
              var vinicio = new ProgramadorJr(SueldoJr,15) { Codigo = 3, Nombre = "Vinicio Suarez" };
              listaProgramadores.Add(vinicio);
              var eugenia = new ProgramadorSr(SueldoSr,15) { Codigo = 4, Nombre = "Eugenia Carrera" };
              listaProgramadores.Add(eugenia);
              var betty = new ProgramadorJr(SueldoJr,15) { Codigo = 5, Nombre = "Betty Benavides"};
              listaProgramadores.Add(betty);
              var miguel = new ProgramadorSr(SueldoSr,15) { Codigo = 6, Nombre = "Miguel Sánchez"};
              listaProgramadores.Add(miguel);
              decimal total = 0;
              var servicioNomina = new CalculadorDeNominaService();
              total = servicioNomina.CalcularNomina(listaProgramadores);
              Console.WriteLine("El total de la nomina es: ${0}", total);
              Console.ReadKey();


        }

    }
}
