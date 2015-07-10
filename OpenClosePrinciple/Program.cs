using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenClosePrinciple
{

    /*
     * Programa Sin Open close Principle
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {

            List<ProgramadorSinOCP> listaProgramadores= new List<ProgramadorSinOCP>();

            var pedro = new ProgramadorSinOCP() 
            {Codigo=1,Nombre="Pedro Pérez",Tipo=TipoProgramador.Novel};
            listaProgramadores.Add(pedro);
            var paco = new ProgramadorSinOCP()
            { Codigo = 2, Nombre = "Paco López", Tipo = TipoProgramador.Novel};
            listaProgramadores.Add(paco);
            var vinicio = new ProgramadorSinOCP()
            { Codigo = 3, Nombre = "Vinicio Suarez", Tipo = TipoProgramador.Jr};
            listaProgramadores.Add(vinicio);
            var eugenia = new ProgramadorSinOCP()
            { Codigo = 4, Nombre = "Eugenia Carrera", Tipo = TipoProgramador.Sr };
            listaProgramadores.Add(eugenia);
            var betty = new ProgramadorSinOCP() 
            { Codigo = 5, Nombre = "Betty Benavides", Tipo = TipoProgramador.Jr };
              listaProgramadores.Add(betty);
            var miguel = new ProgramadorSinOCP() 
            { Codigo = 6, Nombre = "Miguel Sánchez", Tipo = TipoProgramador.Sr };
            listaProgramadores.Add(miguel);

            decimal total = 0; 
            var servicioNomina = new CalculadorDeNominaService();
          total =  servicioNomina.CalcularNomina(listaProgramadores);

          Console.WriteLine("El total de la nomina es: ${0}", total);
          Console.ReadKey();
            
        }

    }
}
