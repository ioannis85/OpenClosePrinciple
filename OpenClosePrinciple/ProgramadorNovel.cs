using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenClosePrinciple
{
   public class ProgramadorNovel:Programador
    {
       public ProgramadorNovel(decimal sueldoDiario, int diasTrabajados) : base(sueldoDiario, diasTrabajados) { }

       //implementación patrón method template
     public override decimal CalcularPago()
     {
          //calculo del pago para un programador novel....
       return (base.DiasTrabajados * SueldoDiario) * 1.10M;  
     }

    }
}
