using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenClosePrinciple
{
    public abstract class Programador
    {
       
        public Programador(decimal sueldoDiario,int diasTrabajados)
        {
            this.SueldoDiario = sueldoDiario;
            this.DiasTrabajados = diasTrabajados;
        }
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal SueldoDiario { get; private set;}
        public int DiasTrabajados { get; private set; }
        //patron Method Template https://es.wikipedia.org/wiki/Template_Method_(patr%C3%B3n_de_dise%C3%B1o)   para poder calcular el Pago según el tipo de programador
        public abstract decimal CalcularPago();
        
    }
}
