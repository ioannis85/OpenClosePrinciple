using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenClosePrinciple
{
   public  class ProgramadorSr:Programador
    {
       public ProgramadorSr(decimal sueldoDiario, int diasTrabajados) : base(sueldoDiario,diasTrabajados) { }
       //implementación patrón method template
       public override decimal CalcularPago()
       {
           //calculo del pago para un programador Senior....
           return (base.DiasTrabajados * SueldoDiario) * 1.25M;
       }

    }
}
