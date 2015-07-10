using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenClosePrinciple
{
   public class ProgramadorJr : Programador
    {
       public ProgramadorJr(decimal sueldoDiario, int diasTrabajados) : base(sueldoDiario, diasTrabajados) { }


       //implementación patrón method template
       public override decimal CalcularPago()
       {
           //calculo del pago para un programador junior....
           return (base.DiasTrabajados * SueldoDiario) * 1.15M;
       }
    }
}
