using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenClosePrinciple
{
    /*
     * 
     * Ejemplo calculador de Nomina.
     * 
     */
   public class CalculadorDeNominaService
    {

       //metodo anterior 
       public decimal CalcularNomina(IEnumerable<ProgramadorSinOCP> programadores)
       {
           decimal total = 0;
           foreach (var programador in programadores)
           {
               var importe = programador.CalcularPago();
               string tipoProgramador = Enum.GetName(typeof(TipoProgramador), programador.Tipo);
               total += importe;
               //método de refactorización del Console.WriteLine
               ImprimirDetalle(programador.Nombre, tipoProgramador, importe);
           }
           return total;
       }

       //sobrecarga que favorecerá el calculo de nómina 
       public decimal CalcularNomina(IEnumerable<Programador> programadores)
       {
           decimal total = 0;
           //codigo mejorado con una expresión  lambda
           programadores.ToList().ForEach((p) =>{
               decimal importe =  p.CalcularPago();
               total += importe;
               ImprimirDetalle(p.Nombre, p.GetType().Name, importe);
           });
           return total;
       }

       private void ImprimirDetalle(string nombre, string tipo, decimal importe)
       {
           Console.WriteLine("{0} programador {1} Pago Quincenal: ${2}",
                 nombre, tipo, importe);
       }

    }
}
